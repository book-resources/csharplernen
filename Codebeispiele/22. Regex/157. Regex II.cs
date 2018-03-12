using System;
using System.Text.RegularExpressions;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            string klasse = @"[^abc]";
            string zeichenkette = "Buchstaben";

            MatchCollection matches = Regex.Matches(zeichenkette, klasse);
            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }

            Console.ReadKey();
        }
    }
}