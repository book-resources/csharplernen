#define DEBUG
using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
#if (DEBUG)
            Console.WriteLine("DEBUG ist definiert.");
#else
            Console.WriteLine("DEBUG ist nicht definiert");
#endif
            Console.ReadKey();
        }
    }
}