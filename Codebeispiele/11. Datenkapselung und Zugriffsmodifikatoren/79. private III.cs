using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            NeueKlasse einObjekt = new NeueKlasse();
            // Ausgabe vor der Aenderung
            Console.WriteLine(einObjekt.GetPrivateVariable());
            // Aenderung des Wertes auf 50
            einObjekt.SetPrivateVariable(50);
            // Ausgabe nach der Aenderung
            Console.WriteLine(einObjekt.GetPrivateVariable());

            Console.ReadKey();
        }
    }

    class NeueKlasse
    {
        private int privateVariable = 10;

        // Getter
        public int GetPrivateVariable()
        {
            return privateVariable;
        }

        // Setter
        public void SetPrivateVariable(int neuerWert)
        {
            privateVariable = neuerWert;
        }
    }
}