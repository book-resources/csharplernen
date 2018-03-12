using System;
// Hier geben wir nun an, dass wir den Namensraum "Namensraum2" nutzen wollen
using Namensraum2;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            // Wollen wir nun auf die statische oeffentliche Variable der Klasse,
            // die im anderen Namensraum liegt, zugreifen, machen wir es so:
            Console.WriteLine(EineKlasse.statisch);

            // Fuer die nicht statische Variable brauchen wir ein Objekt der Klasse
            EineKlasse einObjekt = new EineKlasse();
            Console.WriteLine(einObjekt.nichtStatisch);

            Console.ReadKey();
        }
    }
}

namespace Namensraum2
{
    class EineKlasse
    {
        // Statische oeffentliche Variable 
        public static int statisch = 10;

        // Nicht-statische oeffentliche Variable
        public int nichtStatisch = 20;
    }
}