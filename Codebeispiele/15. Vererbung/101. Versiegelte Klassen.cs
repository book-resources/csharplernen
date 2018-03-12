using System;

namespace ErstesProjekt
{
    class HalloWelt : Klasse // Nicht moeglich, da Klasse sealed ist!
    {
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }
    }

    sealed class Klasse
    {
        int membervariable = 10;
    }
}