namespace Examples
{
    internal class Sneaky
    {
        public int Value { get; set; }

        public static Sneaky operator +(Sneaky b, Sneaky c)
        {
            return new Sneaky() { Value = (int)Math.Round((b.Value + c.Value) * Math.PI) };
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
