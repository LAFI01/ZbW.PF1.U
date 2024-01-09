namespace MB06.Person_static
{
    partial class CreatePerson
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnCreatePerson = new Button();
            TxtFirstname = new TextBox();
            TxtAge = new TextBox();
            TxtName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 41);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Vorname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 86);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Nachname";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 138);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Alter";
            // 
            // BtnCreatePerson
            // 
            BtnCreatePerson.Location = new Point(248, 191);
            BtnCreatePerson.Name = "BtnCreatePerson";
            BtnCreatePerson.Size = new Size(125, 29);
            BtnCreatePerson.TabIndex = 3;
            BtnCreatePerson.Text = "Create Person";
            BtnCreatePerson.UseVisualStyleBackColor = true;
            BtnCreatePerson.Click += BtnCreatePerson_Click;
            // 
            // TxtFirstname
            // 
            TxtFirstname.Location = new Point(248, 41);
            TxtFirstname.Name = "TxtFirstname";
            TxtFirstname.Size = new Size(125, 27);
            TxtFirstname.TabIndex = 4;
            // 
            // TxtAge
            // 
            TxtAge.Location = new Point(248, 138);
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(125, 27);
            TxtAge.TabIndex = 5;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(248, 86);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(125, 27);
            TxtName.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtName);
            Controls.Add(TxtAge);
            Controls.Add(TxtFirstname);
            Controls.Add(BtnCreatePerson);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnCreatePerson;
        private TextBox TxtFirstname;
        private TextBox TxtAge;
        private TextBox TxtName;
    }
}