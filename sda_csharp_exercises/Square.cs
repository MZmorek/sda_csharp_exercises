namespace sda_csharp_exercises
{
    class Square : IShape
    {
        double side { get; set; }
        public Square(double side)
        {
            this.side = side;
        }
        public double GetArea()
        {
            return side * side;
        }
    }

}
