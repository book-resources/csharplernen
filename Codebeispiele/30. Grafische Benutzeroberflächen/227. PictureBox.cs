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
            // Neues PictureBox Objekt erzeugen
            PictureBox bild = new PictureBox();
            // Pfad des Bildes angeben
            bild.ImageLocation = "apfel.jpg";
            // Groesse automatisch anpassen lassen
            bild.SizeMode = PictureBoxSizeMode.AutoSize;
            // Position setzen
            bild.Location = new Point(0, 0);

            this.Controls.Add(bild);
        }
    }
}