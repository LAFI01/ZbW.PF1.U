using MB06.Haustierverwaltung_1.Loesung;

namespace MB06.Haustierverwaltung_1
{
    public partial class Haustierverwaltung1 : Form
    {

        public Haustierverwaltung1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            int age = Convert.ToInt16(NumAge.Value);
            bool isCat = RadCat.Checked;
            bool isDog = RadDog.Checked;

            if (isCat)
            {
                Cat cat = new Cat(name,age);
            }
            else if (isDog)
            {
                Dog dog = new Dog(name,age);
            }

            LblNumberOfPets.Text = Convert.ToString(Pet.Count);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}