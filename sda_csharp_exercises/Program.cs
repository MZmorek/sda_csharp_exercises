using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 8, 1, 0, 3 };
            PrintArray(BubbleSort(numbers));
        }
        static void PrintArray(int[] numbers)
        {
            foreach (int i in numbers)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        static int[] BubbleSort(int[] numbers)
        {
            int temporary = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {

                        temporary = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temporary;
                    }
                }
            }
            return numbers;
        }
    }
}