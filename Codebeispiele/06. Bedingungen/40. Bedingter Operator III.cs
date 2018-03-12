using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            bool wahrheitswert;
            int zahl = 10;
            int nochEineZahl = 20;
            if (zahl > nochEineZahl)
            {
                wahrheitswert = true;
            }
            else
            {
                wahrheitswert = false;
            }
            int ausgabe = wahrheitswert ? 10 : 20;
            // Was kommt raus?
            Console.WriteLine(ausgabe);
            Console.ReadKey();
        }
    }
}