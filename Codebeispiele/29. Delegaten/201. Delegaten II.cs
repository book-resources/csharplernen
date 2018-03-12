using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        public delegate void Delegat();

        static void Main(string[] args)
        {
            Delegat einDelegat = MachWas;
            einDelegat += MachNochWas;

            einDelegat();

            Console.ReadKey();
        }

        public static void MachWas()
        {
            Console.WriteLine("Ich mach' ja schon.");
        }

        public static void MachNochWas()
        {
            Console.WriteLine("Noch was.");
        }
    }
}