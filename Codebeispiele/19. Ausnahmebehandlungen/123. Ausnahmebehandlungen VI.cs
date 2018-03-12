using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            Zahlen objekt = new Zahlen(new int[] { 3, 53, 76, 64, 86 });
            // Hierbei entsteht nun eine Ausnahme
            objekt.GetIndex(-1);

            Console.ReadKey();
        }
    }

    class Zahlen
    {
        private int[] werte;

        // Konstruktor initialisiert das Array
        public Zahlen(int[] werte)
        {
            this.werte = werte;
        }

        // Eine Methode zur Ausgabe eines Elementes des Arrays
        public int GetIndex(int index)
        {
            // Wir werfen eine Ausnahme bei falscher Eingabe
            if ((index < 0) || (index >= werte.Length))
            {
                throw new IndexOutOfRangeException();
            }
            return werte[index];
        }
    }
}