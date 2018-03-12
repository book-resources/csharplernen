using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static unsafe void Main(string[] args)
        {
            int zahl = 10;

            int* zeiger = &zahl;

            // Zeiger auf einen Zeiger
            int** zeigerzeiger = &zeiger;

            // Zweimal dereferenziert: Der Wert von zahl
            Console.WriteLine(**zeigerzeiger);
            // Einmal dereferenziert: Der Wert von zeiger 
            // (entspricht der Speicheradresse von zahl)
            Console.WriteLine((int)*zeigerzeiger);
            // Nicht dereferenziert: Die Speicheradresse von zeiger
            Console.WriteLine((int)zeigerzeiger);

            Console.ReadKey();
        }
    }
}