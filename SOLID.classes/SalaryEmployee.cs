using System.Runtime.InteropServices.WindowsRuntime;

namespace SOLID.classes
{
    public class SalaryEmployee : Employee
    {
        public SalaryEmployee() : base(EmployeeType.Salary)
        {

        }

        public SalaryEmployee(decimal yearlyRate) : base(EmployeeType.Salary)
        {
            YearlyRate = yearlyRate;
        }


        public override string GetFullName()
        {
            return $"{LastName}, {FirstName}";
        }

        public override decimal GetMonthlyPaycheck()
        {
            if (YearlyRate.HasValue)
            {
                return YearlyRate.Value / 12;
            }

            return 0;
        }
    }
}
