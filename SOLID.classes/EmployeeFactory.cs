namespace SOLID.classes
{
    public static class EmployeeFactory
    {
        public static IEmployee CreateEmployee(EmployeeType type)
        {
            switch (type)
            {
                case EmployeeType.Contract:
                    return new ContractEmployee();
                case EmployeeType.Hourly:
                    return new HourlyEmployee();
                case EmployeeType.Salary:
                    return new SalaryEmployee();
                default:
                    return null;
            }
        }
    }
}
