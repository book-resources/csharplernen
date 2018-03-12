using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Dividieren(10, 0));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Es ist ein Fehler bei der Division aufgetreten!");
                // Die Fehlermeldung auf der Konsole anzeigen lassen
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }

        // Eine Methode zur Division zweier Zahlen
        public static double Dividieren(int dividend, int divisor)
        {
            return dividend / divisor;
        }
    }
}