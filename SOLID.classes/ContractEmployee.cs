using System;

namespace SOLID.classes
{
    public class ContractEmployee : Employee
    {
        public ContractEmployee() : base(EmployeeType.Contract)
        {

        }

        public ContractEmployee(decimal weeklyHourAllotment, decimal hourlyRate) : base(EmployeeType.Hourly)
        {
            WeeklyHourAllotment = weeklyHourAllotment;
            HourlyRate = hourlyRate;
        }
        

        public override decimal GetMonthlyPaycheck()
        {
            if (HourlyRate.HasValue && WeeklyHourAllotment.HasValue)
            {
                return HourlyRate.Value * WeeklyHourAllotment.Value * 4;
            }

            throw new ArgumentException("Hourly rate or Weekly allotment are missing");
        }
    }
}
