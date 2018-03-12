#define WIN
#undef DEBUG

using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
#if (DEBUG)
            Console.WriteLine("DEBUG ist definiert.");
#elif (WIN)
            Console.WriteLine("WIN ist definiert, DEBUG nicht.");
#else
            Console.WriteLine("DEBUG und WIN sind nicht definiert");
#endif
            Console.ReadKey();
        }
    }
}