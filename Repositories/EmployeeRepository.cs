using csharp_ecommerce_db.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_ecommerce_db.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly ECommerceContext _ctx;

    public EmployeeRepository(ECommerceContext ctx)
    {
        _ctx = ctx;
    }

    public IEnumerable<Employee> GetEmployees()
    {
        return _ctx.Employees.ToList();
    }

    public Employee GetEmployeeById(int employeeId)
    {
        Employee? employee = _ctx.Employees.Find(employeeId);
        
        if (employee is null)
        {
            throw new InvalidOperationException($"Employee #{employeeId} does not exists.");
        }
        
        return employee;
    }

    public void CreateEmployee(Employee employee)
    {
        _ctx.Employees.Add(employee);
        _ctx.SaveChanges();
    }

    public void UpdateEmployee(Employee employee)
    {
        _ctx.Employees.Update(employee);
        _ctx.SaveChanges();
    }

    public void DeleteEmployee(int employeeId)
    {
        Employee employee = GetEmployeeById(employeeId);
        _ctx.Employees.Remove(employee);
        _ctx.SaveChanges();
    }
}