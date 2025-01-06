using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB01
{
    public partial class Uebung2 : Form
    {
        public Uebung2()
        {
            InitializeComponent();
        }

        private int _counterStrike = 0;

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {
            NumLetterCounter.Value = TxtInput.Text.Length;
            
            int localVariable = Convert.ToInt32(NumLetterCounter.Value);
            localVariable = 12; 
        }

        private void CmdOutput_Click(object sender, EventArgs e)
        {
            LblShow.Text = $"Anzahl Buchstaben: {NumLetterCounter.Value}";
           string  localVariable = "12";
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            TxtInput.Text = ""; // ist das gleiche => string.Empty ; 
            NumLetterCounter.Value = _counterStrike;
        }
    }
}
