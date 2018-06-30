using System;

namespace SOLID.classes
{
    public class DepartmentEmployeeFactory : IEmployeeFactory
    {
        public IEmployee CreateEmployee(EmployeeType type)
        {
            IEmployee toReturn;

            switch (type)
            {
                case EmployeeType.Contract:
                    toReturn = new ContractEmployee();
                    toReturn.Department = "Department";
                    break;
                case EmployeeType.Hourly:
                    toReturn = new HourlyEmployee();
                    toReturn.Department = "Department";
                    break;
                case EmployeeType.Salary:
                    toReturn = new SalaryEmployee();
                    toReturn.Department = "Department";
                    break;
                default:
                    throw new ArgumentException("Employee type invalid");

            }

            return toReturn;


        }
    }
}
