using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            Start:
            Console.WriteLine("Dies ist eine Endlosschleife.");
            goto Start;

            Console.ReadKey();
        }
    }
}