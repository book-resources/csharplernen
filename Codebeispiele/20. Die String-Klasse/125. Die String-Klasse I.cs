using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            string vorname = "Vorname ";
            string nachname = "Nachname";

            string name = vorname + nachname;
            Console.WriteLine(name);

            Console.ReadKey();
        }
    }
}