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
    public async Task<ActionResult<IEnumerable<ReturnUserDto>>> GetImages()
    {
        var users = await _context.Users
            .Include(u => u.Address)
            .Include(u => u.UserInterests)
                .ThenInclude(ui => ui.Interest)
            .ToListAsync();

        var userDtos = users.Select(user => new ReturnUserDto()
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email,
            Address = user.Address != null ? new Address
            {
                Id = user.Address.Id,
                Country = user.Address.Country,
                Street = user.Address.Street,
                City = user.Address.City,
                PostalCode = user.Address.PostalCode,
                HouseNumber = user.Address.HouseNumber
            } : null,
            Interests = user.UserInterests.Select(ui => new InterestDto 
            {
                Id = ui.Interest.Id,
                Name = ui.Interest.Name
            }).ToList()
        }).ToList();

        return userDtos;

    }

    // GET: api/Images/5
    [HttpGet("{id}")]
    public async Task<ActionResult<ReturnUserDto>> GetUser(int id)
    {
        var user = await _context.Users
            .Where(u => u.Id == id)
            .Include(u => u.Address)
            .Include(u => u.UserInterests)
            .ThenInclude(ui => ui.Interest)
            .FirstOrDefaultAsync();

        if (user == null)
        {
            return NotFound();
        }

        var userDto = new ReturnUserDto()
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email,
            Address = user.Address != null ? new Address
            {
                Id = user.Address.Id,
                Country = user.Address.Country,
                Street = user.Address.Street,
                City = user.Address.City,
                PostalCode = user.Address.PostalCode,
                HouseNumber = user.Address.HouseNumber
            } : null,
            Interests = user.UserInterests.Select(ui => new InterestDto 
            {
                Id = ui.Interest.Id,
                Name = ui.Interest.Name
            }).ToList()
        };
        return userDto;
    }


    // PUT: api/Images/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutImage(int id, CreateUserDto createUserDto)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null)
        {
            return BadRequest("User does not exist");
        }

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
    public async Task<ActionResult<CreateUserDto>> PostImage(CreateUserDto createUserDto)
    {
        var user = new User
        {
            Name = createUserDto.Name,
            Email = createUserDto.Email,
            //UserInterests = new List<UserInterest>() // add empty list
        };
    
        if (createUserDto.Address != null)
        {
            var dtoAddress = createUserDto.Address;
            var address = new Address
            {
                Country = dtoAddress.Country,
                City = dtoAddress.City,
                PostalCode = dtoAddress.PostalCode,
                Street = dtoAddress.Street,
                HouseNumber = dtoAddress.HouseNumber
            };
            user.Address = address; 
        }

        _context.Users.Add(user); //Hier wird Id generiert

        if (createUserDto.InterestIds != null && createUserDto.InterestIds.Any())
        {
            var validInterests = _context.Interests
                .Where(i => createUserDto.InterestIds.Contains(i.Id))
                .ToList();
    
            foreach (var interest in validInterests)
            {
                // Erstellen Sie ein neues UserInterest-Objekt für jeden gültigen Interest
                var userInterest = new UserInterest { UserId = user.Id, InterestId = interest.Id };
                user.UserInterests.Add(userInterest); // Fügen Sie es der UserInterests-Liste hinzu
            }
        }

        _context.Users.Add(user);
        await _context.SaveChangesAsync(); // Speichern Sie alle Änderungen auf einmal


        await _context.SaveChangesAsync(); // Einmaliges Speichern

        // Erstellen eines Response-DTOs, um sensible Informationen auszublenden
        var responseDto = new CreateUserDto
        {
            // Setzen Sie hier die erforderlichen Eigenschaften
        };

        return CreatedAtAction(nameof(GetUser), new { id = user.Id }, responseDto);
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