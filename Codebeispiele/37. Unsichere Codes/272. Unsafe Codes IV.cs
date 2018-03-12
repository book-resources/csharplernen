using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static unsafe void Main(string[] args)
        {
            int zahl1 = 20;
            int zahl2 = 5;

            int* zeiger1 = &zahl1;
            int* zeiger2 = &zahl2;

            ZeigerAlsParameter(zeiger1, zeiger2);

            Console.ReadKey();
        }

        static unsafe void ZeigerAlsParameter(int* zeiger1, int* zeiger2)
        {
            Console.WriteLine("Wert von zeiger1 (dereferenziert):" + *zeiger1);
            Console.WriteLine("Wert von zeiger2 (dereferenziert):" + *zeiger2);
        }
    }
}