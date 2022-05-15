using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog malina = new("Malina");
            Dog szatan = new("Szatan");
            Cat rysio = new("Rysio");

            IPet[] pets = new IPet[3];
            pets[0] = malina;
            pets[1] = szatan;
            pets[2] = rysio;

            PrintInfo(pets);
        }
        public static void PrintInfo(IPet[] pets)
        {
            foreach (IPet pet in pets)
            {
                if (pet is Dog dog)
                {
                    Console.WriteLine($"{dog.name} jest psem i robi {pet.MakeSound()}");
                }
                else if (pet is Cat cat)
                {
                    Console.WriteLine($"{cat.name} jest kotem i robi {pet.MakeSound()}");
                }
            }
        }
    }
}
