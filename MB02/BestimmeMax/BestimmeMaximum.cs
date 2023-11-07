using System;
using System.Windows.Forms;

namespace MB02.BestimmeMax
{
    public partial class BestimmeMaximum : Form
    {
        int num1;
        int num2;
        int result;

        public BestimmeMaximum()
        {
            InitializeComponent();
        }

        private void CmdMax1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt16(TxtValue1.Text);
            num2 = Convert.ToInt16(TxtValue2.Text);
            WriteBiggerNumber(num1, num2);
        }

        private void CmdMax2_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt16(TxtValue2.Text);
            num2 = Convert.ToInt16(TxtValue3.Text);
            WriteBiggerNumber(num1, num2);

        }

        private void CmdMax3_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt16(TxtValue1.Text);
            num2 = Convert.ToInt16(TxtValue3.Text);
            WriteBiggerNumber(num1, num2);
        }
        private int BiggerNumber(int num1, int num2)
        {
            if (num1 >= num2)
            {
                return num1;
            }
            else if (num1 <= num2)
            {
                return num2;
            }
            return 0;
        }
        private void WriteBiggerNumber(int num1, int num2)
        {
            result = BiggerNumber(num1, num2);
            LblMax.Text = result.ToString();
        }
    }
}