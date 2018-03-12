using System;

namespace ErstesProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klassenobjekt fuer den Zugriff erzeugen
            Klasse objekt = new Klasse();

            /* Hier fuegen wir einen "Abonnenten" zum Ereignis hinzu.
             * In den Klammern steht die Methode, die ausgefuehrt werden soll,
             * wenn das Ereignis ausgeloest wird
             */
            objekt.UnserEvent += new Klasse.EventDelegat(LoeseEreignisAus);

            // Eingaben entgegennehmen
            Console.WriteLine("Geben Sie zwei Zahlen ein.");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            int zahl2 = Convert.ToInt32(Console.ReadLine());
            // Ergebnis der Operation direkt in die Konsole schreiben
            Console.WriteLine(objekt.Multiplizieren(zahl1, zahl2));

            Console.ReadKey();
        }

        // Diese Methode wird ausgefuehrt, wenn das Ereignis auftritt
        static void LoeseEreignisAus()
        {
            Console.WriteLine("Das Ergebnis ist groesser als 100!");
        }
    }

    class Klasse
    {
        // Deklaration von Delegat und Ereignis
        public delegate void EventDelegat();
        public event EventDelegat UnserEvent;

        /* Methode zur Multiplikation von zwei Zahlen.
         * Wenn das Ergebnis groesser als 100 ist,
         * loesen wir ein Ereignis aus
         */
        public int Multiplizieren(int a, int b)
        {
            int ergebnis = a * b;

            /* Bevor wir ein Ereignis ausloesen, muessen wir immer
             * sicherstellen, dass das Ereignis einen "Abonnenten" hat
             * (d.h. dass das Ereignis nicht "null" ist)
             */
            if ((ergebnis > 100) && (UnserEvent != null))
            {
                UnserEvent();
            }

            return ergebnis;
        }
    }
}