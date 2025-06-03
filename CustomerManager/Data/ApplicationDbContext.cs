using Microsoft.EntityFrameworkCore;
using CustomerManager.Models;

namespace CustomerManager.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }
}