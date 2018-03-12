using System;

namespace ErstesProjekt
{
    class HalloWelt : Basisklasse
    {
        static void Main(string[] args)
        {
            Basisklasse basisObjekt = new Basisklasse();
            // Hier rufen wir die Methode der Basisklasse auf
            basisObjekt.VirtuelleMethode();

            
            HalloWelt abgeleitetesObjekt = new HalloWelt();
            // Hier rufen wir die Methode der abgeleiteten Klasse auf
            abgeleitetesObjekt.VirtuelleMethode();

            Console.ReadKey();
        }

        public override void VirtuelleMethode()
        {
            Console.WriteLine("Hier wurde die Methode ueberschrieben.");
        }
    }

    class Basisklasse
    {
        public virtual void VirtuelleMethode()
        {
            Console.WriteLine("Dies ist eine virtuelle Methode.");
        }
    }
}