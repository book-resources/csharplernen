using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            // Hier deklarieren wir eine Variable
            int zahl;

            /* Hier speichern wir den vom Benutzer eingegebenen Wert in 
             * der Variablen zahl ab. Dabei stellt Convert.ToInt32() sicher, 
             * dass der Wert auch in einer Variablen vom Datentyp Integer gespeichert 
             * werden kann.
             */
            zahl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Die eingegebene Zahl lautet:");
            // Hier schreiben wir dann den Wert der Variablen in die Konsole
            Console.WriteLine(zahl);
            Console.ReadKey();
        }
    }
}