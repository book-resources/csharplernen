using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }

        [NewAttribute("void", "EineMethode", "keine", Zugriffsmodifikator = "public")]
        public void EineMethode()
        {
            Console.WriteLine("Hallo Welt!");
        }

        [NewAttribute("int", "Addieren", "int, int")]
        int Addieren(int ersterSummand, int zweiterSummand)
        {
            return ersterSummand + zweiterSummand;
        }

        [NewAttribute("void", "Schreiben", "string", Zugriffsmodifikator = "private")]
        private void Schreiben(string text)
        {
            Console.WriteLine(text);
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