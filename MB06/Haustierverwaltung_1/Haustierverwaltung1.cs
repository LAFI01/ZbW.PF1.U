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
            bool cat = RadCat.Checked;
            bool dog = RadDog.Checked;

            Pet pet = new Pet(name, age, cat, dog);

            LblNumberOfPets.Text = Convert.ToString(Pet.Count);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}