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
        /* Variable hier deklariert, damit wir in der Methode darauf zugreifen koennen
         * (waere sie im Konstruktor deklariert worden, so waere sie nur von dort aus
         * erreichbar, d.h. eine lokale Variable; nun ist sie eine globale Variable) 
         */ 
        TextBox unsereTextBox;

        public Fenster()
        {
            unsereTextBox = new TextBox();
            unsereTextBox.Text = "Vordefinierter Text";
            unsereTextBox.Location = new Point(10, 10);
            unsereTextBox.ForeColor = Color.Blue;
            unsereTextBox.TextChanged += new EventHandler(GetInput);
            unsereTextBox.AutoSize = true;
            this.Controls.Add(unsereTextBox);
        }

        public void GetInput(object sender, EventArgs e)
        {
            Console.WriteLine("Der eingegebene Text lautet: {0}", unsereTextBox.Text);
        }
    }
}