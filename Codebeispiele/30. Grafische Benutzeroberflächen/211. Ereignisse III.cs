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
            this.KeyPress += new KeyPressEventHandler(KeyEvent);
        }

        private static void KeyEvent(object sender, KeyPressEventArgs e)
        {
            /* Nun ist eine Konvertierung zu char notwendig.
             * Zu beachten bleibt, dass nun auf ein Zeichen geprueft wird,
             * d.h. nun gilt die if-Bedingung nur, wenn tatsaechlich das grosse
             * 'A' gedrueckt wurde (nicht mehr beim kleinen 'a')
             */        
            if (e.KeyChar == (char)Keys.A)
            {
                Console.WriteLine("Taste 'A' wurde gedrueckt.");
            }
            else
            {
                Console.WriteLine("Eine andere Taste wurde gedrueckt.");
            }
        }
    }
}