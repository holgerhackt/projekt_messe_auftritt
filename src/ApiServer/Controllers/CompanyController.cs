using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.DTOs;

namespace ApiServer.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompanyController : ControllerBase
{
    private readonly ImageContext _context;
    private readonly IMapper _mapper;

    public CompanyController(ImageContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    // GET: api/Company
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Company>>> GetCompany()
    {
        return await _context.Company.Include(u => u.Address).ToListAsync();
    }


    // GET: api/Company/Dtos
    // Used for the local database
    [HttpGet("/api/CompanyDtos")]
    public async Task<ActionResult<List<CompanyDto>>> GetCompanyDtos()
    {
        var companies = await _context.Company.Include(u => u.Address).ToListAsync();
        var companyDtos = _mapper.Map<List<CompanyDto>>(companies);
        return companyDtos;
    }

    // GET: api/Company/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Company>> GetCompany(int id)
    {
        var company = await _context.Company.Where(c => c.Id == id)
            .Include(u => u.Address).FirstOrDefaultAsync();
        if (company == null) return NotFound();
        return company;
    }

    // PUT: api/Company/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutCompany(int id, Company company)
    {
        if (id != company.Id) return BadRequest();

        _context.Entry(company).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!CompanyExists(id))
                return NotFound();
            throw;
        }

        return NoContent();
    }

    // POST: api/Company
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Company>> PostCompany(Company company)
    {
        _context.Company.Add(company);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetCompany", new { id = company.Id }, company);
    }

    // DELETE: api/Company/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCompany(int id)
    {
        if (_context.Company == null) return NotFound();
        var company = await _context.Company.FindAsync(id);
        if (company == null) return NotFound();

        _context.Company.Remove(company);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool CompanyExists(int id)
    {
        return (_context.Company?.Any(e => e.Id == id)).GetValueOrDefault();
    }
}