namespace Todo1
{
    /// <summary>
    /// Schaut Euch die Referenzdokumentation zu System.Type an und beantwortet folgende Fragen:
    /// - Wie bekommt man eine Liste der in einer Klasse definierten Methoden?
    /// - Wie bekommt man eine Liste der in einer Klasse definierten Felder / Eigenschaften?
    /// </summary>

    internal class Program
    {
        static void Main()
        {
            var weirdThing = new WeirdType();
            //weirdThing.get_Id();

            Type thisMyClass = typeof(WeirdType);
            Type auchMyClass = weirdThing.GetType();

            if (thisMyClass.Equals(auchMyClass))
                Console.WriteLine("Same");
        }
    }

    internal class WeirdType
    {
        public float Scale;

        public int Id { get; set; }
        public string Name { get; private set; }
        public string Description { get; set; }

        public WeirdType()
        {
            Name = "";
            Description = "";
        }

        public WeirdType(string name = "", string description = "")
        {
            Name = name;
            Description = description;
        }

        public void DoWeirdThing() { }
        public void DoSomethingEvenWeirder(int id) { }
    }
}
