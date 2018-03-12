using System;

namespace ErstesProjekt
{
    class HalloWelt : Abstrakt
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        // Hier implementieren wir die Methode
        public override void AbstrakteMethode()
        {
            Console.WriteLine("Jetzt ist die Methode implementiert.");
        }
    }

    abstract class Abstrakt
    {
        public abstract void AbstrakteMethode();
    }
}