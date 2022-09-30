using csharp_ecommerce_db.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_ecommerce_db.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly ECommerceContext _ctx;

    public OrderRepository(ECommerceContext ctx)
    {
        _ctx = ctx;
    }

    public IEnumerable<Order> GetOrders()
    {
        return _ctx.Orders.ToList();
    }

    public Order GetOrderById(int orderId)
    {
        Order? order = _ctx.Orders.Find(orderId);
        
        if (order is null)
        {
            throw new InvalidOperationException($"Order #{orderId} does not exists.");
        }
        
        return order;
    }

    public void CreateOrder(Order order, Customer customer, Employee employee)
    {
        order.Customer = customer;
        order.Employee = employee;
        
        _ctx.Orders.Add(order);
        _ctx.SaveChanges();
    }

    public void UpdateOrder(Order order)
    {
        _ctx.Orders.Update(order);
        _ctx.SaveChanges();
    }

    public void DeleteOrder(int orderId)
    {
        Order order = GetOrderById(orderId);
        _ctx.Orders.Remove(order);
        _ctx.SaveChanges();
    }
}