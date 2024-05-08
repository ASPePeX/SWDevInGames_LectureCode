using System.Reflection;

namespace Todo2
{
    /// <summary> 
    /// - Ruft auf Objekten von primitiven Datentypen (int, string) die Methode GetType() auf und inspiziert den Inhalt der jeweils zurückgegebenen Typ-Instanz mit dem Debugger oder gebt Informationen, die von der Instanz abrufbar sind, per WriteLine aus.
    /// - Probiert das Ganze mit selbst definierten Datentypen. Nicht nur mit class und struct, sondern auch mit enum und delegate.
    /// - Schreibt eine Beispiel-Assembly (DLL oder EXE), in der ein oder mehrere Datentypen implementiert werden. Erzeugt ein weiteres (Konsolen-)Projekt, in dem Ihr die Beispiel-Assembly mit LoadFrom (s.o) ladet und die enthaltenen Typen (GetTypes) abfragt und von diesen ein paar Eigenschafte (z.B. Name) ausgebt. Tauscht die Beispiel-Assemblies ohne Source-Code untereinander aus.
    /// </summary>

    internal class Program
    {
        private static void Main()
        {
            Type intType = typeof(int);
            Type stringType = typeof(string);

            Type myClassType = typeof(MyClass);
            Type mySubClassType = typeof(MySubClass);
            Type myStructType = typeof(MyStruct);
            Type myEnumType = typeof(MyEnum);
            Type myDelType = typeof(MyDelegate);

            var types = Assembly.LoadFrom("Todo2.Supplemental.dll");
        }
    }

    internal class MyClass { }
    internal class MySubClass : MyClass { }
    internal struct MyStruct { }
    internal enum MyEnum { one, two }
    internal delegate void MyDelegate(int n);
}