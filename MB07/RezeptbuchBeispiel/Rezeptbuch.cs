using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB07.RezeptbuchBeispiel
{
    public partial class Rezeptbuch : Form
    {
        public Rezeptbuch()
        {
            InitializeComponent();
            LstRezepte.DisplayMember = "Name";
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            Rezept r1 = new Rezept();
            r1.Name = TxtName.Text;
            r1.Time = Convert.ToInt32(NumTime.Value);

            bool isEqual = false;
            foreach (Rezept item in LstRezepte.Items)
            {
                if (item.Equals(r1))
                {
                    isEqual = true;
                };
            }

            if (!isEqual)
            {
                LstRezepte.Items.Add(r1);
            }

        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            var r1 = LstRezepte.SelectedItem;
            LstRezepte.Items.Remove(r1);
        }
    }
}
