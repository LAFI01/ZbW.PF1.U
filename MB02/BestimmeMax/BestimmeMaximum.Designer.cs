namespace MB02.BestimmeMax
{
    partial class BestimmeMaximum
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtValue1 = new TextBox();
            TxtValue2 = new TextBox();
            label4 = new Label();
            LblMax = new Label();
            CmdMax1 = new Button();
            TxtValue3 = new TextBox();
            label5 = new Label();
            CmdMax2 = new Button();
            CmdMax3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(277, 36);
            label1.TabIndex = 0;
            label1.Text = "Bestimme Maximum";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 91);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Erste Zahl:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 137);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Zweite Zahl:";
            // 
            // TxtValue1
            // 
            TxtValue1.Location = new Point(136, 86);
            TxtValue1.Margin = new Padding(4, 5, 4, 5);
            TxtValue1.Name = "TxtValue1";
            TxtValue1.Size = new Size(169, 27);
            TxtValue1.TabIndex = 3;
            // 
            // TxtValue2
            // 
            TxtValue2.Location = new Point(136, 134);
            TxtValue2.Margin = new Padding(4, 5, 4, 5);
            TxtValue2.Name = "TxtValue2";
            TxtValue2.Size = new Size(169, 27);
            TxtValue2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 238);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 5;
            label4.Text = "Maximum:";
            // 
            // LblMax
            // 
            LblMax.AutoSize = true;
            LblMax.Location = new Point(132, 238);
            LblMax.Margin = new Padding(4, 0, 4, 0);
            LblMax.Name = "LblMax";
            LblMax.Size = new Size(18, 20);
            LblMax.TabIndex = 6;
            LblMax.Text = ",,,";
            // 
            // CmdMax1
            // 
            CmdMax1.Location = new Point(24, 277);
            CmdMax1.Margin = new Padding(4, 5, 4, 5);
            CmdMax1.Name = "CmdMax1";
            CmdMax1.Size = new Size(283, 35);
            CmdMax1.TabIndex = 7;
            CmdMax1.Text = "Maximum 1. und 2. Zahl";
            CmdMax1.UseVisualStyleBackColor = true;
            CmdMax1.Click += CmdMax1_Click;
            // 
            // TxtValue3
            // 
            TxtValue3.Location = new Point(136, 182);
            TxtValue3.Margin = new Padding(4, 5, 4, 5);
            TxtValue3.Name = "TxtValue3";
            TxtValue3.Size = new Size(169, 27);
            TxtValue3.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 183);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 8;
            label5.Text = "Dritte Zahl:";
            // 
            // CmdMax2
            // 
            CmdMax2.Location = new Point(24, 322);
            CmdMax2.Margin = new Padding(4, 5, 4, 5);
            CmdMax2.Name = "CmdMax2";
            CmdMax2.Size = new Size(283, 35);
            CmdMax2.TabIndex = 10;
            CmdMax2.Text = "Maximum 2. und 3. Zahl";
            CmdMax2.UseVisualStyleBackColor = true;
            CmdMax2.Click += CmdMax2_Click;
            // 
            // CmdMax3
            // 
            CmdMax3.Location = new Point(24, 369);
            CmdMax3.Margin = new Padding(4, 5, 4, 5);
            CmdMax3.Name = "CmdMax3";
            CmdMax3.Size = new Size(283, 35);
            CmdMax3.TabIndex = 11;
            CmdMax3.Text = "Maximum 1. und 3. Zahl";
            CmdMax3.UseVisualStyleBackColor = true;
            CmdMax3.Click += CmdMax3_Click;
            // 
            // BestimmeMaximum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 423);
            Controls.Add(CmdMax3);
            Controls.Add(CmdMax2);
            Controls.Add(TxtValue3);
            Controls.Add(label5);
            Controls.Add(CmdMax1);
            Controls.Add(LblMax);
            Controls.Add(label4);
            Controls.Add(TxtValue2);
            Controls.Add(TxtValue1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "BestimmeMaximum";
            Text = "Aufgabe_10-1-1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtValue1;
        private TextBox TxtValue2;
        private Label label4;
        private Label LblMax;
        private Button CmdMax1;
        private TextBox TxtValue3;
        private Label label5;
        private Button CmdMax2;
        private Button CmdMax3;
    }
}

