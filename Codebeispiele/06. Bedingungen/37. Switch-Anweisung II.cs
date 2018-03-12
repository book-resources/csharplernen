using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            char zeichen = 'a';
            switch (zeichen)
            {
                case 'a':
                    Console.WriteLine("Das Zeichen lautet 'a'.");
                    break;
                case 'b':
                    Console.WriteLine("Das Zeichen lautet 'b'.");
                    break;
                default:
                    Console.WriteLine("Zeichen nicht gefunden.");
                    break;
            }
            Console.ReadKey();
        }
    }
}