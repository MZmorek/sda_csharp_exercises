using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Jan";
            person.LastName = "Kowalski";
            person.YearOfBirth = 1988;

            person.WhoAmI();
            //Console.WriteLine($"Is Adult: {person.IsAdult()}");
            Console.WriteLine($"Is Adult: {person.IsAdult}");

        }
    }
}
