namespace MB06.Haustierverwaltung_2
{
    using MB06.Haustierverwaltung_2.Loesung;

    public partial class Haustierverwaltung2 : Form
    {

        public Haustierverwaltung2()
        {
            InitializeComponent();
        }

        private void BtnAllPlay_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Pet.ListToString());
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            int age = Convert.ToInt16(NumAge.Value);
            bool isCat = RadCat.Checked;
            bool isDog = RadDog.Checked;

            TxtOutput.Text = "";
            if (isCat)
            {
                Cat cat = new Cat(name, age);
            }
            else if (isDog)
            {
                Dog dog = new Dog(name, age);
            }
            LblNumberOfPets.Text = Convert.ToString(Pet.Count);
        }

        private void BtnTesting_Click(object sender, EventArgs e)
        {
            new Cat("Chili", 2);
            new Cat("Bailey", 2);
            new Dog("Bonito", 8);
            new Dog("Fidough", 1);
            new Dog("Idefix", 89);
            LblNumberOfPets.Text = Convert.ToString(Pet.Count);
        }
    }
}