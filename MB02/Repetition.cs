using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB02
{
    public partial class Repetition : Form
    {
        public Repetition()
        {
            InitializeComponent();
        }

        private int _sec = 0;

        private void BtnOutput_Click(object sender, EventArgs e)
        {
            string value = string.Empty;

            if (RadFrau.Checked)
            {
                value = "Frau";
            }
            else
            {
                value = "Herr";
            }
            value += " " + textBox1.Text;

            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblSecShow.Text = _sec++.ToString();
        }
    }
}
