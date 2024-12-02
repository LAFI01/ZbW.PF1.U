using System;
using System.Windows.Forms;

namespace MB05.BestimmeMax
{
    public partial class BestimmeMaximum : Form
    {
        //public int _valueA; => wir nutzen nun Methode mit Parameter
        //public int _valueB = 0;

        public BestimmeMaximum()
        {
            InitializeComponent();
        }

        private void CmdMax1_Click(object sender, EventArgs e)
        {
            GetMaximumValue(Convert.ToInt32(TxtValue1.Text), Convert.ToInt32(TxtValue2.Text));
        }

        private void CmdMax2_Click(object sender, EventArgs e)
        {
            int valueA = Convert.ToInt32(TxtValue2.Text);
            int valueB = Convert.ToInt32(TxtValue3.Text);
            GetMaximumValue(valueA, valueB);
        }

        private void CmdMax3_Click(object sender, EventArgs e)
        {
            //int valueA = Convert.ToInt32(TxtValue1.Text);
            //int valueB = Convert.ToInt32(TxtValue3.Text);
            //int resultat = GetMaximumValue(valueA,valueB, h: 44);
            //LblMax.Text = resultat.ToString();

            int num1 = 44;
            int num2 = 20;
            TauscheWert(ref num1, ref num2);
           var num1New = num1; //20
            var num2New = num2; //44
        }

        private void TauscheWert(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }


        public int GetMaximumValue(int valueA, int valueB, int c =55 ,int h = 0)
        {
            //int resultat = 0;
            if (valueA > valueB)
            {
                return valueA;
            }
            else
            {
                return valueB;
            }
            // return resultat;

            //Variante 3:
          //  return valueA > valueB ? valueA : valueB;

        }


    }
}