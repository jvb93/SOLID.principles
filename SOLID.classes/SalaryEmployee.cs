using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace SOLID.classes
{
    public class SalaryEmployee : Employee
    {
        public decimal YearlyRate { get; set; }
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
            return YearlyRate / 12;
        }
    }
}
