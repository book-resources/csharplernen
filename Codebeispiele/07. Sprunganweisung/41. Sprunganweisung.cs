using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hier beginnt das Programm.");
            goto Ende;
            Console.WriteLine("Diese Anweisung wird uebersprungen.");
        Ende:
            Console.WriteLine("Hier ist das Ende des Programms.");
            Console.ReadKey();
        }
    }
}