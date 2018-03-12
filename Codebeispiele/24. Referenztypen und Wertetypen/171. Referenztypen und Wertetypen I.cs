using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            int zahl = 10;
            // Wir fuehren die Methode aus und geben das Ergebnis aus
            Console.WriteLine(Verringere(zahl));

            // Nun geben wir den Wert der Variablen zahl aus. Was kommt raus?
            Console.WriteLine(zahl);

            Console.ReadKey();
        }

        static int Verringere(int zahl)
        {
            zahl = zahl - 1;
            return zahl;
        }
    }
}