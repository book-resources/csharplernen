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
        TextBox unsereTextBox;

        public Fenster()
        {
            unsereTextBox = new TextBox();
            unsereTextBox.Text = "Vordefinierter Text";
            unsereTextBox.Location = new Point(10, 10);
            unsereTextBox.ForeColor = Color.Blue;
            unsereTextBox.AutoSize = true;
            this.Controls.Add(unsereTextBox);

            Button unserButton = new Button();
            unserButton.Text = "Eingabe bestaetigen";
            unserButton.AutoSize = true;
            unserButton.Location = new Point(10, 40);
            unserButton.MouseClick += new MouseEventHandler(ButtonPressed);
            this.Controls.Add(unserButton);

            this.AutoSize = true;
        }

        public void ButtonPressed(object sender, EventArgs e)
        {
            Console.WriteLine("Der eingegebene Text lautet: {0}", unsereTextBox.Text);
        }
    }
}