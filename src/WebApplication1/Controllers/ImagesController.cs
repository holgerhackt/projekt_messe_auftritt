using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.DTOs;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ImagesController : ControllerBase
{
    private readonly ImageContext _context;

    public ImagesController(ImageContext context)
    {
        _context = context;
    }

    // GET: api/Images
    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetImages()
    {
        return await _context.Users.Include(i => i.Address).ToListAsync();
    }

    // GET: api/Images/5
    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetImage(long id)
    {
        var image = await _context.Users.Include(i => i.Address).FirstAsync(i => i.Id == id);

        return image;
    }

    // PUT: api/Images/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutImage(long id, User user)
    {
        if (id != user.Id) return BadRequest();

        _context.Entry(user).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ImageExists(id))
                return NotFound();
            throw;
        }

        return NoContent();
    }

    // POST: api/Images
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<User>> PostImage(UserDto userDto)
    {
        var user = new User
        {
            Name = userDto.Name,
            Email = userDto.Email
        };
        
        if (userDto.Address != null)
        {
            var dtoAddress = userDto.Address;
            var address = new Address
            {
                Country = dtoAddress.Country,
                City = dtoAddress.City,
                PostalCode = dtoAddress.PostalCode,
                Street = dtoAddress.Street,
                HouseNumber = dtoAddress.HouseNumber
            };
            _context.Addresses.Add(address);
            await _context.SaveChangesAsync();
            user.Address = address;
        }
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        
        //TODO: Implement the many to many relation
        /*if (userDto.InterestIds != null && userDto.InterestIds.Any())
        {
            foreach (int interestId in userDto.InterestIds)
            {
                var userInterest = new UserInterest
                {
                    UserId = user.Id,
                    InterestId = interestId
                };
                _context.UserInterests.Add(userInterest);
            }
            await _context.SaveChangesAsync();
        }*/
        return CreatedAtAction(nameof(GetImage), new { id = user.Id }, user);
    }

    // DELETE: api/Images/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteImage(long id)
    {
        var image = await _context.Users.FindAsync(id);
        if (image == null) return NotFound();

        _context.Users.Remove(image);
        await _context.SaveChangesAsync();

        return NoContent();
        
    }

    private bool ImageExists(long id)
    {
        return (_context.Users?.Any(e => e.Id == id)).GetValueOrDefault();
    }

    [HttpPost("{userId:int}/interests")]
    public async Task<IActionResult> AddUserInterests(int userId, [FromBody] List<int> productGroupIds)
    {
        var user = await _context.Users.FindAsync(userId);
        if (user == null)
        {
            return NotFound();
        }

        foreach (var productGroupId in productGroupIds)
        {
            if (!_context.Interests.Any(pg => pg.Id == productGroupId))
            {
                return NotFound("Id of the product group couldn´t be found");
            }

            if (_context.UserInterests.Any(ui => ui.UserId == userId && ui.InterestId == productGroupId)) continue;
            var userInterest = new UserInterest
            {
                UserId = userId,
                InterestId = productGroupId
            };
            _context.UserInterests.Add(userInterest);
            await _context.SaveChangesAsync();
        }

        return NoContent(); //TODO: Implement a route for returning the userInterests
    }
    
}