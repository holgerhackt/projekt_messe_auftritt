using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Models;

namespace WebcamApp;

public partial class CameraForm : Form
{
	private readonly HttpClient _httpClient;
	private FilterInfoCollection? _filterInfoCollection;
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

		_httpClient = loginForm.HttpClient;
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
		pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
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

	private async void PhotoButton_Click(object sender, EventArgs e)
	{
		if (pictureBox1.Image == null)
		{
			MessageBox.Show("No image");
			return;
		}

		pictureBox1.Image.Save("Test.jpeg");
		var bytes = ImageToByteArray(pictureBox1.Image);
		try
		{
			var requestData = new User
			{
				Name = textBoxName.Text,
				//Data = bytes,
				Address = new Address
				{
					Country = textBoxCountry.Text, City = textBoxCity.Text, PostalCode = textBoxPostcode.Text,
					Street = textBoxStreet.Text, HouseNumber = textBoxHousenumber.Text
				},
				Interests = new List<Interest>()
			};
			var json = JsonSerializer.Serialize(requestData, SerializerOptions.ApiServerOptions);
			var content = new StringContent(json, Encoding.UTF8, "application/json");
			var response = await _httpClient.PostAsync("/api/Users", content);
			if (response.StatusCode != HttpStatusCode.Created)
			{
				var contentJsonString = JsonSerializer.Serialize(requestData, SerializerOptions.ApiServerOptions);
				File.WriteAllText(
					$"{textBoxCountry.Text}_{textBoxCity.Text}_{textBoxPostcode.Text}_{textBoxName.Text}.json",
					contentJsonString);
			}

			var responseContent = await response.Content.ReadAsStringAsync();
			MessageBox.Show(responseContent, response.StatusCode.ToString());
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}
}