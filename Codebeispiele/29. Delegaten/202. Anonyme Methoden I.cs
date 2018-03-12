using System;

namespace ErstesProjekt
{
    class Mainklasse
    {
        delegate void Delegat();

        static void Main(string[] args)
        {
            Delegat del = delegate () {/* hier ist die anonyme Methode */};
            del();

            Console.ReadKey();
        }
    }
}