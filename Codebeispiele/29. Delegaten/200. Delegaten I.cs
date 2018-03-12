using System;
namespace ErstesProjekt
{
    class Mainklasse
    {
        /* Ein Delegat mit dem Namen (und Typen) "Delegat" deklarieren.
         * Der Delegat besitzt zwei Parameter vom Typ int
         */
        public delegate int Delegat(int zahl1, int zahl2);

        static void Main(string[] args)
        {
            // Delegat deklarieren, aber noch nicht initialisieren
            Delegat einDelegat;

            // Benutzereingabe (vereinfacht), wartet auf zwei ganze Zahlen
            Console.WriteLine("Geben Sie die beiden Operanden nacheinander ein.");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            // Auswahl der Operation (bei falscher Eingabe passiert nichts)
            Console.WriteLine("1 druecken fuer Addition, 2 fuer Subtraktion");
            int operation = Convert.ToInt32(Console.ReadLine());
            
            /* Wurde eine 1 gedrueckt, addieren wir die Zahlen, 
             * bei einer 2 subtrahieren wir die zweite Zahl von der ersten Zahl. 
             * Dazu initialisieren wir unseren Delegaten passend und schreiben
             * dann das Ergebnis seiner Ausfuehrung in die Konsole
             */
            if (operation == 1)
            {
                einDelegat = new Delegat(Operation.Addieren);
                Console.WriteLine(einDelegat(zahl1, zahl2));
            }
            else if (operation == 2)
            {
                einDelegat = new Delegat(Operation.Subtrahieren);
                Console.WriteLine(einDelegat(zahl1, zahl2));
            }

            Console.ReadKey();
        }
    }

    /* Klasse mit zwei moeglichen Operationen.
     * Beide Methoden haben zwei Parameter vom Typ int,
     * koennen also von unserem Delegaten aufgerufen werden
     */
    class Operation
    {
        public static int Addieren(int a, int b)
        {
            return a + b;
        }

        public static int Subtrahieren(int a, int b)
        {
            return a - b;
        }
    }
}