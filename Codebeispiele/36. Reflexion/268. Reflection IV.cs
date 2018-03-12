using System;
using System.Reflection;

namespace ErstesProjekt
{
    class Mainklasse 
    {
        static void Main(string[] args)
        {
            // Typ von der Klasse, die das Attribut verwendet
            Type tTest = typeof(TestKlasse);
            // Typ von der Klasse, die das Attribut definiert
            Type tAttr = typeof(NewAttribute);

            // Um die Attributinformationen zu erlangen, nutzen wir diese Syntax
            NewAttribute attr = (NewAttribute)Attribute.GetCustomAttribute(tTest, tAttr);
            // Sichergehen, ob das Attribut existiert, bevor wir darauf zugreifen
            if (attr != null)
            {
                Console.WriteLine("Die Klasse heisst " + attr.Name);
            }

            Console.ReadKey();
        }
    }

    [NewAttribute("TestKlasse")]
    public class TestKlasse
    {
        // ...
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class NewAttribute : Attribute
    {
        public string Name { get; set; }

        public NewAttribute(string name)
        {
            Name = name;
        }
    }
}