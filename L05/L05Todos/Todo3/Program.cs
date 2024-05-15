using System.Reflection;

namespace Todo3
{
    /// <summary>
    /// - Schreibt eine Methode PrintTypeInfo(object o), die zu einem übergebenen Objekt dessen komplette Typ-Informationen ausgibt, also u.A.
    /// - Ist es ein Delegate, ein Enum, eine Klasse oder ein Struct?
    /// - Falls Klasse oder Struct
    ///   - Alle public Methoden inkl. Signaturen (Rückgabewert und Parameterliste)
    ///   - Alle public Properties und Felder inkl. deren jeweilige Typen.
    /// </summary>

    internal class SomeOtherType{}

    internal class Program
    {
        private static void Main()
        {
            var assembly = Assembly.LoadFrom("Todo1.dll");
            var types = assembly.GetTypes();
            var singletypearray = types.Where(t => t.Name == "WeirdType");
            var singletype = singletypearray.FirstOrDefault();

            var someotherTypeInstance = new SomeOtherType();

            //var assembly2 = Assembly.LoadFile("Todo2.dll").GetTypes().Where(t => t.Name == "MyStruct").FirstOrDefault();

            if (singletype != null)
                PrintTypeInfo(singletype);
        }

        private static void PrintTypeInfo(object o)
        {
            Type type;

            // Wenn o schon Type ist, direkt verwenden, andernfalls o.GetType()
            if (o is Type)
            {
                type = (Type)o;
            }
            else
            {
                type = o.GetType();
            }

            if (type != null)
            {

                Console.WriteLine($"Name: {type.Name}");

                if (type.IsClass)
                {
                    Console.WriteLine("Class");

                    if (type.BaseType?.Name == "MulticastDelegate")
                    {
                        Console.WriteLine("Delegate");
                    }
                    else
                    {
                        ListFields(type);
                        ListProperties(type);
                        ListMethods(type);
                    }
                }
                else if (type.IsValueType)
                {
                    Console.WriteLine("Struct");

                    if (type.BaseType?.Name == "Enum")
                    {
                        Console.WriteLine("Enum");
                    }
                    else
                    {
                        ListFields(type);
                        ListProperties(type);
                        ListMethods(type);
                    }
                }
            }
        }

        public static void ListFields(Type type)
        {
            var fields = type.GetFields();

            if (fields != null)
            {
                Console.WriteLine($"Fields: {fields.Length}");

                if (fields.Length > 0)
                {
                    foreach (var field in fields)
                    {
                        Console.WriteLine($"- {field}");
                    }
                }
            }
        }

        public static void ListProperties(Type type)
        {
            var properties = type.GetProperties();

            if (properties != null)
            {
                Console.WriteLine($"Properties: {properties.Length}");

                if (properties.Length > 0)
                {
                    foreach (var property in properties)
                    {
                        Console.WriteLine($"- {property}");
                    }
                }
            }
        }

        public static void ListMethods(Type type)
        {
            var methods = type.GetMethods();

            if (methods != null)
            {
                Console.WriteLine($"Methods: {methods.Length}");

                if (methods.Length > 0)
                {
                    foreach (var method in methods)
                    {
                        Console.WriteLine($"- {method}");
                    }
                }
            }
        }
    }
}