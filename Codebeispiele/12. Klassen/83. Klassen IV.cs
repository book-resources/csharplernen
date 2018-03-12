using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            // Zuerst erzeugen wir ein Objekt der Klasse
            EineNeueKlasse einObjekt = new EineNeueKlasse();

            // Dann koennen wir mit der Punktschreibweise auf ein Member zugreifen
            einObjekt.member = 20;

            // Ausgabe der Variablen
            Console.WriteLine(einObjekt.member);

            Console.ReadKey();
        }
    }

    class EineNeueKlasse
    {
        public int member = 10;
    }
}