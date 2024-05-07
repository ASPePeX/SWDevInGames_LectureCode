namespace Todo3
{
    internal class Program
    {
        static void Main()
        {
            var c1 = new MyCollection<int>();

            c1.Add(1);
            c1.Add(2);
            c1.Add(3);
            c1.Add(4);

            c1[2] = c1[2] * 5;

            Console.WriteLine($"{c1[1]}, {c1[2]}");

            for (int i = 0; i < c1.Count; i++)
            {
                Console.WriteLine(c1[i]);
            }
        }
    }
}
