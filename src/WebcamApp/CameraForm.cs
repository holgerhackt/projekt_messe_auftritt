﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Models;
using Models.DTOs;
using WebcamApp.OfflineDB;
using WebcamApp.Properties;

namespace WebcamApp;

internal partial class CameraForm : Form
{
    private FilterInfoCollection? _filterInfoCollection;
    private VideoCaptureDevice? _videoCaptureDevice;
    private IEnumerable<Interest>? _interests;
    private IEnumerable<Company>? _companies;
    private readonly OfflineContext _context;
    private readonly IMapper _mapper = AutoMapperConfiguration.Configure();
    private byte[] _image;


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

        /*pictureBox1.Image.Save("Test.jpeg");*/
        _videoCaptureDevice.SignalToStop();
        _image = ImageToByteArray(pictureBox1.Image);
    }

    private async void Submit_Click(object sender, EventArgs e)
    {
        try
        {
            User user = new User()
            {
                Name = textBoxName.Text,
                Image = _image,
                Address = new Address()
                {
                    Country = textBoxCountry.Text,
                    City = textBoxCity.Text,
                    PostalCode = textBoxPostcode.Text,
                    Street = textBoxStreet.Text,
                    HouseNumber = textBoxHousenumber.Text
                },
                Interests = interestsCheckedListBox.CheckedItems.Cast<Interest>().ToList(),
                Company = companyCheckedListBox.CheckedItems.Cast<Company>().SingleOrDefault()
            };
            var dbUser = _context.Add(user);
            await _context.SaveChangesAsync();

            string text = string.Format(Resources.UserCreationSuccessText, user.Name);
            MessageBox.Show(text, Resources.UserCreationSuccessCaption);
            ClearInputFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void ClearInputFields()
    {
        panel2.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Clear());
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
    }

    private void AddNewCompanyBtn_Click(object sender, EventArgs e)
    {
        //Return if duplicate
        foreach (var item in companyCheckedListBox.Items)
        {
            if (item is Company cmp && cmp.Name == CompanyNameTxtBox.Text)
            {
                CompanyNameTxtBox.ResetText();
                CompanyCountryTxtBox.ResetText();
                CompanyCityTxtBox.ResetText();
                CompanyPostalTxtBox.ResetText();
                CompanyStreetTxtBox.ResetText();
                CompanyHouseNrTxtBox.ResetText();

                NewCompanyPnl.Visible = false;
                NewCompanyBtn.Visible = true;
                return;
            }
        }

        if (CompanyNameTxtBox.Text == "") return;

        Company company = new Company()
        {
            Name = CompanyNameTxtBox.Text,
            Address = new Address()
            {
                Country = CompanyCountryTxtBox.Text,
                City = CompanyCityTxtBox.Text,
                PostalCode = CompanyPostalTxtBox.Text,
                Street = CompanyStreetTxtBox.Text,
                HouseNumber = CompanyHouseNrTxtBox.Text
            }
        };

        var dbUser = _context.Add(company);
        _context.SaveChangesAsync();

        companyCheckedListBox.Items.Clear();
        var _companies = _context.Company.ToList();
        foreach (var comp in _companies) companyCheckedListBox.Items.Add(comp);

        //Checkbox ticked for newly added company
        for (int i = 0; i < companyCheckedListBox.Items.Count; i++)
        {
            if (companyCheckedListBox.Items[i] is Company cmp && cmp.Name == company.Name) companyCheckedListBox.SetItemChecked(i, true);
        }

        CompanyNameTxtBox.ResetText();
        CompanyCountryTxtBox.ResetText();
        CompanyCityTxtBox.ResetText();
        CompanyPostalTxtBox.ResetText();
        CompanyStreetTxtBox.ResetText();
        CompanyHouseNrTxtBox.ResetText();

        NewCompanyPnl.Visible = false;
        NewCompanyBtn.Visible = true;
    }
}