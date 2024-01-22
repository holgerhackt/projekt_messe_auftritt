using Microsoft.EntityFrameworkCore;
using Models;

namespace WebcamApp.OfflineDB;

public class OfflineContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Address> Addresses { get; set; } = null!;
    public DbSet<Interest> Interests { get; set; } = null!;
    public DbSet<Company> Company { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source=OfflineDatabase.db");
    }
}