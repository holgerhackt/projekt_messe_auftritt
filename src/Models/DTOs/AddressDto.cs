namespace Models.DTOs;

public class AddressDto
{
    public string? Country { get; set; }
    public string? City { get; set; }
    public int? PostalCode { get; set; }
    public string? Street { get; set; }
    public int? HouseNumber { get; set; }
}