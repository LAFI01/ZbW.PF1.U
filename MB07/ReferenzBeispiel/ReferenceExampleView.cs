namespace MB07.ReferenzBeispiel
{
    public partial class ReferenceExampleView : Form
    {
        public ReferenceExampleView()
        {
            InitializeComponent();
            BtnCheck.BackColor = Color.Blue;
        }

        private void ClickOnBtnCheck(object sender, EventArgs e)
        {
            var personA = new Person(TxtPersonA.Text);
            var personB = new Person(TxtPersonB.Text);

            LblResponseEvenSign.Text = personA.CompareWithEvenSign(personB).ToString();

            var isEqual = personA.Equals(personB);
            LblResponseEquals.Text = isEqual.ToString();
        }
 
    }
}
