using System;

namespace SOLID.classes
{
    public class ContractEmployee : Employee
    {
        public decimal WeeklyHourAllotment { get; set; }
        public decimal HourlyRate { get; set; }
        public ContractEmployee() : base(EmployeeType.Contract)
        {

        }

        public ContractEmployee(decimal weeklyHourAllotment, decimal hourlyRate) : base(EmployeeType.Contract)
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
