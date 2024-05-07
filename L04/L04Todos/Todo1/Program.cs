namespace Todo1
{
    internal class Program
    {
        static void Main()
        {
            #region Object

            var c1 = new MyCollection();
            var c2 = new MyCollection();

            c1.Add(1);
            c1.Add("blub");

            c2.Add(5f);
            c2.Add(1_000_000);

            c1.Add(c2);

            var gottem = c1.GetAt(2);
            
            Console.WriteLine(gottem);

            //PrintInt(gottem);

            #endregion Object

            #region Generic

            var IntC = new MyCollection<int>();
            var FloatC = new MyCollection<float>();
            var DoubleC = new MyCollection<double>();
            var StringC = new MyCollection<string>();

            IntC.Add(1);
            IntC.Add(5);
            //IntC.Add("6");

            PrintInt(IntC.GetAt(1));

            #endregion Generic
        }

        static void PrintInt(int i)
        {
            Console.WriteLine(i);
        }
    }
}
