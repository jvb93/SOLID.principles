using System;

namespace SOLID.classes
{
    public class BasicEmployeeFactory : IEmployeeFactory
    {
        public IEmployee CreateEmployee(EmployeeType type)
        {
            switch (type)
            {
                case EmployeeType.Contract:
                    return new ContractEmployee();
                case EmployeeType.Hourly:
                    return new HourlyEmployee();
                case EmployeeType.Salary:
                    return new SalaryEmployee();
                default:
                    throw new ArgumentException("Employee type invalid");
            }

        }
    }
}
