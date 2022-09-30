using System.ComponentModel.DataAnnotations;

namespace csharp_ecommerce_db.Models;

public class Payment
{
    public int Id { get; set; }
    
    [Required]
    public DateTime? Date { get; set; }
    
    public int Amount { get; set; }
    
    [Required]
    public string? Status { get; set; }
    
    public int OrderId { get; set; }
    public Order? Order { get; set; }
}