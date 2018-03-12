using System.Windows.Forms;
using System.Drawing;
using System;

namespace ErstesProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Form unserFenster = new Fenster();
            Application.Run(unserFenster);
        }
    }

    class Fenster : Form
    {
        public Fenster()
        {
            this.Size = new Size(600, 400); // Setzt die Groesse des Fensters
            this.Location = new Point(10, 10); // Setzt die Position des Fensters manuell
            this.BackColor = Color.Blue; // Setzt die Hintergrundfarbe
            this.ForeColor = Color.Green; // Setzt die Schriftfarbe 
            
            try
            {
                this.BackgroundImage = new Bitmap("apfel.jpg"); // Hintergrundbild
            }
            catch (Exception e)
            {
                Console.WriteLine("Es ist ein Fehler aufgetreten.");
            }
        }
    }
}