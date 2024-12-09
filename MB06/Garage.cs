using MB06.Adressverwaltung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB06
{
    public partial class Garage : Form
    {
        public Garage()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            BicycleV2 b3 = new BicycleV2();

            if (TxtColor.Text.Equals("Blau"))
            {
                b3.Color = Color.Blue;
                P
            }
            LblShow.Text=  b3.Print();


            var weight = Convert.ToInt32(NumWeight.Value);
            Bicycle b2 = new Bicycle(weight, TxtColor.Text);
            

            Bicycle b1 = new Bicycle(10);
            b1.SetWeight(Convert.ToInt32(NumWeight.Value));
            b1.Weight = 15;
            var res = b1.Weight;
            string resultat = b1.Print();
            LblShow.Text = resultat;
        }
    }
}
