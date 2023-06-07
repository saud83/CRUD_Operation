using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationForEmployee
{
    public class EmployeeAttendance
    {
        public DateTime attendance_date { get; set; }
        public int isAbsent { get; set; }
        public int isPresent { get; set; }
        public int isOffDay { get; set; }
        public int employee_id { get; set; }
    }
}
