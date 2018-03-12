using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            // Wir erzeugen ein neues Objekt der neuen Klasse
            NeueKlasse einObjekt = new NeueKlasse();
            // Da die Variable public ist, koennen wir hier einfach darauf zugreifen
            Console.WriteLine(einObjekt.oeffentlicheVariable);
            Console.ReadKey();
        }
    }

    // Wir erstellen uns eine neue Klasse
    class NeueKlasse
    {
        // Oeffentliche Variable in der neuen Klasse
        public int oeffentlicheVariable = 10;
    }
}