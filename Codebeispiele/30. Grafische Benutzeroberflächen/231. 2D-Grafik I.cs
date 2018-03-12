using System.Windows.Forms;
using System;
using System.Drawing;

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
            this.Paint += new PaintEventHandler(Zeichnen);
            this.AutoSize = true;
        }

        public void Zeichnen(object sender, PaintEventArgs e)
        {
            Console.WriteLine("Hier wird gezeichnet.");
        }
    }
}