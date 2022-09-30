using System.ComponentModel.DataAnnotations;

namespace csharp_ecommerce_db.Models;

public class Employee
{
    public int Id { get; set; }
    
    [Required]
    public string? Name { get; set; }
    
    [Required]
    public string? Surname { get; set; }
    
    [Required]
    public string? Level { get; set; }
    
    public virtual ICollection<Order> Orders { get; set; }

    public Employee()
    {
        Orders = new List<Order>();
    }
}