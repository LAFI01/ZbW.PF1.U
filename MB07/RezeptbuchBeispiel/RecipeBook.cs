using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB07.RezeptbuchBeispiel
{
    public partial class RecipeBook : Form
    {

        public RecipeBook()
        {
            InitializeComponent();
            LstRecipes.DisplayMember = "Name";
        }

        private void CmdAddRecipe_Click(object sender, EventArgs e)
        {
            var r = new Recipe();
            r.Name = TxtRecipeName.Text;
            r.Instruction = TxtInstruction.Text;
            r.Duration = Convert.ToInt32(NudDuration.Value);
            LstRecipes.Items.Add(r);

            Button addButton = (Button)sender;
            addButton.BackColor = Color.Red;
        }

        private void CmdRecipeDelete_Click(object sender, EventArgs e)
        {
            if (LstRecipes.SelectedItem != null)
            {
                LstRecipes.Items.Remove(LstRecipes.SelectedItem);
            }
        }
    }
}
