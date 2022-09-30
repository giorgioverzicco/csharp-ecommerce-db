using csharp_ecommerce_db.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_ecommerce_db.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly ECommerceContext _ctx;

    public CustomerRepository(ECommerceContext ctx)
    {
        _ctx = ctx;
    }

    public IEnumerable<Customer> GetCustomers()
    {
        return _ctx.Customers.ToList();
    }

    public Customer GetCustomerById(int customerId)
    {
        Customer? customer = _ctx.Customers.Find(customerId);
        
        if (customer is null)
        {
            throw new InvalidOperationException($"Customer #{customerId} does not exists.");
        }
        
        return customer;
    }

    public void CreateCustomer(Customer customer)
    {
        _ctx.Customers.Add(customer);
        _ctx.SaveChanges();
    }

    public void UpdateCustomer(Customer customer)
    {
        _ctx.Customers.Update(customer);
        _ctx.SaveChanges();
    }

    public void DeleteCustomer(int customerId)
    {
        Customer customer = GetCustomerById(customerId);
        _ctx.Customers.Remove(customer);
        _ctx.SaveChanges();
    }
}