namespace Models;

public class Address
{
    public int Id { get; set; }
    public string? Country { get; set; }
    public string? City { get; set; }
    public int? PostalCode { get; set; }
    public string? Street { get; set; }
    public string? HouseNumber { get; set; } //string because housenumbers can contain letters e.g. 12a
}