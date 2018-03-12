using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            // Ein Objekt der Klasse erzeugen
            Kreis rundesObjekt = new Kreis();

            // Der Zugriff kann nun einfach so erfolgen
            Console.WriteLine(rundesObjekt.Durchmesser);

            rundesObjekt.Durchmesser = 20;
            Console.WriteLine(rundesObjekt.Durchmesser);

            Console.ReadKey();
        }
    }

    public class Kreis
    {
        public int Durchmesser { get; set; }
    }
}