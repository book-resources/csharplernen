using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            int a = 60; // Als Binaerzahl: 0011 1100
            int b = 13; // Als Binaerzahl: 0000 1101

            // Bitweises UND: 0011 1100 AND 0000 1101 = 0000 1100 = 12 als Dezimalzahl
            Console.WriteLine(a & b);

            // Bitweises ODER: 0011 1100 OR 0000 1101 = 0011 1101 = 61 als Dezimalzahl
            Console.WriteLine(a | b);

            // EXKLUSIV-ODER: 0011 1100 XOR 0000 1101 = 0011 0001 = 49 als Dezimalzahl
            Console.WriteLine(a ^ b);

            // Komplement von a: ~a = 1100 0011 = -61 im 8-Bit Zweierkomplement
            Console.WriteLine(~a);

            // Verschiebung nach links um 2 Stellen: aus 0011 1100 wird 1111 0000 = 240 dezimal 
            Console.WriteLine(a << 2);

            // Verschiebung nach rechts um 2 Stellen: aus 0011 1100 wird 0000 1111 = 15 dezimal 
            Console.WriteLine(a >> 2);

            Console.ReadKey();
        }
    }
}