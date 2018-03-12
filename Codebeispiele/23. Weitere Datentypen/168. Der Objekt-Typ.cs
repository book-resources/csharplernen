using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            // Boxing
            object objekt = 10;

            // "object" ist aequivalent zu "Object"
            Object nochEinObjekt = true;

            // Unboxing
            int z = (int)objekt;

            Console.ReadKey();
        }
    }
}