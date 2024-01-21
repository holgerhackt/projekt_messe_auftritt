using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;
using Models.DTOs;

namespace WebcamApp;

internal class ApiClient
{
	private readonly HttpClient _httpClient;

	public ApiClient(HttpClient httpClient)
	{
		_httpClient = httpClient;
	}

	public async Task<IEnumerable<User>?> GetUsersAsync() => await GetListAsync<User>("/api/Users");

	public async Task<User> PostUserAsync(UserDto user) => await PostAsync<UserDto, User>("/api/Users", user);

	public async Task<IEnumerable<Interest>?> GetInterestsAsync() => await GetListAsync<Interest>("/api/Interests");

	//public async Task<Interest?> PostInterestAsync(Interest interest) => await PostAsync("/api/Interests", interest);

	public async Task<IEnumerable<CompanyDto>?> GetCompanyDtosAsync() => await GetListAsync<CompanyDto>("/api/CompanyDtos");

	public async Task<Company?> PostCompanyAsync(Company company) => await PostAsync<Company, Company>("/api/Company", company);

	private async Task<IEnumerable<T>?> GetListAsync<T>(string url) =>
		await JsonSerializer.DeserializeAsync<IEnumerable<T>>(
												await _httpClient.GetStreamAsync(url), SerializerOptions.ApiServerOptions)!;

	private async Task<TResult> PostAsync<TInput ,TResult>(string url, TInput data) 
		where TInput : class 
		where TResult : class
	{
		var json = JsonSerializer.Serialize(data, SerializerOptions.ApiServerOptions);
		
		var content = new StringContent(json, Encoding.UTF8, "application/json");
		var response = await _httpClient.PostAsync(url, content);
		if (!response.IsSuccessStatusCode) throw new Exception($"Request failed with {response.StatusCode}");
		var text = await response.Content.ReadAsStringAsync();
		return JsonSerializer.Deserialize<TResult>(text, SerializerOptions.ApiServerOptions);
	}
}