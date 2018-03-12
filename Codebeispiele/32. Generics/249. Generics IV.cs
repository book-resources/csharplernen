using System;
using System.Collections.Generic;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            // Wir erzeugen einen Stapel und legen Elemente darauf ab
            Stack<string> stapel = new Stack<string>();
            stapel.Push("Welt");
            stapel.Push("Hallo");

            // Nun ist keine Konvertierung mehr notwendig
            string wort = stapel.Pop() + " " + stapel.Pop();
            Console.WriteLine(wort);

            Console.ReadKey();
        }
    }
}