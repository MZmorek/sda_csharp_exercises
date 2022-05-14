using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 4;
            int firstElement = 2;
            int difference = 3;
            ComputeArithmeticSequence(length, firstElement, difference);
        }
        static void ComputeArithmeticSequence(int length, int firstElement, int difference)
        {
            int currentElement = firstElement;
            for(int i = 1; i <= length; i++)
            {
                Console.WriteLine(currentElement);
                currentElement += difference;
            }
        }
    }
}
