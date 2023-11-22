namespace WebApplication1.DTOs;

public class CreateUserDto
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    //public byte[]? Data { get; set; }
    public AddressDto? Address { get; set; }
    
    // Navigation Property
    public List<int>? InterestIds { get; } = new List<int>();
}