using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Dies", "ist", "eine", "Verbindung" };

            string zusammen = String.Join(" ", stringArray);
            Console.WriteLine(zusammen);

            string zusammenTrennstrich = String.Join("_", stringArray);
            Console.WriteLine(zusammenTrennstrich);

            Console.ReadKey();
        }
    }
}