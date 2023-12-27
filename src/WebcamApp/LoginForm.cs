using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.Authentication;
using WebcamApp.OfflineDB;
using AutoMapper;
using Models.DTOs;

namespace WebcamApp;

internal partial class LoginForm : Form
{
    
    private ApiClient ApiClient { get; set; } = null!;
    
    private readonly OfflineContext _context;
    
    private readonly IMapper _mapper = AutoMapperConfiguration.Configure();
    
    
    public LoginForm()
    {
        _context = new OfflineContext();
        _context.Database.EnsureCreatedAsync();
        InitializeComponent();
        try
        {
            if (!_context.Interests.Any())
            {
                StartApp.Enabled = false;
            }
        }
        catch (Exception)
        {
            StartApp.Enabled = false;
        }
    }
    
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
        
        //Just for testing
        /*var users = await ApiClient.GetUsersAsync();
        MessageBox.Show(users.Count() + " user are currently in the database");*/
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
        var _interests = await ApiClient.GetInterestsAsync();
        await _context.Interests.AddRangeAsync(_interests);
        
        var _companies = await ApiClient.GetCompaniesAsync();
        await _context.Company.AddRangeAsync(_companies);
        
        await _context.SaveChangesAsync();
    }

    private async Task ClearLocalDatabase()
    {
        await _context.Database.EnsureDeletedAsync();
        await _context.Database.EnsureCreatedAsync();
    }

    private async Task SynchronizeDatabases()
    {
        //TODO: Add Exception handling e.g. if the request fails --> concept has to be made!
        if (_context.Users.Any())
        {
            List<User> users = await _context.Users
                .AsNoTracking()  // very important to avoid tracking errors especially with the interests
                .Include(u => u.Address)
                .Include(u => u.Company)
                    .ThenInclude(ca => ca!.Address)
                .Include(u => u.Interests)
                .ToListAsync();
            List<Task> tasks = new List<Task>();
            
            foreach (User user in users)
            {
                UserDto userDto = _mapper.Map<UserDto>(user);
                tasks.Add(ApiClient.PostUserAsync(userDto));
            }
            await Task.WhenAll(tasks);
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
}