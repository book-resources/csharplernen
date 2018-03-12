using System;
using System.Collections;

namespace ErstesProjekt
{

    class Mainklasse
    {
        static void Main(string[] args)
        {
            ArrayList unsereArrayList = new ArrayList();

            // Fuegt Elemente hinzu
            unsereArrayList.Add(50);

            // Gibt die Anzahl der Elemente der ArrayList aus
            Console.WriteLine("Anzahl Elemente: " + unsereArrayList.Count);

            // Loescht alle Elemente der ArrayList
            unsereArrayList.Clear();

            Console.WriteLine("Anzahl Elemente (nach Clear): " +
                               unsereArrayList.Count);

            // Prueft, ob ein bestimmes Objekt vorhanden ist
            Console.WriteLine(unsereArrayList.Contains(50));

            // Fuegt ein Element an einen bestimmten Index (hier 0) ein
            unsereArrayList.Insert(0, 50);

            // Liefert den Index eines Elementes
            Console.WriteLine("Index von 50: " + unsereArrayList.IndexOf(50));

            // Entfernt ein Element (wenn es mehrmals vorhanden ist, dann das Element, 
            // welches als erstes vorkommt)
            unsereArrayList.Remove(50);

            // Hier fuegen wir es wieder ein, um die folgende Methode zu nutzen
            unsereArrayList.Insert(0, 50);

            // Wir koennen auch per Index entfernen
            unsereArrayList.RemoveAt(0);

            // Die Reihenfolge der Elemente umdrehen funktioniert hiermit
            unsereArrayList.Reverse();

            // Und Sortieren koennen wir wie folgt
            unsereArrayList.Sort();

            Console.ReadKey();
        }
    }
}