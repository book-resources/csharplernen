using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            bool wahr = true;
            int zahl = 10;
            int nochEineZahl = 20;
            int ausgabe = wahr ? 10 : 20;
            // Was kommt raus?
            Console.WriteLine(ausgabe);
            Console.ReadKey();
        }
    }
}