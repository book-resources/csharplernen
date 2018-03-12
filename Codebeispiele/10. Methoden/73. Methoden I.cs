using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            // Hier erzeugen wir ein Klassenobjekt
            // (mehr dazu in Kürze)
            HalloWelt klassenObjekt = new HalloWelt();
            // Hier wird die Methode aufgerufen, das Ergebnis
            // wird direkt in die Konsole geschrieben
            Console.WriteLine(klassenObjekt.IstGerade(10));
            Console.ReadKey();
        }

        // Das hier ist unsere Methode, die einfach nur prueft,
        // ob eine Zahl gerade oder ungerade ist
        public bool IstGerade(int zahl)
        {
            if (zahl % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}