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
    public partial class MediumView : Form
    {
        public MediumView()
        {
            InitializeComponent();
        }

        public List<Cd> cds = new List<Cd>();
        public List<Dvd> dvds = new List<Dvd>();

        public List<Medium> medium = new List<Medium>();


        private void CmdAdd_Click(object sender, EventArgs e)
        {
            var cd1 = new Cd("title");
            var dvd1 = new Dvd("title");

            medium.Add(cd1);
            medium.Add(dvd1);

            Medium medium1 = medium[0];

            var isCd = medium[0] is Cd;
            Cd cdgecast = (Cd)medium[0];


        }
    }
}
