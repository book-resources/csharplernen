#define DEMOVERSION
#define VOLLVERSION

#if DEMOVERSION && VOLLVERSION
#error DEMOVERSION und VOLLVERSION koennen nicht gleichzeitig definiert sein
#endif

using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}