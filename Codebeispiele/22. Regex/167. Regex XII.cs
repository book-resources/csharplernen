using System;
using System.Text.RegularExpressions;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            string klasse = @"\D";
            string zeichenkette = "Dieser Text wird gefiltert. 123";

            MatchCollection matches = Regex.Matches(zeichenkette, klasse);
            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }

            Console.ReadKey();
        }
    }
}