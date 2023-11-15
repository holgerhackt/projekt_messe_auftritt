namespace WebApplication1.Models
{
    public class Image
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
        public byte[]? Data { get; set; }
    }
}
