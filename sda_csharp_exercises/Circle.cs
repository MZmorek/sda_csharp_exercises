using System;

namespace sda_csharp_exercises
{
    class Circle : IShape
    {
        private double radius { get; set; }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double GetArea()
        {
            return radius * radius * Math.PI;
        }
    }
}
