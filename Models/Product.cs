using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_ecommerce_db.Models;

public class Product
{
    public int Id { get; set; }
    
    [Required]
    public string? Name { get; set; }
    
    public string? Description { get; set; }
    
    [Column(TypeName = "money")]
    public decimal Money { get; set; }
    
    public virtual ICollection<Order> Orders { get; set; }

    public Product()
    {
        Orders = new List<Order>();
    }
}