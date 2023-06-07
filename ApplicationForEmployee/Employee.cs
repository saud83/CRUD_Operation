using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationForEmployee
{
    public class Employee
    {
        public int employee_id { get; set; }
        public string employee_name { get; set; }
        public string employee_code { get; set; }
        public decimal employee_salary { get; set; }

        public List<EmployeeAttendance> Attendances { get; set; }
    }
}
