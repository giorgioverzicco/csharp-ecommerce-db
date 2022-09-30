using csharp_ecommerce_db.Models;

namespace csharp_ecommerce_db.Repositories;

public interface ICustomerRepository
{
    IEnumerable<Customer> GetCustomers();
    Customer GetCustomerById(int customerId);
    void CreateCustomer(Customer customer);
    void UpdateCustomer(Customer customer);
    void DeleteCustomer(int customerId);
}