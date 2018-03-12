using System;
using System.Collections;

namespace ErstesProjekt
{

    class Mainklasse
    {
        static void Main(string[] args)
        {
            Queue warteschlange = new Queue();

            // Elemente hinzufuegen
            warteschlange.Enqueue(1);
            warteschlange.Enqueue(2);
            warteschlange.Enqueue(3);
            warteschlange.Enqueue(4);
            warteschlange.Enqueue(5);

            // Anzahl der Elemente der Warteschlange bekommen
            Console.WriteLine(warteschlange.Count);

            // Pruefen, ob ein Element vorhanden ist
            Console.WriteLine(warteschlange.Contains(7));

            // Das zuerst eingefuegte Element zurueckgeben und entfernen
            Console.WriteLine(warteschlange.Dequeue());

            // Alle Elemente der Warteschlange loeschen
            warteschlange.Clear();

            // Anzahl der Elemente erneut ausgeben
            Console.WriteLine(warteschlange.Count);

            Console.ReadKey();
        }
    }
}