using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ApiServer.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Models.Authentication;

namespace ApiServer.Controllers;

[Route("api/[controller]")]
public class AccountController : Controller
{
	private readonly IConfiguration _configuration;
	private readonly UserManager<Account> _userManager;

	public AccountController(UserManager<Account> userManager, IConfiguration configuration)
	{
		_userManager = userManager;
		_configuration = configuration;
	}

	// POST: api/Account/Login
	[HttpPost]
	[Route("Login")]
	public async Task<IActionResult> Login([FromBody] LoginModel model)
	{
		var user = await _userManager.FindByNameAsync(model.Username);
		if (user == null) return Unauthorized();

		if (!await _userManager.CheckPasswordAsync(user, model.Password)) return Unauthorized();

		var userRoles = await _userManager.GetRolesAsync(user);

		var authClaims = new List<Claim>
		{
			new(ClaimTypes.Name, user.UserName),
			new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
		};

		foreach (var userRole in userRoles) authClaims.Add(new Claim(ClaimTypes.Role, userRole));

		var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

		var token = new JwtSecurityToken(
			_configuration["JWT:ValidIssuer"],
			_configuration["JWT:ValidAudience"],
			expires: DateTime.Now.AddHours(8),
			claims: authClaims,
			signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256));

		return Ok(new LoginResponse
		{
			Token = new JwtSecurityTokenHandler().WriteToken(token),
			Expiration = token.ValidTo,
			Username = user.UserName
		});
	}

	// POST: api/Account/Register
	[HttpPost]
	[Route("Register")]
	public async Task<IActionResult> Register([FromBody] RegisterModel model)
	{
		var userExists = await _userManager.FindByNameAsync(model.Username);
		if (userExists != null)
			return StatusCode(StatusCodes.Status500InternalServerError, "User already exists!");

		var user = new Account
		{
			SecurityStamp = Guid.NewGuid().ToString(),
			UserName = model.Username
		};
		var result = await _userManager.CreateAsync(user, model.Password);
		if (!result.Succeeded)
			return StatusCode(StatusCodes.Status500InternalServerError,
				"User creation failed! Please check user details and try again.");

		return Ok("User created successfully!");
	}
}