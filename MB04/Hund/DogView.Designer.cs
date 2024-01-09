namespace MB04.Hund
{
    partial class DogView
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
            btnCreate = new Button();
            txtDogName = new TextBox();
            txtDogAge = new TextBox();
            lblDogName = new Label();
            lblDogAge = new Label();
            btnPlay = new Button();
            txtBallName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(148, 149);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(125, 33);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create Dog";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtDogName
            // 
            txtDogName.Location = new Point(148, 66);
            txtDogName.Name = "txtDogName";
            txtDogName.Size = new Size(125, 27);
            txtDogName.TabIndex = 1;
            // 
            // txtDogAge
            // 
            txtDogAge.Location = new Point(148, 99);
            txtDogAge.Name = "txtDogAge";
            txtDogAge.Size = new Size(125, 27);
            txtDogAge.TabIndex = 2;
            // 
            // lblDogName
            // 
            lblDogName.AutoSize = true;
            lblDogName.Location = new Point(27, 69);
            lblDogName.Name = "lblDogName";
            lblDogName.Size = new Size(82, 20);
            lblDogName.TabIndex = 3;
            lblDogName.Text = "Dog Name";
            // 
            // lblDogAge
            // 
            lblDogAge.AutoSize = true;
            lblDogAge.Location = new Point(27, 102);
            lblDogAge.Name = "lblDogAge";
            lblDogAge.Size = new Size(69, 20);
            lblDogAge.TabIndex = 4;
            lblDogAge.Text = "Dog Age";
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(514, 149);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(94, 29);
            btnPlay.TabIndex = 5;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // txtBallName
            // 
            txtBallName.Location = new Point(483, 59);
            txtBallName.Name = "txtBallName";
            txtBallName.Size = new Size(125, 27);
            txtBallName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(352, 66);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 7;
            label1.Text = "Ball Name";
            // 
            // DogView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtBallName);
            Controls.Add(btnPlay);
            Controls.Add(lblDogAge);
            Controls.Add(lblDogName);
            Controls.Add(txtDogAge);
            Controls.Add(txtDogName);
            Controls.Add(btnCreate);
            Name = "DogView";
            Text = "DogView";
            Load += DogView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private TextBox txtDogName;
        private TextBox txtDogAge;
        private Label lblDogName;
        private Label lblDogAge;
        private Button btnPlay;
        private TextBox txtBallName;
        private Label label1;
    }
}