#define DEBUGGING

using System;
using System.Diagnostics;

namespace ErstesProjekt
{
    class Mainklasse
    {
        [Conditional("DEBUGGING")]
        public static void Debugging()
        {
            Console.WriteLine("Methode wurde ausgefuehrt!");
        }

        static void Main(string[] args)
        {
            Debugging();
            Console.ReadKey();
        }
    }
}