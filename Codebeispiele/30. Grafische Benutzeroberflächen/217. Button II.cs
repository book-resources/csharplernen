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
            Button unserButton = new Button();
            unserButton.Text = "Drueck mich";
            unserButton.Location = new Point(10, 10);
            unserButton.ForeColor = Color.Blue;
            unserButton.AutoSize = true;
            // Es gibt bereits das vordefinierte Ereignis "Click"
            unserButton.Click += new EventHandler(ButtonPressed);
            this.Controls.Add(unserButton);
        }

        public void ButtonPressed(object sender, EventArgs e)
        {
            Console.WriteLine("Button wurde gedrueckt!");
        }
    }
}