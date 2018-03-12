using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static unsafe void Main(string[] args)
        {
            // Normale Integer Variable
            int zahl = 10;

            // Zeiger, der auf die Speicheradresse der Variablen zahl zeigt
            int* zeiger = &zahl;

            // Ausgeben des dereferenzierten Zeigers
            Console.WriteLine(*zeiger);

            Console.ReadKey();
        }
    }
}