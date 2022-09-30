using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace csharp_ecommerce_db.Models;

[Index(nameof(Email), IsUnique = true)]
public class Customer
{
    public int Id { get; set; }
    
    [Required]
    public string? Name { get; set; }
    
    [Required]
    public string? Surname { get; set; }
    
    [Required]
    public string? Email { get; set; }
    
    public virtual ICollection<Order> Orders { get; set; }

    public Customer()
    {
        Orders = new List<Order>();
    }
}