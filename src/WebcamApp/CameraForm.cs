using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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
using WebcamApp.Properties;

namespace WebcamApp;

internal partial class CameraForm : Form
{
	private readonly ApiClient _apiClient;
	private FilterInfoCollection? _filterInfoCollection;
	private VideoCaptureDevice? _videoCaptureDevice;
	private List<Interest>? _interests;
	private List<Company>? _companies;

	public CameraForm()
	{
		InitializeComponent();

		var loginForm = new LoginForm();
		if (loginForm.ShowDialog() != DialogResult.OK)
		{
			Close();
			return;
		}

		_apiClient = loginForm.ApiClient;
		interestsCheckedListBox.DisplayMember = nameof(Interest.Name);
		interestsCheckedListBox.ValueMember = nameof(Interest.Id);
		_apiClient.GetInterestsAsync().ContinueWith(task =>
		{
			if (task.Exception != null)
			{
				MessageBox.Show(task.Exception.Message);
				return;
			}

			_interests = task.Result;
			if (_interests == null) return;

			Invoke(AddInterests);
		});
	}

	private void AddInterests()
	{
		foreach (var interest in _interests) interestsCheckedListBox.Items.Add(interest);
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
			var user = await _apiClient.PostUserAsync(requestData);
			var text = string.Format(Resources.UserCreationSuccessText, user?.Name);
			MessageBox.Show(text, Resources.UserCreationSuccessCaption);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}
}