namespace Examples
{
    struct Pair
    {
        public int left;
        public int right;
    }

    class Cat
    {
        public string? name;
        public int age;
    }

    public class Example01
    {
        public static void Main()
        {
            Pair pairOne = new Pair { left = 47, right = 11 };
            Pair pairTwo = pairOne;
            pairTwo.left = 99;

            Console.WriteLine("pairOne.left: " + pairOne.left);


            Cat cuteCat = new Cat { name = "Whiskers", age = 5 };
            Cat copyCat = cuteCat;
            copyCat.age = 10;

            Console.WriteLine("cuteCat.age: " + cuteCat.age);


            Sneaky thing1 = new Sneaky();
            thing1.Value = 3;

            Sneaky thing2 = new Sneaky();
            thing2.Value = 7;

            Sneaky thing3 = thing1 + thing2;
            Console.WriteLine($"thing1: {thing1}, thing2: {thing2}, thing3: {thing3.Value}");
        }
    }
}
