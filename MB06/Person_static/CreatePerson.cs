using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB06.Person_static
{
    public partial class CreatePerson : Form
    {
        public CreatePerson()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreatePerson_Click(object sender, EventArgs e)
        {
            string firstname = TxtFirstname.Text;
            string name = TxtName.Text;
            int age = Convert.ToInt32(TxtAge.Text);

            Person newPerson = new Person(firstname, name, age);

            MessageBox.Show(Convert.ToString(Person.Id));
        }
    }
}
