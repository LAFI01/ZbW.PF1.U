using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MB04.Hund
{
    public partial class DogView : Form
    {
        List<Dog> dogList = new List<Dog>();
        public DogView()
        {
            InitializeComponent();
        }

        private void DogView_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtDogName.Text;
            int age = Convert.ToInt32(txtDogAge.Text);
            Dog newDog = new Dog(name, age);

            if(!DogInList(dogList, newDog))
            {
                dogList.Add(newDog);
            }
            MessageBox.Show(Convert.ToString(dogList));
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string nameBall = txtBallName.Text;
            Ball ball = new Ball(nameBall);
            var dog1 = new Dog();

            var resultat = dog1.PlayBall(ball);
            MessageBox.Show(resultat);
        }

        private bool DogInList(List<Dog> dogList, Dog newDog)
        {
            foreach (Dog oldDog in  dogList) 
            {
                if(dogExists(oldDog, newDog))
                {
                    return true;
                }
            }
            return false;
        }

        private bool dogExists(Dog oldDog, Dog newDog)
        {
            string oldDogName = oldDog.Name;
            int oldDogAge = oldDog.Age;

            string newDogName = newDog.Name;
            int newDogAge = newDog.Age;

            if (oldDogName == newDogName) 
            { 
                return true; 
            }
            else 
            {
                return false; 
            }
            if (oldDogAge == newDogAge) 
            { 
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
