﻿namespace ApiServer;

using Microsoft.EntityFrameworkCore;
using Models;

public class ImageContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public ImageContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Address> Addresses { get; set; } = null!;
    public DbSet<Interest> Interests { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite(Configuration.GetConnectionString("TestDatabase"));
    }
}