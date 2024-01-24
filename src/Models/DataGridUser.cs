namespace Models;

public class DataGridUser
{
    public int Id { get; set; }
    public string Forename { get; set; }
    public string Lastname { get; set; }
    public string? Email { get; set; }
    public byte[]? Image { get; set; }
    public int? AddressId { get; set; } = null!;
    public string? Country { get; set; }
    public string? City { get; set; }
    public int? PostalCode { get; set; }
    public string? Street { get; set; }
    public string? HouseNumber { get; set; }

    public int? CompanyId { get; set; } = null!;
    public string? CompanyName { get; set; } = null!;
    public int? CompanyAddressId { get; set; } = null!;
    public string? CompanyCountry { get; set; }
    public string? CompanyCity { get; set; }
    public int? CompanyPostalCode { get; set; }
    public string? CompanyStreet { get; set; }
    public string? CompanyHouseNumber { get; set; }
}