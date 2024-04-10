namespace Todo2
{
    abstract class Shape2D
    {
        public abstract double CalculateArea();
    }

    class Rect : Shape2D
    {
        public double Height { get; set; } = 1;
        public double Width { get; set; } = 1;

        public override double CalculateArea()
        {
            return Height * Width;
        }
    }

    class Circle : Shape2D
    {
        public double Radius { get; set; } = 1;

        public override double CalculateArea()
        {
            return Radius * Radius * Math.PI;
        }
    }

    internal class Program
    {
        static void Main()
        {
            var rect = new Rect();
            Console.WriteLine(rect.CalculateArea());

            var circle = new Circle();
            circle.Radius = 5;
            Console.WriteLine(circle.CalculateArea());
        }
    }
}
