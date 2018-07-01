using System;

namespace SOLID.classes
{
    public class DepartmentEmployeeFactory : IEmployeeFactory
    {
        public IEmployee CreateEmployee(EmployeeBuilderContract contract)
        {
            IEmployee toReturn;

            switch (contract.Type)
            {
                case EmployeeType.Contract:
                    toReturn = new ContractEmployee(contract.WeeklyHourAllotment, contract.HourlyRate);
                    toReturn.Department = "Department";
                    break;
                case EmployeeType.Hourly:
                    toReturn = new HourlyEmployee(contract.WeeklyHourAllotment, contract.HourlyRate);
                    toReturn.Department = "Department";
                    break;
                case EmployeeType.Salary:
                    toReturn = new SalaryEmployee(contract.YearlyRate);
                    toReturn.Department = "Department";
                    break;
                default:
                    throw new ArgumentException("Employee type invalid");

            }

            return toReturn;


        }
    }
}
