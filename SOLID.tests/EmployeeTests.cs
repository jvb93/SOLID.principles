using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID.classes;

namespace SOLID.tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void DefaultFullNameWorks()
        {
            IEmployee hourlyEmployee = EmployeeFactory.CreateEmployee(EmployeeType.Hourly);
            hourlyEmployee.FirstName = "John";
            hourlyEmployee.LastName = "Smith";

            Assert.IsTrue(hourlyEmployee.GetFullName().Equals("John Smith", StringComparison.InvariantCultureIgnoreCase));
        }

        [TestMethod]
        public void CanOverrideFullName()
        {
            IEmployee salaryEmployee = EmployeeFactory.CreateEmployee(EmployeeType.Salary);
            salaryEmployee.FirstName = "John";
            salaryEmployee.LastName = "Smith";

            Assert.IsTrue(salaryEmployee.GetFullName().Equals("Smith, John", StringComparison.InvariantCultureIgnoreCase));
        }


    }
}
