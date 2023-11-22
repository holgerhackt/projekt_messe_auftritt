using WebApplication1.Models;
namespace WebApplication1.DTOs;

public class ReturnUserDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    //public byte[]? Data { get; set; }
    public int AddressId { get; set; }
    public Address? Address { get; set; }
    
    // Navigation Property
    public List<InterestDto> Interests { get; set; } = new();
}