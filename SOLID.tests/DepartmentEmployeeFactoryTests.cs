using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID.classes;

namespace SOLID.tests
{
    [TestClass]
    public class DepartmentEmployeeFactoryTests
    {
        [TestMethod]
        public void CanCreateHourlyEmployee()
        {
            IEmployeeFactory basicEmployeeFactory = new DepartmentEmployeeFactory();
            var contract = new EmployeeBuilderContract()
            {
                HourlyRate = 10,
                WeeklyHourAllotment = 40,
                Type = EmployeeType.Hourly
            };
            var employee = basicEmployeeFactory.CreateEmployee(contract);
            Assert.IsTrue(employee.Type == EmployeeType.Hourly);
        }

        [TestMethod]
        public void CanCreateSalaryEmployee()
        {
            IEmployeeFactory basicEmployeeFactory = new DepartmentEmployeeFactory();
            var contract = new EmployeeBuilderContract()
            {
                YearlyRate = 120000,
                Type = EmployeeType.Salary
            };
            var employee = basicEmployeeFactory.CreateEmployee(contract);
            Assert.IsTrue(employee.Type == EmployeeType.Salary);
        }

        [TestMethod]
        public void CanCreateContractEmployee()
        {
            IEmployeeFactory basicEmployeeFactory = new DepartmentEmployeeFactory();
            var contract = new EmployeeBuilderContract()
            {
                HourlyRate = 10,
                WeeklyHourAllotment = 40,
                Type = EmployeeType.Contract
            };
            var employee = basicEmployeeFactory.CreateEmployee(contract);
            Assert.IsTrue(employee.Type == EmployeeType.Contract);
        }

        [TestMethod]
        public void EmployeesDoHaveDepartment()
        {
            IEmployeeFactory basicEmployeeFactory = new DepartmentEmployeeFactory();
            var contract = new EmployeeBuilderContract()
            {
                HourlyRate = 10,
                WeeklyHourAllotment = 40,
                Type = EmployeeType.Hourly
            };
            var employee = basicEmployeeFactory.CreateEmployee(contract);
            Assert.IsNotNull(employee.Department);
        }


    }
}
