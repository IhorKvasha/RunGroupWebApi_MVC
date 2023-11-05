using Microsoft.EntityFrameworkCore;
using RunGroupWebApi.Models;

namespace RunGroupWebApi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Race> Race { get; set; }
    public DbSet<Club> Clubs { get; set; }
    public DbSet<Address> Addresses { get; set; }
   // public DbSet<AppUser> Users { get; set; }
}