using ApiServer.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ApiServer;

public class ImageContext : IdentityDbContext<Account>
{
	protected readonly IConfiguration Configuration;

	public ImageContext(IConfiguration configuration)
	{
		Configuration = configuration;
	}

	public DbSet<User> Users { get; set; } = null!;
	public DbSet<Address> Addresses { get; set; } = null!;
	public DbSet<Interest> Interests { get; set; } = null!;
    public DbSet<Company> Company { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder options)
	{
		options.UseSqlite(Configuration.GetConnectionString("TestDatabase"));
	}

	
}