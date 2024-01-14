﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.DTOs;

namespace ApiServer.Controllers;

[Route("api/[controller]")]
[Authorize]
[ApiController]
public class UsersController : ControllerBase
{
	private readonly ImageContext _context;
	private readonly IMapper _mapper;
	public UsersController(ImageContext context, IMapper mapper)
	{
		_context = context;
		_mapper = mapper;
	}

	// GET: api/Users
	[HttpGet]
	public async Task<ActionResult<IEnumerable<User>>> GetUsers()
	{
		var users = await _context.Users
			.Include(u => u.Address)
            .Include(u => u.Company)
				.ThenInclude(ca => ca!.Address)
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
			.Include(u => u.Company)
				.ThenInclude(ca => ca!.Address)
			.Include(ui => ui.Interests)
			.FirstOrDefaultAsync();

		if (user == null) return NotFound();

		return Ok(user);
	}

	// POST: api/Users
	[HttpPost]
	public async Task<ActionResult> PostImage(UserDto userDto)
	{
		User databaseUser = _mapper.Map<User>(userDto);
		FindAndAddInterests(userDto.Interests, databaseUser);
		if (userDto.Company != null) FindAndAddCompany(userDto.Company.Id, databaseUser);
		var resUser = await _context.Users.AddAsync(databaseUser);
		await _context.SaveChangesAsync();

		return CreatedAtAction(nameof(GetUser), new { id = databaseUser.Id }, databaseUser);
	}

	private void FindAndAddInterests(List<int> interestIds, User databaseUser)
	{
		foreach (int interestId in interestIds)
		{
			Interest foundInterest = _context.Interests.FirstOrDefault(interest => interest.Id == interestId);

			if (foundInterest != null)
			{
				databaseUser.Interests.Add(foundInterest);
			}
		}
	}
	private void FindAndAddCompany(int companyId, User databaseUser)
	{
		Company foundCompany = _context.Company.FirstOrDefault(company => company.Id == companyId);

		if (foundCompany != null)
		{
			databaseUser.Company = foundCompany;
		}
		else
		{
			databaseUser.Company = null;
		}
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