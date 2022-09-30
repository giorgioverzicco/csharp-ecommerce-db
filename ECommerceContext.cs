using csharp_ecommerce_db.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_ecommerce_db;

public class ECommerceContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Product> Products { get; set; }

    public ECommerceContext() : base()
    {
    }

    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
    {
        string connection =
            "Data Source=.;" +
            "Initial Catalog=ECommerce;" +
            "Integrated Security=True;";
        optionsBuilder.UseSqlServer(connection);
    }
}