using System;
using System.Collections;

namespace ErstesProjekt
{

    class Mainklasse
    {
        static void Main(string[] args)
        {
            Hashtable unserHashtable = new Hashtable();

            unserHashtable.Add("123", 10);
            unserHashtable.Add("111", 20);
            unserHashtable.Add("222", 30);
            unserHashtable.Add("333", 40);

            // Anzahl der Elemente der Hashtabelle ausgeben
            Console.WriteLine(unserHashtable.Count);

            // Ein Element per Schluessel entfernen
            unserHashtable.Remove("123");

            // Anzahl erneut ausgeben
            Console.WriteLine(unserHashtable.Count);

            // Pruefen, ob ein bestimmer Schlussel enthalten ist
            Console.WriteLine(unserHashtable.ContainsKey("111"));

            // Pruefen, ob ein bestimmer Wert enthalten ist
            Console.WriteLine(unserHashtable.ContainsValue(20));

            // Alle Elemente loeschen
            unserHashtable.Clear();

            // Anzahl erneut ausgeben
            Console.WriteLine(unserHashtable.Count);

            Console.ReadKey();
        }
    }
}