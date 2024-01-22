using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        var databaseUser = _mapper.Map<User>(userDto);
        FindAndAddInterests(userDto.Interests, databaseUser);
        if (userDto.Company != null) FindAndAddCompany(userDto.Company, databaseUser);
        var resUser = await _context.Users.AddAsync(databaseUser);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetUser), new { id = databaseUser.Id }, databaseUser);
    }

    private void FindAndAddInterests(List<int> interestIds, User databaseUser)
    {
        foreach (var interestId in interestIds)
        {
            var foundInterest = _context.Interests.FirstOrDefault(interest => interest.Id == interestId);

            if (foundInterest != null) databaseUser.Interests.Add(foundInterest);
        }
    }

    private void FindAndAddCompany(CompanyDto companyToAdd, User databaseUser)
    {
        //Check if company already exists in db by name, because the name values are saved locally and if user
        //add new companies the ids will be different
        var foundCompany = _context.Company.FirstOrDefault(company => company.Id == companyToAdd.Id);

        if (foundCompany != null)
        {
            databaseUser.Company = foundCompany;
        }
        else
        {
            //Adding the company to db that was created on client side
            var newCompany = new Company
            {
                Name = companyToAdd.Name,
                Address = new Address
                {
                    Country = companyToAdd.Address.Country,
                    City = companyToAdd.Address.City,
                    PostalCode = companyToAdd.Address.PostalCode,
                    HouseNumber = companyToAdd.Address.HouseNumber,
                    Street = companyToAdd.Address.Street
                }
            };

            _context.Company.Add(newCompany);
            _context.SaveChanges();
            databaseUser.Company = newCompany;
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

        return NoContent();
    }

    //Development only
    // DELETE: api/Users/
    /*[HttpDelete]
    public async Task<IActionResult> DeleteAllUsers()
    {
        _context.Users.RemoveRange(_context.Users.ToList());
        await _context.SaveChangesAsync();
        return Ok();
    }*/
}