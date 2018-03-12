using System;
using System.Windows.Forms;

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
            this.MouseClick += new MouseEventHandler(KeyEvent);
        }

        private static void KeyEvent(object sender, MouseEventArgs e)
        {   
            if ((e.Button == MouseButtons.Right) || (e.Button == MouseButtons.Left))
            {
                Console.WriteLine("Aktuelle Position der Maus: {0}", e.Location);
            }
        }
    }
}
