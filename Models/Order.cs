using System.ComponentModel.DataAnnotations;

namespace csharp_ecommerce_db.Models;

public class Order
{
    public int Id { get; set; }
    
    [Required]
    public DateTime? Date { get; set; }
    
    public int Amount { get; set; }
    
    [Required]
    public string? Status { get; set; }
    
    public int CustomerId { get; set; }
    public Customer? Customer { get; set; }
    
    public int EmployeeId { get; set; }
    public Employee? Employee { get; set; }
    
    public virtual ICollection<Payment> Payments { get; set; }
    
    public virtual ICollection<Product> Products { get; set; }

    public Order()
    {
        Payments = new List<Payment>();
        Products = new List<Product>();
    }
}