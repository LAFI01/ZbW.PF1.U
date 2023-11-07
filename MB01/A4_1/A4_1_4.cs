using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB01.A8_2
{
    public partial class A4_1_4 : Form
    {
        public A4_1_4()
        {
            InitializeComponent();
        }

        private void CmdCheck_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(TxtValue1.Text);
            int num2 = Convert.ToInt32(TxtValue2.Text);

            if (num1 > num2)
            {
                LblResult.Text = "die erste Zahl ist grösser";
            }
            else if (num2 > num1)
            {

                LblResult.Text = "die zweite Zahl ist grösser";
            }
            else {
                LblResult.Text = "die Zahlen sind gleich gross";
            }            
        }
    }
}
