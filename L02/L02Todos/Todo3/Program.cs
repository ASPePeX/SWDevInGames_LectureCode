namespace Todo3
{
    interface IShape2D
    {
        double CalculateArea();
    }

    class Rect : IShape2D
    {
        public double Height { get; set; } = 1;
        public double Width { get; set; } = 1;

        public double CalculateArea()
        {
            return Height * Width;
        }
    }

    class Circle : IShape2D
    {
        public double Radius { get; set; } = 1;

        public double CalculateArea()
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
