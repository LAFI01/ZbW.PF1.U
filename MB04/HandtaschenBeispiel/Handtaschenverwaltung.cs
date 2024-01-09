using MB04.HandtaschenBeispiel.Loesung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB04.HandtaschenBeispiel
{
    public partial class Handtaschenverwaltung : Form
    {
        List<Handtasche> handtaschenListe = new List<Handtasche>();
        public Handtaschenverwaltung()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            txtHandtaschenListe.Text = null;
            string name = TxtName.Text;
            decimal price = NuDPrice.Value;

            Handtasche newHandtasche = new Handtasche(name, price);

            if (!HandtascheInList(handtaschenListe, newHandtasche))
            {
                handtaschenListe.Add(newHandtasche);
            }
            foreach (Handtasche handtasche in handtaschenListe)
            {
                txtHandtaschenListe.Text += handtasche.Name + "\t" + handtasche.Price + Environment.NewLine;
            }
        }
        private bool HandtascheInList(List<Handtasche> handtaschenListe, Handtasche handtasche)
        {
            foreach (Handtasche oldHandtasche in handtaschenListe)
            {
                if (oldHandtasche.Name == handtasche.Name)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnEditPrice_Click(object sender, EventArgs e)
        {
            txtHandtaschenListe.Text = null;
            string name = TxtName.Text;
            decimal price = NuDPrice.Value;

            Handtasche newHandtasche = new Handtasche(name, price);

        }
    }
}
