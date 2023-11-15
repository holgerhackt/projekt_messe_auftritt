namespace WebApplication1.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
        public byte[]? Data { get; set; }
        public int AddressId { get; set; }
        public Address? Address { get; set; }
    }
}
