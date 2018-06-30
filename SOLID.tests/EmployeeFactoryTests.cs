using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID.classes;

namespace SOLID.tests
{
    [TestClass]
    public class EmployeeFactoryTests
    {
        [TestMethod]
        public void CanCreateHourlyEmployee()
        {
            var hourlyEmployee = EmployeeFactory.CreateEmployee(EmployeeType.Hourly);
            Assert.IsTrue(hourlyEmployee.Type == EmployeeType.Hourly);
        }

        [TestMethod]
        public void CanCreateSalaryEmployee()
        {
            var salaryEmployee = EmployeeFactory.CreateEmployee(EmployeeType.Salary);
            Assert.IsTrue(salaryEmployee.Type == EmployeeType.Salary);
        }

        [TestMethod]
        public void CanCreateContractEmployee()
        {
            var contracrEmployee = EmployeeFactory.CreateEmployee(EmployeeType.Contract);
            Assert.IsTrue(contracrEmployee.Type == EmployeeType.Contract);
        }

      
    }
}
