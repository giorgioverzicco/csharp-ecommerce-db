using csharp_ecommerce_db.Models;

namespace csharp_ecommerce_db.Repositories;

public interface IOrderRepository
{
    IEnumerable<Order> GetOrders();
    Order GetOrderById(int orderId);
    void CreateOrder(Order order, Customer customer, Employee employee);
    void UpdateOrder(Order order);
    void DeleteOrder(int orderId);
}