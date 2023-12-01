using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

using Models;
using Models.Authentication;

namespace WebcamApp;

public partial class LoginForm : Form
{
	public LoginForm()
	{
		InitializeComponent();
	}

	public HttpClient HttpClient { get; private set; }

	private async void Login_Click(object sender, EventArgs e)
	{
		var httpClient = new HttpClient();
		httpClient.BaseAddress = new Uri("https://localhost:7242");

		var login = new LoginModel
		{
			Username = UsernameTextBox.Text,
			Password = PasswordTextBox.Text
		};
		var json = JsonSerializer.Serialize(login, SerializerOptions.ApiServerOptions);
		var content = new StringContent(json, Encoding.UTF8, "application/json");
		var response = await httpClient.PostAsync("/api/Account/login", content);
		if (response.StatusCode != HttpStatusCode.OK)
		{
			MessageBox.Show("Login failed");
			return;
		}

		var text = await response.Content.ReadAsStringAsync();
		var token = JsonSerializer.Deserialize<LoginResponse>(text, SerializerOptions.ApiServerOptions)!;
		httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token.Token}");

		HttpClient = httpClient;
		DialogResult = DialogResult.OK;
		Close();
	}

	private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Enter) Login_Click(sender, e);
	}
}