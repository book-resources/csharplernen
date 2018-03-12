using System;

namespace ErstesProjekt
{
    class Program
    {
        public static int globaleVariable;

        static void Main(string[] args)
        {
            // Zugriff auf globale Variable moeglich
            globaleVariable = 10;

            // Zugriff auf die lokale Variable eines anderen Blocks
            // ist dagegen nicht moeglich
            lokaleVariable = 10; // FEHLER

            Console.ReadKey();
        }

        static void Methode()
        {
            int lokaleVariable;
        }
    }
}