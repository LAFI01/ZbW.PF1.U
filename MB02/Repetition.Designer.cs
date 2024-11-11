namespace MB02
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
            components = new System.ComponentModel.Container();
            RadHerr = new RadioButton();
            RadFrau = new RadioButton();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            LblOutput = new Label();
            LblSecShow = new Label();
            BtnOutput = new Button();
            SuspendLayout();
            // 
            // RadHerr
            // 
            RadHerr.AutoSize = true;
            RadHerr.Location = new Point(117, 51);
            RadHerr.Name = "RadHerr";
            RadHerr.Size = new Size(71, 29);
            RadHerr.TabIndex = 0;
            RadHerr.TabStop = true;
            RadHerr.Text = "Herr";
            RadHerr.UseVisualStyleBackColor = true;
            // 
            // RadFrau
            // 
            RadFrau.AutoSize = true;
            RadFrau.Location = new Point(292, 51);
            RadFrau.Name = "RadFrau";
            RadFrau.Size = new Size(71, 29);
            RadFrau.TabIndex = 1;
            RadFrau.TabStop = true;
            RadFrau.Text = "Frau";
            RadFrau.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(108, 185);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 29);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // LblOutput
            // 
            LblOutput.AutoSize = true;
            LblOutput.Location = new Point(117, 321);
            LblOutput.Name = "LblOutput";
            LblOutput.Size = new Size(59, 25);
            LblOutput.TabIndex = 4;
            LblOutput.Text = "label1";
            // 
            // LblSecShow
            // 
            LblSecShow.AutoSize = true;
            LblSecShow.Location = new Point(374, 321);
            LblSecShow.Name = "LblSecShow";
            LblSecShow.Size = new Size(90, 25);
            LblSecShow.TabIndex = 5;
            LblSecShow.Text = "Sekunden";
            // 
            // BtnOutput
            // 
            BtnOutput.Location = new Point(108, 251);
            BtnOutput.Name = "BtnOutput";
            BtnOutput.Size = new Size(112, 34);
            BtnOutput.TabIndex = 6;
            BtnOutput.Text = "button1";
            BtnOutput.UseVisualStyleBackColor = true;
            BtnOutput.Click += BtnOutput_Click;
            // 
            // Repetition
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 559);
            Controls.Add(BtnOutput);
            Controls.Add(LblSecShow);
            Controls.Add(LblOutput);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(RadFrau);
            Controls.Add(RadHerr);
            Name = "Repetition";
            Text = "Repetition";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton RadHerr;
        private RadioButton RadFrau;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private Label LblOutput;
        private Label LblSecShow;
        private Button BtnOutput;
    }
}