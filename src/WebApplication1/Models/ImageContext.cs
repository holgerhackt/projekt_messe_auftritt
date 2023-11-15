using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public class ImageContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public ImageContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserInterest>()
            .HasKey(ki => new { ki.UserId, ProductId = ki.InterestId });

        modelBuilder.Entity<UserInterest>()
            .HasOne(ki => ki.User)
            .WithMany(k => k.UserInterests)
            .HasForeignKey(ki => ki.UserId);

        modelBuilder.Entity<UserInterest>()
            .HasOne(ki => ki.Interest)
            .WithMany(p => p.UserInterests)
            .HasForeignKey(ki => ki.InterestId);
    }



    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Address> Addresses { get; set; } = null!;
    public DbSet<Interest> Interests { get; set; } = null!;
    public DbSet<UserInterest> UserInterests { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite(Configuration.GetConnectionString("TestDatabase"));
    }
}