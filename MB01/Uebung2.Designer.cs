namespace MB01
{
    partial class Uebung2
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
            CmdOutput = new Button();
            CmdDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            TxtInput = new TextBox();
            NumLetterCounter = new NumericUpDown();
            LblShow = new Label();
            ((System.ComponentModel.ISupportInitialize)NumLetterCounter).BeginInit();
            SuspendLayout();
            // 
            // CmdOutput
            // 
            CmdOutput.Location = new Point(226, 129);
            CmdOutput.Name = "CmdOutput";
            CmdOutput.Size = new Size(112, 34);
            CmdOutput.TabIndex = 0;
            CmdOutput.Text = "Ausgabe";
            CmdOutput.UseVisualStyleBackColor = true;
            CmdOutput.Click += CmdOutput_Click;
            // 
            // CmdDelete
            // 
            CmdDelete.Location = new Point(354, 129);
            CmdDelete.Name = "CmdDelete";
            CmdDelete.Size = new Size(112, 34);
            CmdDelete.TabIndex = 1;
            CmdDelete.Text = "Löschen";
            CmdDelete.UseVisualStyleBackColor = true;
            CmdDelete.Click += CmdDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 23);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 2;
            label1.Text = "Eingabe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 77);
            label2.Name = "label2";
            label2.Size = new Size(161, 25);
            label2.TabIndex = 3;
            label2.Text = "Anzahl Buchstaben";
            // 
            // TxtInput
            // 
            TxtInput.Location = new Point(226, 23);
            TxtInput.Multiline = true;
            TxtInput.Name = "TxtInput";
            TxtInput.Size = new Size(240, 46);
            TxtInput.TabIndex = 4;
            TxtInput.TextChanged += TxtInput_TextChanged;
            // 
            // NumLetterCounter
            // 
            NumLetterCounter.Location = new Point(226, 77);
            NumLetterCounter.Name = "NumLetterCounter";
            NumLetterCounter.ReadOnly = true;
            NumLetterCounter.Size = new Size(240, 31);
            NumLetterCounter.TabIndex = 5;
            // 
            // LblShow
            // 
            LblShow.AutoSize = true;
            LblShow.Location = new Point(226, 218);
            LblShow.Name = "LblShow";
            LblShow.Size = new Size(59, 25);
            LblShow.TabIndex = 6;
            LblShow.Text = "label3";
            // 
            // Uebung2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblShow);
            Controls.Add(NumLetterCounter);
            Controls.Add(TxtInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CmdDelete);
            Controls.Add(CmdOutput);
            Name = "Uebung2";
            Text = "Uebung2";
            ((System.ComponentModel.ISupportInitialize)NumLetterCounter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdOutput;
        private Button CmdDelete;
        private Label label1;
        private Label label2;
        private TextBox TxtInput;
        private NumericUpDown NumLetterCounter;
        private Label LblShow;
    }
}