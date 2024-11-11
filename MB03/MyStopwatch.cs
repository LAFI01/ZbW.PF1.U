using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB03
{
    public partial class MyStopwatch : Form
    {
        public MyStopwatch()
        {
            InitializeComponent();
        }

        private async void BtnStart_Click(object sender, EventArgs e)
        {
            int rounds = 100;
            Random random = new Random();
            rounds = random.Next(10, 100);

            for (int i = 0; i < rounds; i++)
            {
                LblCounter.Text =  i.ToString();

                // Wartet 100 Millisekunden, ohne die UI zu blockieren => weil so wird dsa Label nicht während des Schleifenprozesses blockeirt
                await Task.Delay(100);
            }
        }

        private void MyStopwatch_Load(object sender, EventArgs e)
        {
            MyList.Items.Add("ohla");
            int anzahlElemente = MyList.Items.Count;
            var mySelectedValue = MyList.SelectedItem;

            MyCombobox.Items.Add("Hallo");
            MyCombobox.Items.Add("Hallo2");

        }
    }
}
