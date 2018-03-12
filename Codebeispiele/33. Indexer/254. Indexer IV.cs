using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            Buechersammlung eBooks = new Buechersammlung();
            // Buecher hinzufuegen
            eBooks[0] = new Buch("C# lernen", "Malte Luttermann");
            eBooks[1] = new Buch("Visual C# 2012", "Andreas Kuehnel");

            Console.WriteLine(eBooks["C# lernen"].Autor);
            Console.WriteLine(eBooks["Visual C# 2012"].Autor);

            Console.ReadKey();
        }
    }

    // Eine Klasse, die ein Buch (vereinfacht) repraesentiert
    public class Buch
    {
        // Wir haben zwei Eigenschaften, die beim Erzeugen eines
        // Objektes dieser Klasse gesetzt werden
        public string Titel { get; set; }
        public string Autor { get; set; }

        public Buch(string titel, string autor)
        {
            Titel = titel;
            Autor = autor;
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