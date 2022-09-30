using csharp_ecommerce_db.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_ecommerce_db.Repositories;

public class PaymentRepository : IPaymentRepository
{
    private readonly ECommerceContext _ctx;

    public PaymentRepository(ECommerceContext ctx)
    {
        _ctx = ctx;
    }

    public IEnumerable<Payment> GetPayments()
    {
        return _ctx.Payments.ToList();
    }

    public Payment GetPaymentById(int paymentId)
    {
        Payment? payment = _ctx.Payments.Find(paymentId);
        
        if (payment is null)
        {
            throw new InvalidOperationException($"Payment #{paymentId} does not exists.");
        }
        
        return payment;
    }

    public void CreatePayment(Payment payment, Order order)
    {
        payment.Order = order;
        
        _ctx.Payments.Add(payment);
        _ctx.SaveChanges();
    }

    public void UpdatePayment(Payment payment)
    {
        _ctx.Payments.Update(payment);
        _ctx.SaveChanges();
    }

    public void DeletePayment(int paymentId)
    {
        Payment payment = GetPaymentById(paymentId);
        _ctx.Payments.Remove(payment);
        _ctx.SaveChanges();
    }
}