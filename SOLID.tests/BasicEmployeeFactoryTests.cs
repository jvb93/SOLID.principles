using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID.classes;

namespace SOLID.tests
{
    [TestClass]
    public class BasicEmployeeFactoryTests
    {
        [TestMethod]
        public void CanCreateHourlyEmployee()
        {
            IEmployeeFactory basicEmployeeFactory = new BasicEmployeeFactory();
            var employee = basicEmployeeFactory.CreateEmployee(EmployeeType.Hourly);
            Assert.IsTrue(employee.Type == EmployeeType.Hourly);
        }

        [TestMethod]
        public void CanCreateSalaryEmployee()
        {
            IEmployeeFactory basicEmployeeFactory = new BasicEmployeeFactory();
            var employee = basicEmployeeFactory.CreateEmployee(EmployeeType.Salary);
            Assert.IsTrue(employee.Type == EmployeeType.Salary);
        }

        [TestMethod]
        public void CanCreateContractEmployee()
        {
            IEmployeeFactory basicEmployeeFactory = new BasicEmployeeFactory();
            var employee = basicEmployeeFactory.CreateEmployee(EmployeeType.Contract);
            Assert.IsTrue(employee.Type == EmployeeType.Contract);
        }

        [TestMethod]
        public void EmployeesDoNotHaveDepartment()
        {
            IEmployeeFactory basicEmployeeFactory = new BasicEmployeeFactory();
            var employee = basicEmployeeFactory.CreateEmployee(EmployeeType.Contract);
            Assert.IsNull(employee.Department);
        }


    }
}
