namespace Todo2
{
    internal class Program
    {
        static void Main()
        {
            var c1 = new MyCollection<int>();
            c1.Add(9);
            c1.Add(10);
            c1.Add(3);
            c1.Add(2);

            var c2 = new MyCollection<string>();
            c2.Add("blub");
            c2.Add("BLUB");
            c2.Add("BLub");
            c2.Add("blUB");
        }
    }
}
