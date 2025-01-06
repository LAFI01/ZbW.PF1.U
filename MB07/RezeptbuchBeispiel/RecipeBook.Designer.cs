namespace MB07.RezeptbuchBeispiel
{
    partial class RecipeBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtRecipeName = new TextBox();
            TxtInstruction = new TextBox();
            label1 = new Label();
            label2 = new Label();
            NudDuration = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            LstRecipes = new ListBox();
            label6 = new Label();
            CmdRecipeDelete = new Button();
            CmdAddRecipe = new Button();
            ((System.ComponentModel.ISupportInitialize)NudDuration).BeginInit();
            SuspendLayout();
            // 
            // TxtRecipeName
            // 
            TxtRecipeName.Location = new Point(104, 61);
            TxtRecipeName.Name = "TxtRecipeName";
            TxtRecipeName.Size = new Size(189, 23);
            TxtRecipeName.TabIndex = 0;
            // 
            // TxtInstruction
            // 
            TxtInstruction.Location = new Point(104, 139);
            TxtInstruction.Multiline = true;
            TxtInstruction.Name = "TxtInstruction";
            TxtInstruction.Size = new Size(189, 270);
            TxtInstruction.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 64);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 2;
            label1.Text = "Rezeptname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 142);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "Anleitung";
            // 
            // NudDuration
            // 
            NudDuration.Location = new Point(104, 99);
            NudDuration.Name = "NudDuration";
            NudDuration.Size = new Size(189, 23);
            NudDuration.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 101);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 5;
            label3.Text = "Zeitaufwand";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(354, 9);
            label4.Name = "label4";
            label4.Size = new Size(200, 30);
            label4.TabIndex = 6;
            label4.Text = "Alle meine Rezepte";
            // 
            // LstRecipes
            // 
            LstRecipes.FormattingEnabled = true;
            LstRecipes.ItemHeight = 15;
            LstRecipes.Location = new Point(354, 56);
            LstRecipes.Name = "LstRecipes";
            LstRecipes.Size = new Size(200, 349);
            LstRecipes.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(104, 9);
            label6.Name = "label6";
            label6.Size = new Size(189, 30);
            label6.TabIndex = 9;
            label6.Text = "Erfasse ein Rezept";
            // 
            // CmdRecipeDelete
            // 
            CmdRecipeDelete.Location = new Point(354, 428);
            CmdRecipeDelete.Name = "CmdRecipeDelete";
            CmdRecipeDelete.Size = new Size(200, 23);
            CmdRecipeDelete.TabIndex = 10;
            CmdRecipeDelete.Text = "Rezept löschen";
            CmdRecipeDelete.UseVisualStyleBackColor = true;
            CmdRecipeDelete.Click += CmdRecipeDelete_Click;
            // 
            // CmdAddRecipe
            // 
            CmdAddRecipe.Location = new Point(103, 428);
            CmdAddRecipe.Name = "CmdAddRecipe";
            CmdAddRecipe.Size = new Size(190, 23);
            CmdAddRecipe.TabIndex = 11;
            CmdAddRecipe.Text = "Rezept hinzufügen";
            CmdAddRecipe.UseVisualStyleBackColor = true;
            CmdAddRecipe.Click += CmdAddRecipe_Click;
            // 
            // RecipeBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 482);
            Controls.Add(CmdAddRecipe);
            Controls.Add(CmdRecipeDelete);
            Controls.Add(label6);
            Controls.Add(LstRecipes);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(NudDuration);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtInstruction);
            Controls.Add(TxtRecipeName);
            Name = "RecipeBook";
            Text = "RecipeBook";
            ((System.ComponentModel.ISupportInitialize)NudDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtRecipeName;
        private TextBox TxtInstruction;
        private Label label1;
        private Label label2;
        private NumericUpDown NudDuration;
        private Label label3;
        private Label label4;
        private ListBox LstRecipes;
        private Label label6;
        private Button CmdRecipeDelete;
        private Button CmdAddRecipe;
    }
}