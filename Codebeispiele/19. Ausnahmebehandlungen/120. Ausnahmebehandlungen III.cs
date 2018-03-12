using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Dividieren(10, 2));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Es ist ein Fehler bei der Division aufgetreten!");
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