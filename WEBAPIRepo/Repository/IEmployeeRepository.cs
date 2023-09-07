namespace EmployeeAPI.Repository
{
    public interface IEmployeeRepository<Employee>
    {
        Task<Employee> AddEmployee(Employee employee);
        Task<List<Employee>> DisplayEmployees();
    }
}
