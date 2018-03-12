using System.Windows.Forms;
using System.Media;
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
        private SoundPlayer ton;

        public Fenster()
        {
            try
            {
                // In den Klammern steht der Dateipfad 
                ton = new SoundPlayer("sound.wav");
                // Laedt den Sound und spielt ihn dann direkt ab
                ton.Load();
                ton.Play();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ungueltiger Dateipfad!", "Fehler");
            }

            Button stopButton = new Button();
            stopButton.Text = "Stop";
            stopButton.Location = new Point(10, 10);
            stopButton.AutoSize = true;
            stopButton.MouseClick += new MouseEventHandler(ButtonPressed);
            this.Controls.Add(stopButton);

            this.AutoSize = true;
        }

        public void ButtonPressed(object sender, MouseEventArgs e)
        {
            try
            {
                // Stoppt die Wiedergabe
                ton.Stop();
            }
            catch (Exception f)
            {
                MessageBox.Show("Kann nicht wiedergegeben werden!", "Fehler");
            }
        }
    }
}