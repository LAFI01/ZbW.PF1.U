namespace MB06.Haustierverwaltung_2
{
    partial class Haustierverwaltung2
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
            RadDog = new RadioButton();
            RadCat = new RadioButton();
            BtnAllPlay = new Button();
            TxtOutput = new TextBox();
            BtnTesting = new Button();
            ((System.ComponentModel.ISupportInitialize)NumAge).BeginInit();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(76, 98);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(120, 23);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "Erfassen";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(18, 40);
            LblName.Name = "LblName";
            LblName.Size = new Size(39, 15);
            LblName.TabIndex = 1;
            LblName.Text = "Name";
            // 
            // LblAlter
            // 
            LblAlter.AutoSize = true;
            LblAlter.Location = new Point(18, 69);
            LblAlter.Name = "LblAlter";
            LblAlter.Size = new Size(32, 15);
            LblAlter.TabIndex = 2;
            LblAlter.Text = "Alter";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(76, 37);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(120, 23);
            TxtName.TabIndex = 3;
            // 
            // NumAge
            // 
            NumAge.Location = new Point(76, 69);
            NumAge.Name = "NumAge";
            NumAge.Size = new Size(120, 23);
            NumAge.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(265, 22);
            label3.Name = "label3";
            label3.Size = new Size(147, 15);
            label3.TabIndex = 5;
            label3.Text = "Anzahl aktueller Haustiere:";
            // 
            // LblNumberOfPets
            // 
            LblNumberOfPets.AutoSize = true;
            LblNumberOfPets.Location = new Point(415, 22);
            LblNumberOfPets.Name = "LblNumberOfPets";
            LblNumberOfPets.Size = new Size(13, 15);
            LblNumberOfPets.TabIndex = 6;
            LblNumberOfPets.Text = "0";
            // 
            // RadDog
            // 
            RadDog.AutoSize = true;
            RadDog.Location = new Point(76, 12);
            RadDog.Name = "RadDog";
            RadDog.Size = new Size(55, 19);
            RadDog.TabIndex = 10;
            RadDog.TabStop = true;
            RadDog.Text = "Hund";
            RadDog.UseVisualStyleBackColor = true;
            // 
            // RadCat
            // 
            RadCat.AutoSize = true;
            RadCat.Location = new Point(143, 12);
            RadCat.Name = "RadCat";
            RadCat.Size = new Size(53, 19);
            RadCat.TabIndex = 9;
            RadCat.TabStop = true;
            RadCat.Text = "Katze";
            RadCat.UseVisualStyleBackColor = true;
            // 
            // BtnAllPlay
            // 
            BtnAllPlay.Location = new Point(265, 98);
            BtnAllPlay.Name = "BtnAllPlay";
            BtnAllPlay.Size = new Size(163, 23);
            BtnAllPlay.TabIndex = 11;
            BtnAllPlay.Text = "Alle Spielen";
            BtnAllPlay.UseVisualStyleBackColor = true;
            BtnAllPlay.Click += BtnAllPlay_Click;
            // 
            // TxtOutput
            // 
            TxtOutput.Location = new Point(76, 169);
            TxtOutput.Multiline = true;
            TxtOutput.Name = "TxtOutput";
            TxtOutput.Size = new Size(352, 198);
            TxtOutput.TabIndex = 12;
            // 
            // BtnTesting
            // 
            BtnTesting.Location = new Point(76, 140);
            BtnTesting.Name = "BtnTesting";
            BtnTesting.Size = new Size(120, 23);
            BtnTesting.TabIndex = 13;
            BtnTesting.Text = "Testing";
            BtnTesting.UseVisualStyleBackColor = true;
            BtnTesting.Click += BtnTesting_Click;
            // 
            // Haustierverwaltung2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 412);
            Controls.Add(BtnTesting);
            Controls.Add(TxtOutput);
            Controls.Add(BtnAllPlay);
            Controls.Add(RadDog);
            Controls.Add(RadCat);
            Controls.Add(LblNumberOfPets);
            Controls.Add(label3);
            Controls.Add(NumAge);
            Controls.Add(TxtName);
            Controls.Add(LblAlter);
            Controls.Add(LblName);
            Controls.Add(BtnAdd);
            Name = "Haustierverwaltung2";
            StartPosition = FormStartPosition.CenterScreen;
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
        private RadioButton RadDog;
        private RadioButton RadCat;
        private Button BtnAllPlay;
        private TextBox TxtOutput;
        private Button BtnTesting;
    }
}