using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[]
            {
                new Employee("Jan", "Kowalski", 1990, 5_000.00M),
                new Manager("Adam", "Nowak", 2000, 5_000.00M),
            };

            foreach (var employee in employees)
            {
                employee.WhoAmI();
            }
        }
    }
}