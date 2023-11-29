namespace Models;

using System.Text.Json.Serialization;

public class Interest
{
    public int Id { get; set; }
    public string Name { get; set; }

    // Navigation Property
    [JsonIgnore]
    public List<User> Users { get; } = new();
}