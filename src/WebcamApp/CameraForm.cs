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
    private readonly OfflineContext? _context; //null if login failed and is intended
    private readonly IMapper _mapper = AutoMapperConfiguration.Configure();
    private FilterInfoCollection? _filterInfoCollection;
    private byte[]? _image;
    private VideoCaptureDevice? _videoCaptureDevice;

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
        Validator = new InputFieldValidator();
    }

    private InputFieldValidator? Validator { get; }


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

    private void ClearInputFields()
    {
        NewUserPanel.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
        var checkedIndices = companyCheckedListBox.CheckedIndices.Cast<int>().ToList();
        foreach (var index in checkedIndices) companyCheckedListBox.SetItemChecked(index, false);
        checkedIndices = interestsCheckedListBox.CheckedIndices.Cast<int>().ToList();
        foreach (var index in checkedIndices) interestsCheckedListBox.SetItemChecked(index, false);
        if (_videoCaptureDevice?.IsRunning == true)
        {
            _videoCaptureDevice.NewFrame -= VideoCaptureDevice_NewFrame;
            _videoCaptureDevice.SignalToStop();
        }

        _videoCaptureDevice = new VideoCaptureDevice(_filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
        _videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
        _videoCaptureDevice.Start();
    }

    private Address CreateAddress(Panel panel, HashSet<string> excludedTextBoxNames)
    {
        var address = new Address();
        foreach (var textBox in panel.Controls.OfType<TextBox>())
        {
            if (excludedTextBoxNames.Contains(textBox.Name)) continue;
            switch (textBox.Tag.ToString())
            {
                case "Country":
                    address.Country = string.IsNullOrWhiteSpace(textBox.Text) ? null : textBox.Text;
                    break;
                case "City":
                    address.City = string.IsNullOrWhiteSpace(textBox.Text) ? null : textBox.Text;
                    break;
                case "Postalcode":
                    address.PostalCode = string.IsNullOrWhiteSpace(textBox.Text) ? null : int.Parse(textBox.Text);
                    break;
                case "Street":
                    address.Street = string.IsNullOrWhiteSpace(textBox.Text) ? null : textBox.Text;
                    break;
                case "Housenumber":
                    address.HouseNumber = string.IsNullOrWhiteSpace(textBox.Text) ? null : textBox.Text;
                    break;
            }
        }

        return address;
    }

    private async void Submit_Click(object sender, EventArgs e)
    {
        try
        {
            var isUsernameValid = Validator!.ValidateUsername(ForenameTextBox.Text, LastnameTextBox.Text);
            if (!isUsernameValid)
            {
                MessageBox.Show("Please enter a valid username!");
                return;
            }

            if (!string.IsNullOrWhiteSpace(PostalcodeTextBox.Text) && !int.TryParse(PostalcodeTextBox.Text, out _))
            {
                MessageBox.Show("Please enter a valid postal code!");
                return;
            }

            var errorMessage = Validator!.ValidateTextBoxContent(NewUserPanel, CountryTextbox.Name,
                HousenumberTextBox.Name, EmailTextBox.Name, CityTextBox.Name);
            if (errorMessage != null)
            {
                MessageBox.Show(errorMessage, "Validation Error");
                return;
            }

            var user = new User
            {
                Forename = ForenameTextBox.Text,
                Lastname = LastnameTextBox.Text,
                Email = EmailTextBox.Text,
                Image = _image,
                Interests = interestsCheckedListBox.CheckedItems.Cast<Interest>().ToList(),
                Company = companyCheckedListBox.CheckedItems.Cast<Company>().SingleOrDefault()
            };
            var userExcludedNames = new HashSet<string> { "ForenameTextBox", "LastnameTextBox" };
            var addressPropertyFilled = Validator.IsAnyAddressPropertyFilled(NewUserPanel, userExcludedNames);
            if (addressPropertyFilled) user.Address = CreateAddress(NewUserPanel, userExcludedNames);
            _context!.Users.Add(user);
            await _context.SaveChangesAsync();

            var text = string.Format(Resources.UserCreationSuccessText, user.Forename + " " + user.Lastname);
            MessageBox.Show(text, Resources.UserCreationSuccessCaption);
            ClearInputFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    #region Camera

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

    #endregion


    #region Company

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

    private void AddNewCompanyBtn_Click(object sender, EventArgs e)
    {
        //Return if duplicate
        foreach (var item in companyCheckedListBox.Items)
            if (item is Company cmp && cmp.Name == CompanyNameTxtBox.Text)
            {
                ResetCompanyPanel();
                return;
            }

        if (CompanyNameTxtBox.Text == "") //Company names can be creative and contain numbers
        {
            MessageBox.Show("Please enter a company name!");
            return;
        }

        if (!string.IsNullOrWhiteSpace(CompanyPostalTxtBox.Text) && !int.TryParse(CompanyPostalTxtBox.Text, out _))
        {
            MessageBox.Show("Please enter a valid postal code!");
            return;
        }

        var errorMessage = Validator!.ValidateTextBoxContent(NewCompanyPnl, CompanyCountryTxtBox.Name,
            CompanyHouseNrTxtBox.Name, null, CompanyCityTxtBox.Name);
        if (errorMessage != null)
        {
            MessageBox.Show(errorMessage, "Validation Error");
            return;
        }

        var company = new Company
        {
            Name = CompanyNameTxtBox.Text
        };
        var companyExcludedNames = new HashSet<string> { "CompanyNameTxtBox" };
        var companyAddressPropertyFilled = Validator!.IsAnyAddressPropertyFilled(NewCompanyPnl, companyExcludedNames);
        if (companyAddressPropertyFilled) company.Address = CreateAddress(NewCompanyPnl, companyExcludedNames);
        _context!.Company.Add(company);
        _context.SaveChanges();

        companyCheckedListBox.Items.Clear();
        var companies = _context.Company.ToList();
        foreach (var comp in companies) companyCheckedListBox.Items.Add(comp);

        //Checkbox ticked for newly added company
        for (var i = 0; i < companyCheckedListBox.Items.Count; i++)
            if (companyCheckedListBox.Items[i] is Company cmp && cmp.Name == company.Name)
                companyCheckedListBox.SetItemChecked(i, true);
        ResetCompanyPanel();
    }

    private void ReturnToCompanies_Click(object sender, EventArgs e)
    {
        ResetCompanyPanel();
    }

    #endregion
}