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
            IEmployee employee = EmployeeFactory.CreateEmployee(EmployeeType.Hourly);
            employee.FirstName = "John";
            employee.LastName = "Smith";

            Assert.IsTrue(employee.GetFullName().Equals("John Smith", StringComparison.InvariantCultureIgnoreCase));
        }

        [TestMethod]
        public void CanOverrideFullName()
        {
            IEmployee employee = EmployeeFactory.CreateEmployee(EmployeeType.Salary);
            employee.FirstName = "John";
            employee.LastName = "Smith";

            Assert.IsTrue(employee.GetFullName().Equals("Smith, John", StringComparison.InvariantCultureIgnoreCase));
        }

        [TestMethod]
        public void CanGetHourlyMonthlyPaycheck()
        {
            IEmployee employee = EmployeeFactory.CreateEmployee(EmployeeType.Hourly);
            employee.HourlyRate = 10;
            employee.WeeklyHourAllotment = 40;

            Assert.IsTrue(employee.GetMonthlyPaycheck() == 10 * 40 * 4);

            IEmployee employeeFailure = EmployeeFactory.CreateEmployee(EmployeeType.Hourly);
            Assert.ThrowsException<ArgumentException>(() => employeeFailure.GetMonthlyPaycheck());
        }

        [TestMethod]
        public void CanGetContractMonthlyPaycheck()
        {
            IEmployee employee = EmployeeFactory.CreateEmployee(EmployeeType.Contract);
            employee.HourlyRate = 10;
            employee.WeeklyHourAllotment = 40;

            Assert.IsTrue(employee.GetMonthlyPaycheck() == 10 * 40 * 4);

            IEmployee employeeFailure = EmployeeFactory.CreateEmployee(EmployeeType.Contract);
            Assert.ThrowsException<ArgumentException>(() => employeeFailure.GetMonthlyPaycheck());

        }

        [TestMethod]
        public void CanGetSalaryMonthlyPaycheck()
        {
            IEmployee employee = EmployeeFactory.CreateEmployee(EmployeeType.Salary);
            employee.YearlyRate = 120000;

            Assert.IsTrue(employee.GetMonthlyPaycheck() == 120000m / 12);

            IEmployee employeeFailure = EmployeeFactory.CreateEmployee(EmployeeType.Salary);
            Assert.ThrowsException<ArgumentException>(() => employeeFailure.GetMonthlyPaycheck());
        }

        [TestMethod]
        public void CanMakeContractEmployee()
        {
            IEmployee employee = new ContractEmployee(40, 10);
            Assert.IsTrue(employee.HourlyRate.Value == 10m);
            Assert.IsTrue(employee.WeeklyHourAllotment.Value == 40m);
        }

        [TestMethod]
        public void CanMakeHourlyEmployee()
        {
            IEmployee employee = new HourlyEmployee(40, 10);
            Assert.IsTrue(employee.HourlyRate.Value == 10m);
            Assert.IsTrue(employee.WeeklyHourAllotment.Value == 40m);
        }

        [TestMethod]
        public void CanMakeSalaryEmployee()
        {
            IEmployee employee = new SalaryEmployee(120000);
            Assert.IsTrue(employee.YearlyRate.Value == 120000);
        }


    }
}
