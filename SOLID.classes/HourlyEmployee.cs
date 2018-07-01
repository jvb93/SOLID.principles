using System;

namespace SOLID.classes
{
    public class HourlyEmployee : Employee
    {
        public decimal WeeklyHourAllotment { get; set; }
        public decimal HourlyRate { get; set; }

        public HourlyEmployee() : base(EmployeeType.Hourly)
        {

        }

        public HourlyEmployee(decimal weeklyHourAllotment, decimal hourlyRate) : base(EmployeeType.Hourly)
        {
            WeeklyHourAllotment = weeklyHourAllotment;
            HourlyRate = hourlyRate;
        }
     
        public override decimal GetMonthlyPaycheck()
        {
            return HourlyRate * WeeklyHourAllotment * 4;
           
        }
    }
}
