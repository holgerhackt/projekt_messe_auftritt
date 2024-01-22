namespace Models;

public class User
{
    public int Id { get; set; }
    public string Forename { get; set; }
    public string Lastname { get; set; }
    public string? Email { get; set; }
    public byte[]? Image { get; set; }
    public int? AddressId { get; set; }
    public Address? Address { get; set; }

    public int? CompanyId { get; set; }
    public Company? Company { get; set; }

    // Navigation Property
    public List<Interest> Interests { get; set; } = new();
}