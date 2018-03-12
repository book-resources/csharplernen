using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        delegate void Delegat();

        static void Main(string[] args)
        { 
            Delegat del = delegate(){ Console.WriteLine("Anonyme Methode."); };
            del();

            Console.ReadKey();
        }
    }
}