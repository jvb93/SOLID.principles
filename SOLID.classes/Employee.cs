namespace SOLID.classes
{
    public abstract class Employee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal? WeeklyHourAllotment { get; set; }
        public decimal? HourlyRate { get; set; }
        public decimal? YearlyRate { get; set; }
        public EmployeeType Type { get; }
        public string Department { get; set; }

        public abstract decimal GetMonthlyPaycheck();
     

        public virtual string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        protected Employee(EmployeeType type)
        {
            Type = type;
        }
    }
}
