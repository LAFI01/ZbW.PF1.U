
using System;

namespace MB03.Schleifen
{
    public partial class SchleifenDemo : Form
    {
        public SchleifenDemo()
        {
            InitializeComponent();
        }

       

        private void CmdFor_Click(object sender, EventArgs e)
        {
            int AnzahlZahlen = 5;
            var Random1 = new Random();
            TxtShow.Text = ""; // Textfeld leeren, bevor wir neue Zahlen hinzufügen

            for (int i = 0; i < AnzahlZahlen; i++)
            {
                int Zufallszahl = Random1.Next(1, 100); // Neue Zufallszahl generieren
                TxtShow.Text += Zufallszahl.ToString() + Environment.NewLine;
            }
        }

        private void CmdWhile_Click(object sender, EventArgs e)
        {
            int AnzahlZahlen = 5;
            var Random1 = new Random();
            TxtShow.Text = ""; // Textfeld leeren, bevor wir neue Zahlen hinzufügen

            int i = 0;
            while (i < AnzahlZahlen)
            {
                int Zufallszahl = Random1.Next(1, 100); // Neue Zufallszahl generieren
                TxtShow.Text += Zufallszahl.ToString() + Environment.NewLine;
                i++;
            }
        }

        private void CmdDoWhile_Click(object sender, EventArgs e)
        {
            int AnzahlZahlen = 5;
            var Random1 = new Random();
            TxtShow.Text = ""; // Textfeld leeren, bevor wir neue Zahlen hinzufügen

            int i = 0;
            do
            {
                int Zufallszahl = Random1.Next(1, 100); // Neue Zufallszahl generieren
                TxtShow.Text += Zufallszahl.ToString() + Environment.NewLine;
                i++;
            } while (i < AnzahlZahlen);
        }
    }
}
