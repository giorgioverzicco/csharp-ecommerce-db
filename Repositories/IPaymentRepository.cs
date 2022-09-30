using csharp_ecommerce_db.Models;

namespace csharp_ecommerce_db.Repositories;

public interface IPaymentRepository
{
    IEnumerable<Payment> GetPayments();
    Payment GetPaymentById(int paymentId);
    void CreatePayment(Payment payment, Order order);
    void UpdatePayment(Payment payment);
    void DeletePayment(int paymentId);
}