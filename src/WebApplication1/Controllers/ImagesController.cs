namespace ApiServer.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using ApiServer;

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
		var users = await _context.Users
			.Include(u => u.Address)
			.Include(u => u.Interests)
			.ToListAsync();

		return users;
	}

	// GET: api/Images/5
	[HttpGet("{id}")]
	public async Task<ActionResult<User>> GetUser(int id)
	{
		var user = await _context.Users
			.Where(u => u.Id == id)
			.Include(u => u.Address)
			.Include(ui => ui.Interests)
			.FirstOrDefaultAsync();

		return user;
	}


	// PUT: api/Images/5
	// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
	[HttpPut("{id}")]
	public async Task<IActionResult> PutImage(int id, User createUserDto)
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
	public async Task<ActionResult> PostImage(User user)
	{
		var resUser = await _context.Users.AddAsync(user);
		await _context.SaveChangesAsync();

		return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
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

	//[HttpPost("{userId:int}/interests")]
	//public async Task<IActionResult> AddUserInterests(int userId, [FromBody] List<int> productGroupIds)
	//{
	//	var user = await _context.Users.FindAsync(userId);
	//	if (user == null)
	//	{
	//		return NotFound();
	//	}

	//	foreach (var productGroupId in productGroupIds)
	//	{
	//		if (!_context.Interests.Any(pg => pg.Id == productGroupId))
	//		{
	//			return NotFound("Id of the product group couldn´t be found");
	//		}

	//		if (_context.UserInterests.Any(ui => ui.UserId == userId && ui.InterestId == productGroupId)) continue;
	//		var userInterest = new UserInterest
	//		{
	//			UserId = userId,
	//			InterestId = productGroupId
	//		};
	//		_context.UserInterests.Add(userInterest);
	//		await _context.SaveChangesAsync();
	//	}

	//	return NoContent(); //TODO: Implement a route for returning the userInterests
	//}

}