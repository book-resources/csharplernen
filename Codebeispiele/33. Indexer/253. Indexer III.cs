using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }
    }

    public class Buechersammlung
    {
        private Buch[] buecher = new Buch[10];

        public Buch this[int index]
        {
            get
            {
                return buecher[index];
            }
            set
            {
                buecher[index] = value;
            }
        }

        public Buch this[string titel]
        {
            get
            {
                // Wir suchen nach dem angegebenem Titel und geben
                // das zugehoerige Buch zurueck, wenn es existiert
                for (int i = 0; i < 10; i++)
                {
                    if (buecher[i].Titel == titel)
                    {
                        return buecher[i];
                    }
                }
                return null;
            }
        }
    }
}