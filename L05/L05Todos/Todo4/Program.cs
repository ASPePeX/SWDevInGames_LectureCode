namespace Todo4
{
    internal class Program
    {
        private static void Main()
        {
            var type = typeof(MyClass);
        }
    }

    [ClassInfo]
    public class MyClass
    {
        [MethodInfo]
        public void DoSomething([ParamInfo] int a) { }

        [FieldInfo]
        public int Number;
    }

    public class XAttribute : Attribute { }
    public class MethodInfoAttribute : Attribute { }
    public class ParamInfoAttribute : Attribute { }
    public class FieldInfoAttribute : Attribute { }
}