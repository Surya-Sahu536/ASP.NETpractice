using EmployeeAPI.Models;
using EmployeeAPI.Repository;
using Microsoft.AspNetCore.Mvc;


// Controller >> DB
// Controller >> repo >> DB
// Controller >> Interface >> repo >> DB

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository<Employee> _repo;

        public EmployeeController(IEmployeeRepository<Employee> repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> AddEmployee(Employee employee)
        {
            await _repo.AddEmployee(employee);
            return Ok(employee);
        }

        [HttpGet]
        public async Task<List<Employee>> DisplayEmployees()
        {
            var emps = await _repo.DisplayEmployees();
            return emps;
        }


    }
}
