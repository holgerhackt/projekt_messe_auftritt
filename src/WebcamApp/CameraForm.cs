using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AutoMapper;
using Models;
using WebcamApp.OfflineDB;
using WebcamApp.Properties;

namespace WebcamApp;

internal partial class CameraForm : Form
{
    private FilterInfoCollection? _filterInfoCollection;
    private VideoCaptureDevice? _videoCaptureDevice;
    private readonly OfflineContext? _context;  //null if login failed and is intended
    private readonly IMapper _mapper = AutoMapperConfiguration.Configure();
    private byte[]? _image;  //null if no image taken

    public CameraForm()
    {
        InitializeComponent();

        var loginForm = new LoginForm();
        if (loginForm.ShowDialog() != DialogResult.OK)
        {
            Close();
            return;
        }

        _context = new OfflineContext();
        FillCheckedListBoxes();
    }


    private void FillCheckedListBoxes()
    {
        interestsCheckedListBox.DisplayMember = nameof(Interest.Name);
        companyCheckedListBox.DisplayMember = nameof(Company.Name);
        interestsCheckedListBox.ValueMember = nameof(Interest.Id);
        companyCheckedListBox.ValueMember = nameof(Company.Id);

        var _interests = _context.Interests.ToList();
        foreach (var interest in _interests) interestsCheckedListBox.Items.Add(interest);

        var _companies = _context.Company.ToList();
        foreach (var company in _companies) companyCheckedListBox.Items.Add(company);
    }

    private void StartCameraButton_Click(object sender, EventArgs e)
    {
        if (_filterInfoCollection == null)
        {
            MessageBox.Show("No Camera selected");
            return;
        }

        // Stop previous capture
        if (_videoCaptureDevice?.IsRunning == true)
        {
            _videoCaptureDevice.NewFrame -= VideoCaptureDevice_NewFrame;
            _videoCaptureDevice.SignalToStop();
        }

        _videoCaptureDevice = new VideoCaptureDevice(_filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
        _videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
        _videoCaptureDevice.Start();
    }

    private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
    {
        var frame = (Bitmap)eventArgs.Frame.Clone();
        Invoke(() => NewFrameOnUiThread(frame));
    }

    private void NewFrameOnUiThread(Bitmap frame)
    {
        pictureBox1.Image = frame;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        _filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        foreach (FilterInfo filterInfo in _filterInfoCollection) cboCamera.Items.Add(filterInfo.Name);

        cboCamera.SelectedIndex = 0;
        _videoCaptureDevice = new VideoCaptureDevice();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (_videoCaptureDevice?.IsRunning == true)
        {
            _videoCaptureDevice.SignalToStop();
            _videoCaptureDevice.WaitForStop();
        }
    }

    public byte[] ImageToByteArray(Image img)
    {
        var converter = new ImageConverter();
        return (byte[])converter.ConvertTo(img, typeof(byte[]));
    }

    private void PhotoButton_Click(object sender, EventArgs e)
    {
        if (pictureBox1.Image == null)
        {
            MessageBox.Show("No image");
            return;
        }
        _videoCaptureDevice!.SignalToStop();
        _image = ImageToByteArray(pictureBox1.Image);
    }

    private async void Submit_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(ForenameTextBox.Text) || string.IsNullOrWhiteSpace(LastnameTextBox.Text))
            {
                MessageBox.Show("Please enter your full name!");
                return;
            }

            HashSet<string> integerFields = new HashSet<string> { PostalcodeTextBox.Name, HousenumberTextBox.Name };
            HashSet<string> stringFields = new HashSet<string> { ForenameTextBox.Name, LastnameTextBox.Name, CountryTextbox.Name, CityTextBox.Name, textBoxStreet.Name };
            bool hasInvalidContent = ValidateTextBoxContent(NewUserPanel, integerFields, stringFields);
            if (hasInvalidContent) return;
            
            User user = new User()
            {
                Forename = ForenameTextBox.Text,
                Lastname = LastnameTextBox.Text,
                Image = _image,
                Interests = interestsCheckedListBox.CheckedItems.Cast<Interest>().ToList(),
                Company = companyCheckedListBox.CheckedItems.Cast<Company>().SingleOrDefault()
            };
            if (IsAnyUserAddressTextBoxFilled())
            {
                user.Address = new Address()
                {
                    Country = CountryTextbox.Text,
                    City = CityTextBox.Text,
                    PostalCode = int.Parse(PostalcodeTextBox.Text),
                    Street = textBoxStreet.Text,
                    HouseNumber = int.Parse(HousenumberTextBox.Text)
                };
            }
            _context!.Users.Add(user);
            await _context.SaveChangesAsync();

