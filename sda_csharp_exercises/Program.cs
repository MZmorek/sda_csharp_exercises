using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[4];
            shapes[0] = new Circle(2);
            shapes[1] = new Square(3);
            shapes[2] = new Square(2);
            shapes[3] = new Circle(2);

            double total = 0;

            for (int i = 0; i < shapes.Length; i++)
            {
                total += shapes[i].GetArea(); 
            }
            Console.WriteLine(total);
        }
    }
}
