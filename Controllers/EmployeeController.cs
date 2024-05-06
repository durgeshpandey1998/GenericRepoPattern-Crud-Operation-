using GenericRepoPattern.GenericRepository;
using GenericRepoPattern.Modal;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GenericRepoPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IRepository<Employee> repoEmployee;
        private IRepository<Departments> repoDepartment;
        public EmployeeController(IRepository<Employee> repoEmployee, IRepository<Departments> repoDepartment)
        {
            this.repoEmployee = repoEmployee;
            this.repoDepartment = repoDepartment;
        }

        [HttpGet("GetEmployees")]
        public IEnumerable<List<Employee>> GetEmployees()
        {
            yield return (List<Employee>)repoEmployee.GetAll();
        }

        [HttpGet(nameof(GetEmployeeById))]
        public Employee GetEmployeeById(int EmpID)
        {
            var result =  repoEmployee.GetById(EmpID);
            return result;
        }

        [HttpPost("AddEmployee")]
        public void AddEmployee([FromBody] Employee employee)
        {
            repoEmployee.Insert(employee);
        }
      
        [HttpDelete("DeleteEmployee")]
        public void DeleteEmployee(int id)
        {
            Employee employee = new Employee();
            employee.EmployeeID=id;
            repoEmployee.Delete(employee);
        }

        [HttpPost("AddDepartment")]
        public void AddDepartment([FromBody] Departments departments)
        {
            repoDepartment.Insert(departments);
        }

        [HttpGet("GetDepartment")]
        public IEnumerable<List<Departments>> GetDepartment()
        {
            yield return (List<Departments>)repoDepartment.GetAll();
        }
        [HttpGet(nameof(GetDepartmentById))]
        public Departments GetDepartmentById(int DepartmentID)
        {
            var result = repoDepartment.GetById(DepartmentID);
            return result;
        }
        [HttpDelete("DeleteDepartment")]
        public void DeleteDepartment(int id)
        {
            Departments departments  = new Departments();
            departments.DepartmentID = id;
            repoDepartment.Delete(departments);
        }
    }
}
