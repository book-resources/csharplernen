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
        RadioButton unserRadioButton;
        RadioButton unserRadioButton2;

        public Fenster()
        {
            unserRadioButton = new RadioButton();
            InitRadioButton(unserRadioButton, new Point(10, 10), "Option 1");
            unserRadioButton2 = new RadioButton();
            InitRadioButton(unserRadioButton2, new Point(10, 30), "Option 2");
        }

        // Da wir zwei Objekte haben, werden die Eigenschaften in dieser Methode gesetzt
        public void InitRadioButton(RadioButton button, Point position, string text)
        {
            button.BackColor = Color.Orange;
            button.ForeColor = Color.Black;
            button.AutoSize = true;
            button.Checked = false;
            button.Text = text;
            button.Font = new Font("Arial", 12);
            button.Location = position;
            button.Click += new EventHandler(StatusChanged);
            this.Controls.Add(button);
        }

        public void StatusChanged(object sender, EventArgs e)
        {
            if (unserRadioButton.Checked)
            {
                Console.WriteLine("Erster Button ausgewaehlt!");
            }
            else if (unserRadioButton2.Checked)
            {
                Console.WriteLine("Zweiter Button ausgewaehlt!");
            }
        }
    }
}