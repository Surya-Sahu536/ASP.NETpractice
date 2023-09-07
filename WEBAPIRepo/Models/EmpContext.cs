using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI.Models
{
    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions<EmpContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}
