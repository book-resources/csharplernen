using System;
using System.Collections;

namespace ErstesProjekt
{

    class Mainklasse
    {
        static void Main(string[] args)
        {
            Hashtable unserHashtable = new Hashtable();

            // Hinzufuegen von Elementen
            // (erstes Argument ist der Schluessel, zweites Argument das Element)
            unserHashtable.Add("000", 50);
            unserHashtable.Add("123", 300);
            unserHashtable.Add("456", 20);

            // Zum Ausgeben speichern wir die Schluessel in einer ICollection
            ICollection alleSchluessel = unserHashtable.Keys;

            // Ausgeben dann nach wie vor mit foreach-Schleife
            foreach (string schluessel in alleSchluessel)
            {
                Console.WriteLine("Schluessel:" + schluessel);
                Console.WriteLine("Inhalt:" + unserHashtable[schluessel]);
            }

            Console.ReadKey();
        }
    }
}