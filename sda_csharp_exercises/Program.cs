using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] guests = new Person[]
            {
                new Person("Jan", "Kowalski", 1988),
                new Employee("Adam", "Nowak", 2000, 5_000.00M)
            };

            foreach (Person guest in guests)
            {
                guest.WhoAmI();

                if (guest is Employee employee)
                {
                    Console.WriteLine($" - salary: {employee.Salary}");
                }
            }
            PrintHello(guests);
        }
        static void PrintHello(Person[] guests)
        {
            foreach (var guest in guests)
            {
                if (guest.IsAdult)
                {
                    Console.WriteLine("Welcome to adult zone");
                }
                else
                {
                    Console.WriteLine("Welcome to the playground");
                }
            }
        }
    }
}
