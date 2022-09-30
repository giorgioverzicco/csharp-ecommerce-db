using csharp_ecommerce_db.Models;

namespace csharp_ecommerce_db.Repositories;

public interface IEmployeeRepository
{
    IEnumerable<Employee> GetEmployees();
    Employee GetEmployeeById(int employeeId);
    void CreateEmployee(Employee employee);
    void UpdateEmployee(Employee employee);
    void DeleteEmployee(int employeeId);
}