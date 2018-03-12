using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        enum Tage {Montag, Dienstag, Mittwoch, Donnerstag, Freitag, Samstag, Sonntag};

        static void Main(string[] args)
        {
            byte ersterWochentag = (byte)Tage.Montag;

            Console.WriteLine("Der erste Tag der Woche lautet: {0}", ersterWochentag);

            Console.ReadKey();
        }
    }
}