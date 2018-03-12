using System;
using System.Collections;

namespace ErstesProjekt
{

    class Mainklasse
    {
        static void Main(string[] args)
        {
            SortedList sortierteListe = new SortedList();

            /* Das Hinzufuegen funktioniert wie bei der Hashtabelle.
             * Dieses Mal fuegen wir strings statt Zahlen hinzu 
             * (Zahlen sind natuerlich ebenfalls moeglich)
             */ 
            sortierteListe.Add("001", "Erstes Element");
            sortierteListe.Add("002", "Zweites Element");
            sortierteListe.Add("003", "Drittes Element");

            // Die Ausgabe verlaeuft wie bei der Hashtabelle auch
            ICollection alleSchluessel = sortierteListe.Keys;
            foreach (string schluessel in alleSchluessel)
            {
                Console.WriteLine("Schluessel: " + schluessel + ", Wert: " +
                                   sortierteListe[schluessel]);
            }

            Console.ReadKey();
        }
    }
}