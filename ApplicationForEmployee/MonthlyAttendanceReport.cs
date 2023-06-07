using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationForEmployee
{
    public class MonthlyAttendanceReport
    {
        public string employee_name { get; set; }
        public string month_name { get; set; }
        public int total_present { get; set; }
        public int total_absent { get; set; }
    }
}
