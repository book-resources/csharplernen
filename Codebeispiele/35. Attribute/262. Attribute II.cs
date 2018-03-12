using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            AlteMethode(); // Fehler!

            Console.ReadKey();
        }

        [Obsolete("Methode ist veraltet!", true)]
        public static void AlteMethode()
        {
            Console.WriteLine("Alte Methode.");
        }

        public static void NeueMethode()
        {
            Console.WriteLine("Neue Methode.");
        }
    }
}