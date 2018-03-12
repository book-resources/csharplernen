using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        readonly int test = 10;

        static void Main(string[] args)
        {
            Mainklasse klassenObjekt = new Mainklasse();
            klassenObjekt.test = 100; // Das geht nicht mehr!!

            Console.WriteLine(klassenObjekt.test);

            Console.ReadKey();
        }
    }
}