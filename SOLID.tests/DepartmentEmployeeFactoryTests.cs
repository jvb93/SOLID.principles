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
            var employee = basicEmployeeFactory.CreateEmployee(EmployeeType.Hourly);
            Assert.IsTrue(employee.Type == EmployeeType.Hourly);
        }

        [TestMethod]
        public void CanCreateSalaryEmployee()
        {
            IEmployeeFactory basicEmployeeFactory = new DepartmentEmployeeFactory();
            var employee = basicEmployeeFactory.CreateEmployee(EmployeeType.Salary);
            Assert.IsTrue(employee.Type == EmployeeType.Salary);
        }

        [TestMethod]
        public void CanCreateContractEmployee()
        {
            IEmployeeFactory basicEmployeeFactory = new DepartmentEmployeeFactory();
            var employee = basicEmployeeFactory.CreateEmployee(EmployeeType.Contract);
            Assert.IsTrue(employee.Type == EmployeeType.Contract);
        }

        [TestMethod]
        public void EmployeesDoHaveDepartment()
        {
            IEmployeeFactory basicEmployeeFactory = new DepartmentEmployeeFactory();
            var employee = basicEmployeeFactory.CreateEmployee(EmployeeType.Contract);
            Assert.IsNotNull(employee.Department);
        }


    }
}
