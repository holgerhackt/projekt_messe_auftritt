﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ApiServer.Controllers;

[Route("api/[controller]")]
[Authorize]
[ApiController]
public class UsersController : ControllerBase
{
	private readonly ImageContext _context;

	public UsersController(ImageContext context)
	{
		_context = context;
	}

	// GET: api/Users
	[HttpGet]
	public async Task<ActionResult<IEnumerable<User>>> GetUsers()
	{
		var users = await _context.Users
			.Include(u => u.Address)
			.Include(u => u.Interests)
			.ToListAsync();

		return users;
	}

	// GET: api/Users/5
	[HttpGet("{id}")]
	public async Task<ActionResult<User>> GetUser(int id)
	{
		var user = await _context.Users
			.Where(u => u.Id == id)
			.Include(u => u.Address)
			.Include(ui => ui.Interests)
			.FirstOrDefaultAsync();

		if (user == null) return NotFound();

		return Ok(user);
	}

	// POST: api/Users
	[HttpPost]
	public async Task<ActionResult> PostImage(User user)
	{
		var resUser = await _context.Users.AddAsync(user);
		await _context.SaveChangesAsync();

		return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
	}

	// DELETE: api/Users/5
	[HttpDelete("{id}")]
	public async Task<IActionResult> DeleteImage(int id)
	{
		var image = await _context.Users.FindAsync(id);

		if (image == null) return NotFound();

		_context.Users.Remove(image);
		await _context.SaveChangesAsync();

		return Ok();
	}
}