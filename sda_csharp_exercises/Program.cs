using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DrawTriangle();
            }
            catch
            {
                Console.WriteLine("Niewłaściwa wartość.");
            }
            
        }
        static void DrawTriangle()
        {
            int numberOfLines = 3;
            Console.WriteLine("Wpisz znak: ");
            char sign = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                PrintLine(i, sign);
            }
            for (int i = numberOfLines; i > 0; i--)
            {
                PrintLine(i, sign);
            }

            static void PrintLine(int numberOfLines, char sign)
            {
                for (int i = 1; i <= numberOfLines; i++)
                {
                    Console.Write(sign);
                }
                Console.WriteLine();
            }
        }
    }
}
