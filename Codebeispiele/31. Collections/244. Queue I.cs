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

            // Elemente ausgeben
            foreach (int zahl in warteschlange)
            {
                Console.WriteLine(zahl);
            }

            Console.ReadKey();
        }
    }
}