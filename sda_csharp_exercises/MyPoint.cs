namespace sda_csharp_exercises
{
    public class MyPoint
    {
        public double X { get; }
        public double Y { get; }

        public MyPoint(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }
}
