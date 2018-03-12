using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }
    }

    // Wir erstellen ein Attribut, das Informationen zu einer Methode beinhaltet
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class NewAttribute : System.Attribute
    {
        private string Rueckgabetyp { get; set; }
        private string Methodenname { get; set; }
        private string Parameter { get; set; }
        public string Zugriffsmodifikator { get; set; }

        // Im Konstruktor werden alle positionellen Parameter erwartet
        public NewAttribute(string typ, string name, string parameter)
        {
            Rueckgabetyp = typ;
            Methodenname = name;
            Parameter = parameter;
        }
    }
}