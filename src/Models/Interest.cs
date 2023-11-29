namespace Models;

public class Interest
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    // Navigation Property
    public List<User> Users { get; } = new();
}