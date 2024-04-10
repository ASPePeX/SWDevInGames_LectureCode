namespace Todo4
{
    class SimpleCircle
    {
        public double Radius { get; set; }
    }

    class SimpleRect
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    class Program
    {
        static void Main()
        {
            object[] simpleObjectList = new object[]
            {
                new SimpleCircle { Radius = 2},
                new SimpleRect { Width = 3, Height = 5},
                new SimpleRect { Width = 3, Height = 7},
                new SimpleCircle { Radius = 6},
            };

            foreach (object simpleOb in simpleObjectList)
            {
                double calculatedArea = simpleOb switch
                {
                    SimpleCircle circle => circle.Radius * circle.Radius * Math.PI,
                    SimpleRect rect => rect.Height * rect.Width,
                    _ => 0
                };

                Console.WriteLine("Area of simple object: " + calculatedArea);
            }
        }
    }
}
