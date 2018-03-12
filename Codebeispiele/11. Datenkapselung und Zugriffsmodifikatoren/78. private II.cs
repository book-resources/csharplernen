using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            NeueKlasse einObjekt = new NeueKlasse();

            Console.WriteLine(einObjekt.GetPrivateVariable());


            Console.ReadKey();
        }
    }

    class NeueKlasse
    {
        private int privateVariable = 10;

        // Getter-Methode
        public int GetPrivateVariable()
        {
            return privateVariable;
        }
    }
}