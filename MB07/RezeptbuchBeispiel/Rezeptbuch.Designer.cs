namespace MB07.RezeptbuchBeispiel
{
    partial class Rezeptbuch
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
            CmdAdd = new Button();
            TxtName = new TextBox();
            NumTime = new NumericUpDown();
            LstRezepte = new ListBox();
            CmdDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)NumTime).BeginInit();
            SuspendLayout();
            // 
            // CmdAdd
            // 
            CmdAdd.Location = new Point(122, 167);
            CmdAdd.Name = "CmdAdd";
            CmdAdd.Size = new Size(112, 34);
            CmdAdd.TabIndex = 0;
            CmdAdd.Text = "Hinzufügen";
            CmdAdd.UseVisualStyleBackColor = true;
            CmdAdd.Click += CmdAdd_Click;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(124, 56);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(150, 31);
            TxtName.TabIndex = 1;
            // 
            // NumTime
            // 
            NumTime.Location = new Point(122, 112);
            NumTime.Name = "NumTime";
            NumTime.Size = new Size(180, 31);
            NumTime.TabIndex = 2;
            // 
            // LstRezepte
            // 
            LstRezepte.FormattingEnabled = true;
            LstRezepte.ItemHeight = 25;
            LstRezepte.Location = new Point(456, 43);
            LstRezepte.Name = "LstRezepte";
            LstRezepte.Size = new Size(180, 129);
            LstRezepte.TabIndex = 3;
            // 
            // CmdDelete
            // 
            CmdDelete.Location = new Point(457, 190);
            CmdDelete.Name = "CmdDelete";
            CmdDelete.Size = new Size(112, 34);
            CmdDelete.TabIndex = 4;
            CmdDelete.Text = "Löschen";
            CmdDelete.UseVisualStyleBackColor = true;
            CmdDelete.Click += CmdDelete_Click;
            // 
            // Rezeptbuch
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdDelete);
            Controls.Add(LstRezepte);
            Controls.Add(NumTime);
            Controls.Add(TxtName);
            Controls.Add(CmdAdd);
            Name = "Rezeptbuch";
            Text = "Rezeptbuch";
            ((System.ComponentModel.ISupportInitialize)NumTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAdd;
        private TextBox TxtName;
        private NumericUpDown NumTime;
        private ListBox LstRezepte;
        private Button CmdDelete;
    }
}