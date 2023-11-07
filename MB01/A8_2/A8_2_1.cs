using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace MB01.A8_2
{
    public partial class A8_2_1 : Form
    {
        public A8_2_1()
        {
            InitializeComponent();
        }

        private void CmdCalculate_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToInt32(TxtValue1.Text);
            double num2 = Convert.ToInt32(TxtValue2.Text);
            double Result = 0;

            if (RadbAdd.Checked)
            {
                Result = num1 + num2;
            }else if(RadbSub.Checked)
            {
                Result = num1 - num2;
            }
            else if (RadbMul.Checked)
            {
                Result = num1 * num2;
            }
            else if (RadbDiv.Checked)
            {
                Result = num1 / num2;
            }
            Text = Result.ToString();
            TxtResult.Text = Text;

        }
    }
}