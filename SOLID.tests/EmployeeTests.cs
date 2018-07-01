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
            IEmployeeFactory basicEmployeeFactory = new BasicEmployeeFactory();
            var contract = new EmployeeBuilderContract()
            {
                HourlyRate = 10,
                WeeklyHourAllotment = 40,
                Type = EmployeeType.Hourly
            };
            IEmployee employee = basicEmployeeFactory.CreateEmployee(contract);
            employee.FirstName = "John";
            employee.LastName = "Smith";

            Assert.IsTrue(employee.GetFullName().Equals("John Smith", StringComparison.InvariantCultureIgnoreCase));
        }

        [TestMethod]
        public void CanOverrideFullName()
        {
            IEmployeeFactory basicEmployeeFactory = new BasicEmployeeFactory();
            var contract = new EmployeeBuilderContract()
            {
                YearlyRate = 120000,
                Type = EmployeeType.Salary

            };
            IEmployee employee = basicEmployeeFactory.CreateEmployee(contract);
            employee.FirstName = "John";
            employee.LastName = "Smith";

            Assert.IsTrue(employee.GetFullName().Equals("Smith, John", StringComparison.InvariantCultureIgnoreCase));
        }

        [TestMethod]
        public void CanGetHourlyMonthlyPaycheck()
        {
            IEmployeeFactory basicEmployeeFactory = new BasicEmployeeFactory();
            var contract = new EmployeeBuilderContract()
            {
                HourlyRate = 10,
                WeeklyHourAllotment = 40,
                Type = EmployeeType.Hourly
            };

            IEmployee employee = basicEmployeeFactory.CreateEmployee(contract);
      
            Assert.IsTrue(employee.GetMonthlyPaycheck() == 10 * 40 * 4);

         
        }

        [TestMethod]
        public void CanGetContractMonthlyPaycheck()
        {
            IEmployeeFactory basicEmployeeFactory = new BasicEmployeeFactory();
            var contract = new EmployeeBuilderContract()
            {
                HourlyRate = 10,
                WeeklyHourAllotment = 40,
                Type = EmployeeType.Contract
            };
       
            IEmployee employee = basicEmployeeFactory.CreateEmployee(contract);
       
            Assert.IsTrue(employee.GetMonthlyPaycheck() == 10 * 40 * 4);

        }

        [TestMethod]
        public void CanGetSalaryMonthlyPaycheck()
        {
            IEmployeeFactory basicEmployeeFactory = new BasicEmployeeFactory();

            var contract = new EmployeeBuilderContract()
            {
                YearlyRate = 120000,
                Type = EmployeeType.Salary
            };

            IEmployee employee = basicEmployeeFactory.CreateEmployee(contract);

            Assert.IsTrue(employee.GetMonthlyPaycheck() == 120000m / 12);

          
        }

        [TestMethod]
        public void CanMakeContractEmployee()
        {
            var employee = new ContractEmployee(40, 10);
            Assert.IsTrue(employee.HourlyRate == 10m);
            Assert.IsTrue(employee.WeeklyHourAllotment == 40m);
        }

        [TestMethod]
        public void CanMakeHourlyEmployee()
        {
            var employee = new HourlyEmployee(40, 10);
            Assert.IsTrue(employee.HourlyRate == 10m);
            Assert.IsTrue(employee.WeeklyHourAllotment == 40m);
        }

        [TestMethod]
        public void CanMakeSalaryEmployee()
        {
            var employee = new SalaryEmployee(120000);
            Assert.IsTrue(employee.YearlyRate == 120000);
        }


    }
}
