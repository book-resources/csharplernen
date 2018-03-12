using System;
using System.Collections;

namespace ErstesProjekt
{

    class Mainklasse
    {
        static void Main(string[] args)
        {
            Stack stapel = new Stack();

            // Elemente hinzufuegen
            stapel.Push(1);
            stapel.Push(2);
            stapel.Push(3);
            stapel.Push(4);
            stapel.Push(5);

            // Anzahl der Elemente des Stapels ausgeben
            Console.WriteLine(stapel.Count);

            // Pruefen, ob ein bestimmes Element vorhanden ist
            Console.WriteLine(stapel.Contains(5));

            // Das oberste Element zurueckgeben und entfernen
            Console.WriteLine(stapel.Pop());

            // Das oberste Element zurueckgeben (ohne entfernen)
            Console.WriteLine(stapel.Peek());

            // Alle Elemente des Stapels entfernen
            stapel.Clear();

            // Anzahl erneut ausgeben
            Console.WriteLine(stapel.Count);

            Console.ReadKey();
        }
    }
}