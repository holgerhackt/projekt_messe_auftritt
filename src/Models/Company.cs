namespace Models;

public class Company
{
	public int Id { get; set; }
	public string Name { get; set; } = null!;
	public Address Address { get; set; } = null!;
}
