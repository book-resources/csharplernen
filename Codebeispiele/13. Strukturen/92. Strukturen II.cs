using System;

namespace ErstesProjekt
{
    struct Buch
    {
        public double preis;
        public string titel;
        public string autor;
        public int isbn;
    };

    class HalloWelt
    {
        static void Main(string[] args)
        {
            Buch buch1;
            buch1.preis = 9.99;
            buch1.titel = "Erstes Buch";
            buch1.autor = "Erster Autor";       
            buch1.isbn = 123456789;

            Buch buch2;
            buch2.preis = 12.99;
            buch2.titel = "Zweites Buch";
            buch2.autor = "Zweiter Autor";
            buch2.isbn = 987654321;

            Console.WriteLine("Preis von buch1: {0}", buch1.preis);
            Console.WriteLine("Titel von buch1: {0}", buch1.titel);
            Console.WriteLine("Autor von buch1: {0}", buch1.autor);
            Console.WriteLine("ISBN von buch1: {0}", buch1.isbn);

            Console.WriteLine("Preis von buch2: {0}", buch2.preis);
            Console.WriteLine("Titel von buch2: {0}", buch2.titel);
            Console.WriteLine("Autor von buch2: {0}", buch2.autor);
            Console.WriteLine("ISBN von buch2: {0}", buch2.isbn);

            Console.ReadKey();
        }
    }
}