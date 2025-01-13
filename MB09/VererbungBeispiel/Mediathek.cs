using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB09.VererbungBeispiel
{
    public partial class Mediathek : Form
    {
        public Mediathek()
        {
            InitializeComponent();
        }

        public List<Dvd> Dvds = new List<Dvd>();
        public List<Cd> Cds = new List<Cd>();

        public List<Medium> Medium = new List<Medium>();

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            Dvd d1 = new Dvd("Harry", "XY");
            Cd cd1 = new Cd("Britney");

            Medium.Add(cd1);
            Medium.Add(d1);

            foreach (Medium m in Medium)
            {
                if (m is Cd)
                {

                }
            }

            Medium m1 = new Medium("Ringe");

            m1 = d1;

            Dvd d2 = (Dvd)m1;

            m1.Print();
            d1.Print();

            object obj = new object();

        }
    }
}
