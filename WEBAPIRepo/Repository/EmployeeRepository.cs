using EmployeeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI.Repository
{
    public class EmployeeRepository : IEmployeeRepository<Employee>
    {
        private readonly EmpContext _context;

        public EmployeeRepository(EmpContext context)
        {
            _context = context;
        }


        public async Task<Employee> AddEmployee(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
            return employee;
        }


        public async Task<List<Employee>> DisplayEmployees()
        {
            var emps = await _context.Employees.ToListAsync();
            return emps;
        }

    }
}
