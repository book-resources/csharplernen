using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            NeueKlasse einObjekt = new NeueKlasse();
            Console.WriteLine(einObjekt.privateVariable); // Nicht mehr moeglich! 

            Console.ReadKey();
        }
    }

    class NeueKlasse
    {
        private int privateVariable = 10;
    }
}