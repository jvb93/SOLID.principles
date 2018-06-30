namespace SOLID.classes
{
    public interface IEmployee 
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal? WeeklyHourAllotment { get; set; }
        decimal? HourlyRate { get; set; }
        decimal? YearlyRate { get; set; }
        EmployeeType Type { get;  }
        string Department { get; set; }
        decimal GetMonthlyPaycheck();
        string GetFullName();

    }

    public enum EmployeeType
    {
        Salary,
        Hourly,
        Contract
    }
}
