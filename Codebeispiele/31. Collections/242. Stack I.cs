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

            // Elemente ausgeben
            foreach (int zahl in stapel)
            {
                Console.WriteLine(zahl);
            }

            Console.ReadKey();
        }
    }
}