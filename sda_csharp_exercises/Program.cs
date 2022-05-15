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


        }
        public static void PrintInfo(IPet[] pets)
        {
            foreach (IPet pet in pets)
            {
                Console.WriteLine($"{name} robi {pet.MakeSound()}");
            }
        }

        public static void PetType(IPet[] pets)
        {
            foreach (IPet pet in pets)
            {
                if (pet is Dog)
                {
                    Console.Write("jest psem");
                }
                else if (pet is Cat)
                {
                Console.Write("jest kotem");
                }
            }
        }
    }
}
