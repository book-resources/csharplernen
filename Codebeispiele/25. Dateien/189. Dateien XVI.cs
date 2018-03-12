using System;
using System.IO;

namespace ErstesProjekt
{
    class Mainklasse
    {
        static void Main(string[] args)
        {
            try
            {
                FileInfo file = new FileInfo(@"C:\Users\Malte\Documents\Visual Studio 
                2017\Projects\ErstesProjekt\ErstesProjekt\bin\Debug\hallo.txt");

                using (StreamWriter writer = file.AppendText())
                {
                    writer.WriteLine("Hallo");
                    writer.WriteLine("Welt!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ein Fehler ist aufgetreten.");
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}