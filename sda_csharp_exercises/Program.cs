using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawTriangle();
        }
        static void DrawTriangle()
        {
            int numberOfLines = 3;
            Console.WriteLine("Wpisz znak: ");
            char sign = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(sign);
                }
                Console.WriteLine();
            }
            for (int i = numberOfLines; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(sign);
                }
                Console.WriteLine();
            }
        }
    }
}
