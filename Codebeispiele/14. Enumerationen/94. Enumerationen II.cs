using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        enum Tage : byte { Montag, Dienstag, Mittwoch, Donnerstag, Freitag, Samstag, 
                           Sonntag };

        static void Main(string[] args)
        {
            Tage einTag = Tage.Montag;

            Console.WriteLine(einTag);

            Console.ReadKey();
        }
    }
}