using System;
using System.Collections;

namespace ErstesProjekt
{

    class Mainklasse
    {
        static void Main(string[] args)
        {
            SortedList sortierteListe = new SortedList();

            // Gibt die Anzahl der Elemente der sortierten Liste an
            Console.WriteLine(sortierteListe.Count);

            // Elemente hinzufuegen
            sortierteListe.Add("001", 99);
            sortierteListe.Add("002", 89);
            sortierteListe.Add("003", 79);

            // Auf ein Element mittels Index zugreifen
            Console.WriteLine(sortierteListe.GetByIndex(0));

            // Pruefen, ob ein bestimmter Schluessel vorhanden ist
            Console.WriteLine(sortierteListe.ContainsKey("001"));

            // Pruefen, ob ein bestimmter Wert vorhanden ist
            Console.WriteLine(sortierteListe.ContainsValue(100));

            // Auf einen Schluessel ueber den Index zugreifen
            Console.WriteLine(sortierteListe.GetKey(0));

            // Den Index eines Schluessels bekommen
            Console.WriteLine(sortierteListe.IndexOfKey("001"));

            // Den Index eines Wertes erhalten
            Console.WriteLine(sortierteListe.IndexOfValue(99));

            // Ein Element ueber den Index entfernen
            sortierteListe.RemoveAt(1);

            // Ein Element ueber den Schluessel entfernen
            sortierteListe.Remove("001");

            // Alle Elemente der sortierten Liste entfernen
            sortierteListe.Clear();

            // Gibt die Anzahl der Elemente der sortierten Liste an
            Console.WriteLine(sortierteListe.Count);

            Console.ReadKey();
        }
    }
}