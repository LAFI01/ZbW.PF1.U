namespace MB08.A12_1
{
    partial class Uhr1
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
            components = new System.ComponentModel.Container();
            TxtHour = new TextBox();
            TxtMinute = new TextBox();
            LblHour = new Label();
            LblMinute = new Label();
            CmdTick = new Button();
            CmdStartTimer = new Button();
            TmrTick = new System.Windows.Forms.Timer(components);
            LblSeparator = new Label();
            SuspendLayout();
            // 
            // TxtHour
            // 
            TxtHour.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtHour.Location = new Point(47, 190);
            TxtHour.Margin = new Padding(5, 6, 5, 6);
            TxtHour.Name = "TxtHour";
            TxtHour.Size = new Size(306, 48);
            TxtHour.TabIndex = 0;
            // 
            // TxtMinute
            // 
            TxtMinute.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMinute.Location = new Point(465, 190);
            TxtMinute.Margin = new Padding(5, 6, 5, 6);
            TxtMinute.Name = "TxtMinute";
            TxtMinute.Size = new Size(306, 48);
            TxtMinute.TabIndex = 1;
            // 
            // LblHour
            // 
            LblHour.AutoSize = true;
            LblHour.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblHour.Location = new Point(38, 79);
            LblHour.Margin = new Padding(5, 0, 5, 0);
            LblHour.Name = "LblHour";
            LblHour.Size = new Size(151, 40);
            LblHour.TabIndex = 2;
            LblHour.Text = "Stunden";
            // 
            // LblMinute
            // 
            LblMinute.AutoSize = true;
            LblMinute.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblMinute.Location = new Point(457, 79);
            LblMinute.Margin = new Padding(5, 0, 5, 0);
            LblMinute.Name = "LblMinute";
            LblMinute.Size = new Size(145, 40);
            LblMinute.TabIndex = 3;
            LblMinute.Text = "Minuten";
            // 
            // CmdTick
            // 
            CmdTick.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CmdTick.Location = new Point(47, 392);
            CmdTick.Margin = new Padding(5, 6, 5, 6);
            CmdTick.Name = "CmdTick";
            CmdTick.Size = new Size(727, 140);
            CmdTick.TabIndex = 4;
            CmdTick.Text = "Schalten";
            CmdTick.UseVisualStyleBackColor = true;
            CmdTick.Click += CmdTick_Click;
            // 
            // CmdStartTimer
            // 
            CmdStartTimer.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CmdStartTimer.Location = new Point(47, 598);
            CmdStartTimer.Margin = new Padding(5, 6, 5, 6);
            CmdStartTimer.Name = "CmdStartTimer";
            CmdStartTimer.Size = new Size(727, 140);
            CmdStartTimer.TabIndex = 5;
            CmdStartTimer.Text = "Starte Automatik";
            CmdStartTimer.UseVisualStyleBackColor = true;
            CmdStartTimer.Click += CmdStartTimer_Click;
            // 
            // TmrTick
            // 
            TmrTick.Interval = 1000;
            TmrTick.Tick += CmdTick_Click;
            // 
            // LblSeparator
            // 
            LblSeparator.AutoSize = true;
            LblSeparator.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblSeparator.Location = new Point(395, 190);
            LblSeparator.Margin = new Padding(5, 0, 5, 0);
            LblSeparator.Name = "LblSeparator";
            LblSeparator.Size = new Size(27, 40);
            LblSeparator.TabIndex = 6;
            LblSeparator.Text = ":";
            // 
            // Uhr1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 853);
            Controls.Add(LblSeparator);
            Controls.Add(CmdStartTimer);
            Controls.Add(CmdTick);
            Controls.Add(LblMinute);
            Controls.Add(LblHour);
            Controls.Add(TxtMinute);
            Controls.Add(TxtHour);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Uhr1";
            Text = "Aufgabe_A12-A1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox TxtHour;
        private System.Windows.Forms.TextBox TxtMinute;
        private System.Windows.Forms.Label LblHour;
        private System.Windows.Forms.Label LblMinute;
        private System.Windows.Forms.Button CmdTick;
        private System.Windows.Forms.Button CmdStartTimer;
        private System.Windows.Forms.Timer TmrTick;
        private System.Windows.Forms.Label LblSeparator;
    }
}

