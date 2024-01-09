using MB04.HandtaschenBeispiel;
using MB05.HandtaschenBeispiel.Loesung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB05.HandtaschenBeispiel
{
    public partial class Handtaschenverwaltung : Form
    {
        public Handtaschenverwaltung()
        {
            InitializeComponent();
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            new HandtascheController(TxtName.Text,NuDPrice.Text);
        }

        private void Handtaschenverwaltung_Load(object sender, EventArgs e)
        {

        }
    }
}
