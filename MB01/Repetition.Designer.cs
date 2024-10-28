namespace MB01
{
    partial class Repetition
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(205, 206);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(240, 39);
            numericUpDown1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(129, 296);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 3;
            button1.Text = "Ausgeben";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(307, 296);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 4;
            button2.Text = "Löschen";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 54);
            label1.Name = "label1";
            label1.Size = new Size(109, 32);
            label1.TabIndex = 5;
            label1.Text = "Vorname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 128);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 6;
            label2.Text = "Nachname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 208);
            label3.Name = "label3";
            label3.Size = new Size(64, 32);
            label3.TabIndex = 7;
            label3.Text = "Alter";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 404);
            label4.Name = "label4";
            label4.Size = new Size(106, 32);
            label4.TabIndex = 8;
            label4.Text = "Ausgabe";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(207, 412);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 9;
            label5.Click += label5_Click;
            // 
            // Repetition
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 568);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Repetition";
            Text = "Repetition";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}