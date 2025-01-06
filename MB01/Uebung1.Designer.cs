namespace MB01
{
    partial class Uebung1
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
            LblShow = new Label();
            CmdPlus = new Button();
            CmdMinus = new Button();
            TxtInput = new TextBox();
            NumNumber = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)NumNumber).BeginInit();
            SuspendLayout();
            // 
            // LblShow
            // 
            LblShow.AutoSize = true;
            LblShow.Location = new Point(78, 33);
            LblShow.Name = "LblShow";
            LblShow.Size = new Size(16, 25);
            LblShow.TabIndex = 0;
            LblShow.Text = ".";
            // 
            // CmdPlus
            // 
            CmdPlus.Location = new Point(78, 90);
            CmdPlus.Name = "CmdPlus";
            CmdPlus.Size = new Size(112, 34);
            CmdPlus.TabIndex = 1;
            CmdPlus.Text = "+";
            CmdPlus.UseVisualStyleBackColor = true;
            CmdPlus.Click += CmdPlus_Click;
            // 
            // CmdMinus
            // 
            CmdMinus.Location = new Point(78, 160);
            CmdMinus.Name = "CmdMinus";
            CmdMinus.Size = new Size(112, 34);
            CmdMinus.TabIndex = 2;
            CmdMinus.Text = "-";
            CmdMinus.UseVisualStyleBackColor = true;
            CmdMinus.Click += CmdMinus_Click;
            // 
            // TxtInput
            // 
            TxtInput.Location = new Point(305, 50);
            TxtInput.Multiline = true;
            TxtInput.Name = "TxtInput";
            TxtInput.Size = new Size(318, 129);
            TxtInput.TabIndex = 3;
            // 
            // NumNumber
            // 
            NumNumber.DecimalPlaces = 2;
            NumNumber.Location = new Point(313, 236);
            NumNumber.Name = "NumNumber";
            NumNumber.Size = new Size(310, 31);
            NumNumber.TabIndex = 4;
            NumNumber.ValueChanged += NumNumber_ValueChanged;
            // 
            // Uebung1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NumNumber);
            Controls.Add(TxtInput);
            Controls.Add(CmdMinus);
            Controls.Add(CmdPlus);
            Controls.Add(LblShow);
            Name = "Uebung1";
            Text = "Uebung1";
            ((System.ComponentModel.ISupportInitialize)NumNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblShow;
        private Button CmdPlus;
        private Button CmdMinus;
        private TextBox TxtInput;
        private NumericUpDown NumNumber;
    }
}