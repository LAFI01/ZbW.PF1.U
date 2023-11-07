namespace MB01.A8_2
{
    partial class A4_1_4
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            LblValue1 = new Label();
            LblValue2 = new Label();
            TxtValue1 = new TextBox();
            TxtValue2 = new TextBox();
            LblResult = new Label();
            CmdCheck = new Button();
            SuspendLayout();
            // 
            // LblValue1
            // 
            LblValue1.AutoSize = true;
            LblValue1.Location = new Point(17, 20);
            LblValue1.Margin = new Padding(5, 0, 5, 0);
            LblValue1.Name = "LblValue1";
            LblValue1.Size = new Size(55, 20);
            LblValue1.TabIndex = 0;
            LblValue1.Text = "Zahl A:";
            // 
            // LblValue2
            // 
            LblValue2.AutoSize = true;
            LblValue2.Location = new Point(17, 60);
            LblValue2.Margin = new Padding(5, 0, 5, 0);
            LblValue2.Name = "LblValue2";
            LblValue2.Size = new Size(54, 20);
            LblValue2.TabIndex = 1;
            LblValue2.Text = "Zahl B:";
            // 
            // TxtValue1
            // 
            TxtValue1.Location = new Point(85, 20);
            TxtValue1.Margin = new Padding(5, 4, 5, 4);
            TxtValue1.Name = "TxtValue1";
            TxtValue1.Size = new Size(214, 27);
            TxtValue1.TabIndex = 2;
            // 
            // TxtValue2
            // 
            TxtValue2.Location = new Point(85, 61);
            TxtValue2.Margin = new Padding(5, 4, 5, 4);
            TxtValue2.Name = "TxtValue2";
            TxtValue2.Size = new Size(214, 27);
            TxtValue2.TabIndex = 3;
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Location = new Point(80, 177);
            LblResult.Margin = new Padding(5, 0, 5, 0);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(18, 20);
            LblResult.TabIndex = 4;
            LblResult.Text = "...";
            // 
            // CmdCheck
            // 
            CmdCheck.Location = new Point(85, 103);
            CmdCheck.Margin = new Padding(5, 4, 5, 4);
            CmdCheck.Name = "CmdCheck";
            CmdCheck.Size = new Size(216, 36);
            CmdCheck.TabIndex = 5;
            CmdCheck.Text = "Bestimme grössere Zahl:";
            CmdCheck.UseVisualStyleBackColor = true;
            CmdCheck.Click += CmdCheck_Click;
            // 
            // A4_1_4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 401);
            Controls.Add(CmdCheck);
            Controls.Add(LblResult);
            Controls.Add(TxtValue2);
            Controls.Add(TxtValue1);
            Controls.Add(LblValue2);
            Controls.Add(LblValue1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "A4_1_4";
            Text = "Aufgabe_A4-1-4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblValue1;
        private Label LblValue2;
        private TextBox TxtValue1;
        private TextBox TxtValue2;
        private Label LblResult;
        private Button CmdCheck;
    }
}

