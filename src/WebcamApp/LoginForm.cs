using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.Authentication;
using Models.DTOs;
using WebcamApp.OfflineDB;

namespace WebcamApp;

internal partial class LoginForm : Form
{
    private readonly OfflineContext _context;

    private readonly IMapper _mapper = AutoMapperConfiguration.Configure();


    public LoginForm()
    {
        _context = new OfflineContext();
        _context.Database.EnsureCreatedAsync();
        InitializeComponent();
        try
        {
            if (!_context.Interests.Any()) StartApp.Enabled = false;
        }
        catch (Exception)
        {
            StartApp.Enabled = false;
        }
    }

    private ApiClient ApiClient { get; set; } = null!;

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
            MessageBox.Show("Login failed! The database has not been updated!");
            return;
        }

        var text = await response.Content.ReadAsStringAsync();
        var token = JsonSerializer.Deserialize<LoginResponse>(text, SerializerOptions.ApiServerOptions)!;
        httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token.Token}");

        ApiClient = new ApiClient(httpClient);

        try
        {
            await SynchronizeDatabases();
            await ClearLocalDatabase();
            await LoadDataToLocalDb();
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message);
            throw;
        }

        DialogResult = DialogResult.OK;
        Close();
    }

    private async Task LoadDataToLocalDb()
    {
        var interests = await ApiClient.GetInterestsAsync();
        await _context.Interests.AddRangeAsync(interests);

        var companyDtos = await ApiClient.GetCompanyDtosAsync();
        var companies = _mapper.Map<IEnumerable<Company>>(companyDtos);
        await _context.Company.AddRangeAsync(companies);
        await _context.SaveChangesAsync();
    }

    private async Task ClearLocalDatabase()
    {
        await _context.Database.EnsureDeletedAsync();
        await _context.Database.EnsureCreatedAsync();
        _context.ChangeTracker.Clear();
        //very very important, even after deleting the database, the context still tracks the entities
    }

    private async Task SynchronizeDatabases()
    {
        if (_context.Users.Any())
        {
            var users = await _context.Users
                .Include(u => u.Address)
                .Include(u => u.Company)
                .ThenInclude(ca => ca!.Address)
                .Include(u => u.Interests)
                .ToListAsync();

            foreach (var user in users)
            {
                var userDto = _mapper.Map<UserDto>(user);
                try
                {
                    var addedUser = await ApiClient.PostUserAsync(userDto);
                    //synchronize programming to avoid adding the same company multiple times and to ensure that if
                    //an exception occurs, the posted user will be deleted
                    _context.Users.Remove(user);
                    await _context.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error while synchronizing the database!\n" + e.Message);
                    throw;
                }
            }
        }
    }


    private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter) Login_Click(sender, e);
    }

    private void StartApp_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Close();
    }

    private void TextBox_TextChanged(object sender, EventArgs e)
    {
        Login.Enabled = !string.IsNullOrEmpty(UsernameTextBox.Text) && !string.IsNullOrEmpty(PasswordTextBox.Text);
    }

    private void EditUserData_Click(object sender, EventArgs e)
    {
        var editUserDataForm = new UserManager();
        Hide();
        editUserDataForm.ShowDialog();
        Show();
    }
}