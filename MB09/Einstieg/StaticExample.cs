using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB09.Einstieg
{
    public partial class StaticExample : Form
    {
        public StaticExample()
        {
            InitializeComponent();
        }

        private void CmdCreatePerson_Click(object sender, EventArgs e)
        {
            Person person = new ();
            LblShow.Text = Person.Counter.ToString();
        }
    }
}
