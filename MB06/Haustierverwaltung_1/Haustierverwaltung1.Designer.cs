namespace MB06.Haustierverwaltung_1
{
    partial class Haustierverwaltung1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnAdd = new Button();
            LblName = new Label();
            LblAlter = new Label();
            TxtName = new TextBox();
            NumAge = new NumericUpDown();
            label3 = new Label();
            LblNumberOfPets = new Label();
            RadCat = new RadioButton();
            RadDog = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)NumAge).BeginInit();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(80, 141);
            BtnAdd.Margin = new Padding(3, 4, 3, 4);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(137, 31);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "Erfassen";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(14, 64);
            LblName.Name = "LblName";
            LblName.Size = new Size(49, 20);
            LblName.TabIndex = 1;
            LblName.Text = "Name";
            // 
            // LblAlter
            // 
            LblAlter.AutoSize = true;
            LblAlter.Location = new Point(14, 103);
            LblAlter.Name = "LblAlter";
            LblAlter.Size = new Size(41, 20);
            LblAlter.TabIndex = 2;
            LblAlter.Text = "Alter";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(80, 60);
            TxtName.Margin = new Padding(3, 4, 3, 4);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(137, 27);
            TxtName.TabIndex = 3;
            // 
            // NumAge
            // 
            NumAge.Location = new Point(80, 103);
            NumAge.Margin = new Padding(3, 4, 3, 4);
            NumAge.Name = "NumAge";
            NumAge.Size = new Size(137, 27);
            NumAge.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 29);
            label3.Name = "label3";
            label3.Size = new Size(185, 20);
            label3.TabIndex = 5;
            label3.Text = "Anzahl aktueller Haustiere:";
            label3.Click += label3_Click;
            // 
            // LblNumberOfPets
            // 
            LblNumberOfPets.AutoSize = true;
            LblNumberOfPets.Location = new Point(474, 29);
            LblNumberOfPets.Name = "LblNumberOfPets";
            LblNumberOfPets.Size = new Size(17, 20);
            LblNumberOfPets.TabIndex = 6;
            LblNumberOfPets.Text = "0";
            // 
            // RadCat
            // 
            RadCat.AutoSize = true;
            RadCat.Location = new Point(157, 16);
            RadCat.Margin = new Padding(3, 4, 3, 4);
            RadCat.Name = "RadCat";
            RadCat.Size = new Size(67, 24);
            RadCat.TabIndex = 7;
            RadCat.TabStop = true;
            RadCat.Text = "Katze";
            RadCat.UseVisualStyleBackColor = true;
            // 
            // RadDog
            // 
            RadDog.AutoSize = true;
            RadDog.Location = new Point(80, 16);
            RadDog.Margin = new Padding(3, 4, 3, 4);
            RadDog.Name = "RadDog";
            RadDog.Size = new Size(66, 24);
            RadDog.TabIndex = 8;
            RadDog.TabStop = true;
            RadDog.Text = "Hund";
            RadDog.UseVisualStyleBackColor = true;
            // 
            // Haustierverwaltung1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 200);
            Controls.Add(RadDog);
            Controls.Add(RadCat);
            Controls.Add(LblNumberOfPets);
            Controls.Add(label3);
            Controls.Add(NumAge);
            Controls.Add(TxtName);
            Controls.Add(LblAlter);
            Controls.Add(LblName);
            Controls.Add(BtnAdd);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Haustierverwaltung1";
            Text = "Haustierverwaltung";
            ((System.ComponentModel.ISupportInitialize)NumAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAdd;
        private Label LblName;
        private Label LblAlter;
        private TextBox TxtName;
        private NumericUpDown NumAge;
        private Label label3;
        private Label LblNumberOfPets;
        private RadioButton RadCat;
        private RadioButton RadDog;
    }
}