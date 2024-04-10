namespace Todo1
{
    // Try keyword: virtual
    internal class A
    {
        public void DoSomething()
        {
            Console.WriteLine("A");
        }
    }

    // Try keyword: new, override
    internal class B : A
    {
        public void DoSomething()
        {
            Console.WriteLine("B");
        }
    }

    internal class Program
    {
        static void Main()
        {
            A a = new B();
            a.DoSomething();
        }
    }
}
