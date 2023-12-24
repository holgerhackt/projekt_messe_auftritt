using Models;

namespace Models.DTOs;

public class UserDto
{
    // Only necessary, because of the different Ids in the databases
    public string? Name { get; set; }
    public string? Email { get; set; }
    public byte[]? Image { get; set; }
    public int? AddressId { get; set; } 
    public AddressDto? Address { get; set; }  

    public int? CompanyId { get; set; }
    public Company? Company { get; set; }

    // Navigation Property
    public List<int> Interests { get; set; } = new();
}