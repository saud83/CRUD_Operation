using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationForEmployee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private List<Employee> _employees;

        public EmployeeController()
        {
            // Initializing the list of employees 
            _employees = new List<Employee>
        {
            new Employee { employee_id = 502030, employee_code = "EMP319", employee_name = "Mehedi Hasan", employee_salary = 50000 },
            new Employee { employee_id = 502031, employee_code = "EMP321", employee_name = "Ashikur Rahman", employee_salary = 45000 },
            new Employee { employee_id = 502032, employee_code = "EMP322", employee_name = "Rakibul Islam", employee_salary = 52000 }
        };
        }

        // API01: Update an employee's Employee Code
        [HttpPut("{employeeId}/UpdateEmployeeCode")]
        public IActionResult UpdateEmployeeCode(int employeeId, [FromBody] string newEmployeeCode)
        {
            var employee = _employees.FirstOrDefault(e => e.employee_id == employeeId);
            if (employee == null)
            {
                return NotFound();
            }

            if (_employees.Any(e => e.employee_id != employeeId && e.employee_code == newEmployeeCode))
            {
                return Conflict("Another employee already has the same employee code.");
            }

            employee.employee_code = newEmployeeCode;
            return Ok();
        }

        // API02: Get all employees based on maximum to minimum salary
        [HttpGet("GetEmployeesBySalary")]
        public IEnumerable<Employee> GetEmployeesBySalary()
        {
            return _employees.OrderByDescending(e => e.employee_salary);
        }

        // API03: Find all employees who are absent at least one day
        [HttpGet("GetAbsentEmployees")]
        public IEnumerable<Employee> GetAbsentEmployees()
        {
            return _employees.Where(e => e.Attendances != null && e.Attendances.Any(a => a.isAbsent != 0));
        }

    }
 }