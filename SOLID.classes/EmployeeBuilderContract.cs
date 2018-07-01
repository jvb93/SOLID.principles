using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.classes
{
    public class EmployeeBuilderContract
    {
        public EmployeeType Type { get; set; }
        public decimal WeeklyHourAllotment { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal YearlyRate { get; set; }

    }
}
