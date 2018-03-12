using System;
using System.Collections;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            // Wir erzeugen einen Stapel und legen Elemente darauf ab
            Stack stapel = new Stack();
            stapel.Push("Welt");
            stapel.Push("Hallo");

            /* Wollen wir nun ein Element in einer Variablen abspeichern,
             * so benoetigen wir eine Konvertierung, da die Elemente des 
             * Stapels den Datentyp object haben (es koennen ja schliesslich
             * verschiedenste Werte darauf abgelegt werden).
             */
            string wort = (string)stapel.Pop() + " " + (string)stapel.Pop();
            Console.WriteLine(wort);

            Console.ReadKey();
        }
    }
}