using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models;

namespace WebcamApp.OfflineDB;

public class OfflineContext: DbContext
{

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Address> Addresses { get; set; } = null!;
    public DbSet<Interest>? Interests { get; set; } = null!;
    public DbSet<Company> Company { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite(@"Data Source=C:\Users\holge\source\repos\projekt_messe_auftritt\src\WebcamApp\OfflineDatabase.db");
        // TODO: Add relative path (I don´t know how why it doesn´t work)
    }
}