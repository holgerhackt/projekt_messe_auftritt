using System.Text.Json.Serialization;

namespace Models;

public class Interest
{
	public int Id { get; set; }
	public string Name { get; set; }

	// Navigation Property
	[JsonIgnore] public List<User> Users { get; } = new();
}