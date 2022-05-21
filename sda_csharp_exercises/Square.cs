namespace sda_csharp_exercises
{
    class Square : Shape
    {
        double side { get; set; }
        public Square(double side)
        {
            this.side = side;
        }
        public override double GetArea()
        {
            return side * side;
        }
    }

}
