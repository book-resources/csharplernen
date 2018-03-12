using System;

namespace ErstesProjekt
{
    class HalloWelt
    {
        static void Main(string[] args)
        {
            int monat = 2;
            switch (monat)
            {
                case 1:
                    Console.WriteLine("Wir haben Januar.");
                    break;
                case 2:
                    Console.WriteLine("Wir haben Februar.");
                    break;
                case 3:
                    Console.WriteLine("Wir haben Maerz.");
                    break;
                case 4:
                    Console.WriteLine("Wir haben April.");
                    break;
                case 5:
                    Console.WriteLine("Wir haben Mai.");
                    break;
                case 6:
                    Console.WriteLine("Wir haben Juni.");
                    break;
                case 7:
                    Console.WriteLine("Wir haben Juli.");
                    break;
                case 8:
                    Console.WriteLine("Wir haben August.");
                    break;
                case 9:
                    Console.WriteLine("Wir haben September.");
                    break;
                case 10:
                    Console.WriteLine("Wir haben Oktober.");
                    break;
                case 11:
                    Console.WriteLine("Wir haben November.");
                    break;
                case 12:
                    Console.WriteLine("Wir haben Dezember.");
                    break;
                default:
                    Console.WriteLine("Ungueltige Eingabe.");
                    break;
            }
            Console.ReadKey();
        }
    }
}