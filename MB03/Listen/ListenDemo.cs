using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MB03.Listen
{
    public partial class ListenDemo : Form
    {
        public ListenDemo()
        {
            InitializeComponent();
        }


        // Beispielhafte Werte in die ComboBox hinzufügen
        comboEintrag.Items.Add("Wert 1");
        comboEintrag.Items.Add("Wert 2");
        comboEintrag.Items.Add("Wert 3");
        private void btnHinzufuegen_Click(object sender, EventArgs e)
        {
            // Überprüfen, ob ein Wert ausgewählt ist
            if (comboBox1.SelectedItem != null)
            {
                // Aktuell ausgewählten Wert der Liste hinzufügen
                gespeicherteWerte.Add(comboBox1.SelectedItem.ToString());
                MessageBox.Show("Wert hinzugefügt: " + comboBox1.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen Wert aus.");
            }
        }

        private void comboEintrag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
