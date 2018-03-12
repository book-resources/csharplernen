using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            // Erzeugen von zwei Brett-Objekten
            Brett erstesBrett = new Brett(10, 20);
            Brett zweitesBrett = new Brett(30, 40);
            
            // Wenn wir sie nun addieren, nutzen wir den ueberladenen Operator
            int gesamtFlaeche = erstesBrett + zweitesBrett;
            Console.WriteLine(gesamtFlaeche);

            Console.ReadKey();
        }
    }
    
    class Brett
    {
        // Jedes Brett hat eine Laenge und eine Breite
        private int laenge;
        private int breite;

        // Beim Erzeugen eines Bretts muessen wir dessen Laenge und Breite angeben
        public Brett(int laenge, int breite)
        {
            this.laenge = laenge;
            this.breite = breite;
        }

        // Hier implementieren wir Getter fuer die Variablen
        public int GetLaenge()
        {
            return laenge;
        }

        public int GetBreite()
        {
            return breite;
        }

        // Der Flaecheninhalt berechnet sich wie folgt
        public int GetFlaecheninhalt()
        {
            return laenge * breite;
        }

        // Die Setter sind hier implementiert
        public void SetLaenge(int laenge)
        {
            this.laenge = laenge;
        }

        public void SetBreite(int breite)
        {
            this.breite = breite;
        }

        // Nun ueberladen wir den '+'-Operator fuer diese Klasse
        public static int operator +(Brett einBrett, Brett weiteresBrett)
        {
            // Wir addieren den Flaecheninhalt zweier Bretter 
            return einBrett.GetFlaecheninhalt() + weiteresBrett.GetFlaecheninhalt();
        }
    }
}