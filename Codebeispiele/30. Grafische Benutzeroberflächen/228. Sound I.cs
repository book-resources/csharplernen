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
                // Laedt den Sound
                ton.Load();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ungueltiger Dateipfad!", "Fehler");
            }

            Button playButton = new Button();
            playButton.Text = "Play";
            playButton.Location = new Point(10, 10);
            playButton.AutoSize = true;
            playButton.MouseClick += new MouseEventHandler(ButtonPressed);
            this.Controls.Add(playButton);

            this.AutoSize = true;
        }

        public void ButtonPressed(object sender, MouseEventArgs e)
        {
            try
            {
                // Spielt den Sound ab
                ton.Play();
            }
            catch (Exception f)
            {
                MessageBox.Show("Kann nicht wiedergegeben werden!", "Fehler");
            }
        }
    }
}