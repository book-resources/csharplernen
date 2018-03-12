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
            unserButton.Text = "Beenden";
            unserButton.AutoSize = true;
            unserButton.Location = new Point(10, 40);
            unserButton.MouseClick += new MouseEventHandler(ButtonPressed);
            this.Controls.Add(unserButton);

            this.AutoSize = true;
        }
        public void ButtonPressed(object sender, EventArgs e)
        {
            // Beim Klicken auf "Ja" wird das Programm beendet
            if (MessageBox.Show("Wirklich beenden?", "Achtung", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                Application.Exit(); // Beendet die Anwendung
            }
        }
    }
}