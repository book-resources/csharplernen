using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            int zahl = 0xF;

            // unsigned
            // "0xFu" ist identisch zu "0xFU"
            uint uzahl = 0xFu;

            // long
            // "0xFl" ist identisch zu "0xFL"
            long lzahl = 0xFl;

            // unsigned long
            // "0xFul" ist identisch zu 0xFlu, 0xFlU, 0xFLu, 
            // 0xFLU, 0xFuL, 0xFUl, 0xFUL
            ulong ulzahl = 0xFul; 

            Console.WriteLine(zahl);
            Console.WriteLine(uzahl);
            Console.WriteLine(lzahl);
            Console.WriteLine(ulzahl);

            Console.ReadKey();
        }
    }
}