namespace Models;

public class User
{
	public int Id { get; set; }
	public string? Name { get; set; }
	public string? Email { get; set; }
	//public byte[]? Data { get; set; }
	public int AddressId { get; set; }
	public Address? Address { get; set; }

	// Navigation Property
	public List<Interest> Interests { get; set; } = new();
}