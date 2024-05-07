namespace Todo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c1 = new MyCollection<int>();

            c1.Add(1);
            c1.Add(2);
            c1.Add(3);
            c1.Add(4);

            c1[2] = c1[2] * 5;

            foreach (var i in c1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
