using System.Windows.Forms;
using System;
using System.Drawing;
using WMPLib;

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
        private WindowsMediaPlayer ton;

        public Fenster()
        {
            try
            {
                ton = new WindowsMediaPlayer();
                // Gibt Dateipfad an
                ton.URL = "sound.mp3";
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
                // Startet die Wiedergabe
                ton.controls.play();
            }
            catch (Exception f)
            {
                MessageBox.Show("Kann nicht wiedergegeben werden!", "Fehler");
            }
        }
    }
}