            string text = string.Format(Resources.UserCreationSuccessText, user.Forename + " " + user.Lastname);
            MessageBox.Show(text, Resources.UserCreationSuccessCaption);
            ClearInputFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private bool ValidateTextBoxContent(Panel panel, HashSet<string> integerFieldNames, HashSet<string> stringFieldNames)
    {
        List<string> invalidIntegerFields = new List<string>();
        List<string> invalidStringFields = new List<string>();

        foreach (TextBox textBox in panel.Controls.OfType<TextBox>())
        {
            if (integerFieldNames.Contains(textBox.Name) && !string.IsNullOrWhiteSpace(textBox.Text) && !int.TryParse(textBox.Text, out _))
            {
                invalidIntegerFields.Add(textBox.Tag.ToString()!);
            }
            else if (stringFieldNames.Contains(textBox.Name) && int.TryParse(textBox.Text, out _))
            {
                invalidStringFields.Add(textBox.Tag.ToString()!);
            }
        }

        List<string> errorMessageParts = new List<string>();
        if (invalidIntegerFields.Any())
        {
            errorMessageParts.Add($"Please enter valid integer literals for the following fields: {string.Join(", ", invalidIntegerFields)}");
        }
        if (invalidStringFields.Any())
        {
            errorMessageParts.Add($"Please enter valid string literals for the following fields: {string.Join(", ", invalidStringFields)}");
        }

        if (errorMessageParts.Any())
        {
            MessageBox.Show(string.Join("\n", errorMessageParts), "Validation Error");
            return true;
        }

        return false;

    }


    private void ClearInputFields()
    {
        NewUserPanel.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
        var checkedIndices = companyCheckedListBox.CheckedIndices.Cast<int>().ToList();
        foreach (var index in checkedIndices)
        {
            companyCheckedListBox.SetItemChecked(index, false);
        }
        checkedIndices = interestsCheckedListBox.CheckedIndices.Cast<int>().ToList();
        foreach (var index in checkedIndices)
        {
            interestsCheckedListBox.SetItemChecked(index, false);
        }
        if (_videoCaptureDevice?.IsRunning == true) _videoCaptureDevice.SignalToStop();
        pictureBox1.Image = null;
    }
    private void NewCompanyBtn_Click(object sender, EventArgs e)
    {
        NewCompanyPnl.Visible = true;
        NewCompanyBtn.Visible = false;
        ReturnToCompanies.Visible = true;
    }

    private void ResetCompanyPanel()
    {
        NewCompanyPnl.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
        NewCompanyPnl.Visible = false;
        ReturnToCompanies.Visible = false;
        NewCompanyBtn.Visible = true;
    }

    private bool IsAnyCompanyAddressTextBoxFilled()
    {
        foreach (TextBox textBox in NewCompanyPnl.Controls.OfType<TextBox>())
        {
            if (textBox.Name != "CompanyNameTxtBox" && !string.IsNullOrWhiteSpace(textBox.Text))
            {
                return true;
            }
        }
        return false;
    }
    private bool IsAnyUserAddressTextBoxFilled()
    {
        foreach (TextBox textBox in NewUserPanel.Controls.OfType<TextBox>())
        {
            if (textBox.Name != "ForenameTextBox" && textBox.Name != "LastnameTextBox" && !string.IsNullOrWhiteSpace(textBox.Text))
            {
                return true;
            }
        }
        return false;
    }

    private void AddNewCompanyBtn_Click(object sender, EventArgs e)
    {
        //Return if duplicate
        foreach (var item in companyCheckedListBox.Items)
        {
            if (item is Company cmp && cmp.Name == CompanyNameTxtBox.Text)
            {
                ResetCompanyPanel();
                return;
            }
        }

        if (CompanyNameTxtBox.Text == "")
        {
            MessageBox.Show("Please enter a company name!");
            return;
        }

        Company company = new Company()
        {
            Name = CompanyNameTxtBox.Text
        };
        if (IsAnyCompanyAddressTextBoxFilled())
        {
            company.Address = new Address()
            {
                Country = CompanyCountryTxtBox.Text,
                City = CompanyCityTxtBox.Text,
                PostalCode = int.Parse(CompanyPostalTxtBox.Text),
                Street = CompanyStreetTxtBox.Text,
                HouseNumber = int.Parse(CompanyHouseNrTxtBox.Text)
            };
        }
        //else company.Address = null automatically
        _context!.Company.Add(company);
        _context.SaveChanges();

        companyCheckedListBox.Items.Clear();
        var companies = _context.Company.ToList();
        foreach (var comp in companies) companyCheckedListBox.Items.Add(comp);

        //Checkbox ticked for newly added company
        for (int i = 0; i < companyCheckedListBox.Items.Count; i++)
        {
            if (companyCheckedListBox.Items[i] is Company cmp && cmp.Name == company.Name) companyCheckedListBox.SetItemChecked(i, true);
        }
        ResetCompanyPanel();
    }

    private void ReturnToCompanies_Click(object sender, EventArgs e)
    {
        ResetCompanyPanel();
    }
}