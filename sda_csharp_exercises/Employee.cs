namespace sda_csharp_exercises
{
    class Employee : Person
    {
        public decimal Salary { get; set; }

        public Employee(string FirstName, string LastName, int YearOfBirth, decimal Salary)
            : base (FirstName, LastName, YearOfBirth)
        {
            this.Salary = Salary;
        }
    }
}
