namespace MB02
{
    public partial class Stromverbrauch : Form
    {
        public Stromverbrauch()
        {
            InitializeComponent();
        }

        private void ButtonBerechnen_Click(object sender, EventArgs e)
        {
            // Eingabe von NumericUpDown-Steuerelement
            double kWh = (double)StromWert.Value;
            double kosten = 0;


            // Überprüfung, ob kWh grösser als 0 ist
            if (kWh == 0)
            {
                MessageBox.Show("Der Wert muss höher sein als 0", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Preisberechnung je nach Verbrauch
            if (Feiertag.Checked == true)
            {
                kosten = kWh * 0.10;
                AusgabeRechnung.BackColor = System.Drawing.Color.Red;
            }
            else if (kWh <= 250)
            {
                kosten = kWh * 0.15;
            }
            else if (kWh <= 500)
            {
                kosten = kWh * 0.12;
            }
            else
            {
                kosten = kWh * 0.11;
            }

            /*
             * 
             * Mit SwitchCase
             * 
            kosten = kWh switch
            {
                <= 250 => kWh * 0.15,
                <= 500 => kWh * 0.12,
                _ => kWh * 0.11
            };
            */

            // Ausgabe in gewünschtem Format
            AusgabeRechnung.Text = $"Kosten: {kosten:F2} Fr. für {kWh} kWh";
        
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TabBar.Value = (int)StromWert.Value;
        }

        private void TabBar_Scroll(object sender, EventArgs e)
        {
            StromWert.Value = TabBar.Value;
        }

        private void Feiertag_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
