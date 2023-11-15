
using Microsoft.EntityFrameworkCore;
namespace WebApplication1.Models
{
    public class ImageContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public ImageContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(Configuration.GetConnectionString("TestDatabase"));


        public DbSet<Image> Images { get; set; } = null!;
    }
}
