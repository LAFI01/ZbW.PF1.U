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
            try
            {
                Convert.ToSByte(TxtValue1.Text);
                Convert.ToSByte(TxtValue2.Text);

                double num1 = Convert.ToDouble(TxtValue1.Text);
                double num2 = Convert.ToDouble(TxtValue2.Text);

                double Result = 0;
                if (RadbAdd.Checked)
                {
                    Result = num1 + num2;
                }
                else if (RadbSub.Checked)
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
                else
                {
                    MessageBox.Show("please pick an operator", "no operator");
                    return;
                }
                Text = Result.ToString();
                TxtResult.Text = Text;
                if(Result == 69)
                {
                    MessageBox.Show("nice", "nice");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Please use sbytes in fields 1 and 2, so a number from -127 to 128", "value out of bound");
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Please use sbytes in fields 1 and 2, so a number from -127 to 128", "value out of bound");
            }
            catch (System.DivideByZeroException)
            {
                MessageBox.Show("can't divide by 0 moron", "u stupid");
            }
            catch
            {
                MessageBox.Show("dunno man", "500 i guess");
            }

        }
    }
}