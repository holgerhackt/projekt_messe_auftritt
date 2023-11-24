using AutoMapper;
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
    private readonly IMapper _mapper;

    public ImagesController(ImageContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
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
        
        var userDtos = _mapper.Map<List<User>, List<ReturnUserDto>>(users);
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

        var userDto = _mapper.Map<User, ReturnUserDto>(user);
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

        // _context.Entry(user).State = EntityState.Modified;

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
        var user = _mapper.Map<User>(createUserDto);

        if (createUserDto.InterestIds != null)
        {
            var validInterests = await _context.Interests
                .Where(i => createUserDto.InterestIds.Contains(i.Id))
                .ToListAsync();
            
            foreach (var userInterest in validInterests.Select(interest => new UserInterest { InterestId = interest.Id })) // Because the navigation property is very smart, we don´t need to set the User property of the UserInterest object, because it is set automatically.
            {
                user.UserInterests.Add(userInterest);
            }
        }

        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        
        var responseDto = _mapper.Map<ReturnUserDto>(user);
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