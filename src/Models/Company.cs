namespace Models;

public class Company
{
	public int Id { get; set; }
	public string Name { get; set; } = null!;
	public int? AddressId { get; set; }
	public Address? Address { get; set; } = null!;
}
