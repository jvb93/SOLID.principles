using System;

namespace SOLID.classes
{
    public class BasicEmployeeFactory : IEmployeeFactory
    {
        public IEmployee CreateEmployee(EmployeeBuilderContract contract)
        {
            switch (contract.Type)
            {
                case EmployeeType.Contract:
                    return new ContractEmployee(contract.WeeklyHourAllotment, contract.HourlyRate);
                case EmployeeType.Hourly:
                    return new HourlyEmployee(contract.WeeklyHourAllotment, contract.HourlyRate);
                case EmployeeType.Salary:
                    return new SalaryEmployee(contract.YearlyRate);
                default:
                    throw new ArgumentException("Employee type invalid");
            }

        }
    }
}
