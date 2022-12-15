#pragma warning disable CS8618
using Microsoft.EntityFrameworkCore;
namespace LoginRegis.Models; // fill in PrjectName
public class MyContext : DbContext
{
    public MyContext(DbContextOptions options) : base(options) { }
    // create the following line for every model
    public DbSet<User> Users { get; set; } 
}