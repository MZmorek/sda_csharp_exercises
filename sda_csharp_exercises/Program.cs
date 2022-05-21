using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPoint point = new(5, 10);
            Console.WriteLine(point);

            MyPoint anotherPoint = new(3, 2);
            Console.WriteLine(anotherPoint);

            LineSegment firstLine = new(point, anotherPoint);
            Console.WriteLine(firstLine.GetLength());

            LineSegment secondLine = new(5, 10, 3, 2);
            Console.WriteLine(secondLine.GetLength());
        }
    }
}
