using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB01.InvertWord
{
    public partial class InvertWord : Form
    {
        public InvertWord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = txtInput.Text;
            txtOutput.Text = Switcheroo(word);
        }
        private string Switcheroo(string word)
        {
            //Array chars = word.Split('');
            string invertedWord;
            if(word.Length == 1)
            {
                invertedWord = word;
            }
            else
            {
                string firstChar = word.Substring(0, 1);
                string restWord = Switcheroo(word.Substring(1));
                invertedWord = restWord + firstChar;
            }
            return invertedWord;
        }
    }
}
