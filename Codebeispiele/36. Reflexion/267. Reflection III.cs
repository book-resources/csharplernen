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

            // Methodeninformation zu einer Methode aus der TestKlasse
            MethodInfo mInfo = tTest.GetMethod("Addieren");

            // Um die Attributinformationen zu erlangen, nutzen wir diese Syntax
            NewAttribute attr = (NewAttribute)Attribute.GetCustomAttribute(mInfo, tAttr);
            // Sichergehen, ob das Attribut existiert, bevor wir darauf zugreifen
            if (attr != null)
            {
                Console.Write("Methode: " + attr.Zugriffsmodifikator + " ");
                Console.Write(attr.Rueckgabetyp + " ");
                Console.Write(attr.Methodenname);
                Console.Write("(" + attr.Parameter + ")");
            }

            Console.ReadKey();
        }
    }

    public class TestKlasse
    {
        [NewAttribute("int", "Addieren", "int, int", Zugriffsmodifikator = "public")]
        public int Addieren(int ersterSummand, int zweiterSummand)
        {
            return ersterSummand + zweiterSummand;
        }
    }

    [AttributeUsage(AttributeTargets.Method)]
    public class NewAttribute : Attribute
    {
        public string Rueckgabetyp { get; set; }
        public string Methodenname { get; set; }
        public string Parameter { get; set; }
        public string Zugriffsmodifikator { get; set; }

        public NewAttribute(string typ, string name, string parameter)
        {
            Rueckgabetyp = typ;
            Methodenname = name;
            Parameter = parameter;
        }
    }
}