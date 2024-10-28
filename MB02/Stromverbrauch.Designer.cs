namespace MB02
{
    partial class Stromverbrauch
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
            TitleLable = new Label();
            StromWert = new NumericUpDown();
            ButtonBerechnen = new Button();
            AusgabeRechnung = new Label();
            groupBox1 = new GroupBox();
            Sonntag = new RadioButton();
            Samstag = new RadioButton();
            Freitag = new RadioButton();
            Donnerstag = new RadioButton();
            Mittwoch = new RadioButton();
            Dienstag = new RadioButton();
            Montag = new RadioButton();
            Feiertag = new CheckBox();
            TabBar = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)StromWert).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TabBar).BeginInit();
            SuspendLayout();
            // 
            // TitleLable
            // 
            TitleLable.AutoSize = true;
            TitleLable.Location = new Point(35, 64);
            TitleLable.Name = "TitleLable";
            TitleLable.Size = new Size(205, 32);
            TitleLable.TabIndex = 0;
            TitleLable.Text = "Verbrauch in KWh";
            // 
            // StromWert
            // 
            StromWert.Location = new Point(293, 62);
            StromWert.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            StromWert.Name = "StromWert";
            StromWert.Size = new Size(240, 39);
            StromWert.TabIndex = 1;
            // 
            // ButtonBerechnen
            // 
            ButtonBerechnen.Location = new Point(293, 214);
            ButtonBerechnen.Name = "ButtonBerechnen";
            ButtonBerechnen.Size = new Size(224, 46);
            ButtonBerechnen.TabIndex = 2;
            ButtonBerechnen.Text = "Berechne Kosten";
            ButtonBerechnen.UseVisualStyleBackColor = true;
            ButtonBerechnen.Click += ButtonBerechnen_Click;
            // 
            // AusgabeRechnung
            // 
            AusgabeRechnung.AutoSize = true;
            AusgabeRechnung.Location = new Point(293, 344);
            AusgabeRechnung.Name = "AusgabeRechnung";
            AusgabeRechnung.Size = new Size(0, 32);
            AusgabeRechnung.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Sonntag);
            groupBox1.Controls.Add(Samstag);
            groupBox1.Controls.Add(Freitag);
            groupBox1.Controls.Add(Donnerstag);
            groupBox1.Controls.Add(Mittwoch);
            groupBox1.Controls.Add(Dienstag);
            groupBox1.Controls.Add(Montag);
            groupBox1.Location = new Point(623, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 234);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Wochentag";
            // 
            // Sonntag
            // 
            Sonntag.AutoSize = true;
            Sonntag.Location = new Point(192, 142);
            Sonntag.Name = "Sonntag";
            Sonntag.Size = new Size(134, 36);
            Sonntag.TabIndex = 6;
            Sonntag.TabStop = true;
            Sonntag.Text = "Sonntag";
            Sonntag.UseVisualStyleBackColor = true;
            // 
            // Samstag
            // 
            Samstag.AutoSize = true;
            Samstag.Location = new Point(192, 100);
            Samstag.Name = "Samstag";
            Samstag.Size = new Size(135, 36);
            Samstag.TabIndex = 5;
            Samstag.TabStop = true;
            Samstag.Text = "Samstag";
            Samstag.UseVisualStyleBackColor = true;
            // 
            // Freitag
            // 
            Freitag.AutoSize = true;
            Freitag.Location = new Point(192, 58);
            Freitag.Name = "Freitag";
            Freitag.Size = new Size(118, 36);
            Freitag.TabIndex = 4;
            Freitag.TabStop = true;
            Freitag.Text = "Freitag";
            Freitag.UseVisualStyleBackColor = true;
            // 
            // Donnerstag
            // 
            Donnerstag.AutoSize = true;
            Donnerstag.Location = new Point(6, 182);
            Donnerstag.Name = "Donnerstag";
            Donnerstag.Size = new Size(169, 36);
            Donnerstag.TabIndex = 3;
            Donnerstag.TabStop = true;
            Donnerstag.Text = "Donnerstag";
            Donnerstag.UseVisualStyleBackColor = true;
            // 
            // Mittwoch
            // 
            Mittwoch.AutoSize = true;
            Mittwoch.Location = new Point(6, 140);
            Mittwoch.Name = "Mittwoch";
            Mittwoch.Size = new Size(145, 36);
            Mittwoch.TabIndex = 2;
            Mittwoch.TabStop = true;
            Mittwoch.Text = "Mittwoch";
            Mittwoch.UseVisualStyleBackColor = true;
            // 
            // Dienstag
            // 
            Dienstag.AutoSize = true;
            Dienstag.Location = new Point(6, 98);
            Dienstag.Name = "Dienstag";
            Dienstag.Size = new Size(139, 36);
            Dienstag.TabIndex = 1;
            Dienstag.TabStop = true;
            Dienstag.Text = "Dienstag";
            Dienstag.UseVisualStyleBackColor = true;
            // 
            // Montag
            // 
            Montag.AutoSize = true;
            Montag.Location = new Point(6, 56);
            Montag.Name = "Montag";
            Montag.Size = new Size(129, 36);
            Montag.TabIndex = 0;
            Montag.TabStop = true;
            Montag.Text = "Montag";
            Montag.UseVisualStyleBackColor = true;
            Montag.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Feiertag
            // 
            Feiertag.AutoSize = true;
            Feiertag.Location = new Point(631, 320);
            Feiertag.Name = "Feiertag";
            Feiertag.Size = new Size(132, 36);
            Feiertag.TabIndex = 5;
            Feiertag.Text = "Feiertag";
            Feiertag.UseVisualStyleBackColor = true;
            Feiertag.CheckedChanged += Feiertag_CheckedChanged;
            // 
            // TabBar
            // 
            TabBar.Location = new Point(293, 119);
            TabBar.Maximum = 99999;
            TabBar.Name = "TabBar";
            TabBar.Size = new Size(208, 90);
            TabBar.TabIndex = 6;
            TabBar.Scroll += TabBar_Scroll;
            // 
            // Stromverbrauch
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 450);
            Controls.Add(TabBar);
            Controls.Add(Feiertag);
            Controls.Add(groupBox1);
            Controls.Add(AusgabeRechnung);
            Controls.Add(ButtonBerechnen);
            Controls.Add(StromWert);
            Controls.Add(TitleLable);
            Name = "Stromverbrauch";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)StromWert).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TabBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLable;
        private NumericUpDown StromWert;
        private Button ButtonBerechnen;
        private Label AusgabeRechnung;
        private GroupBox groupBox1;
        private RadioButton Montag;
        private RadioButton Sonntag;
        private RadioButton Samstag;
        private RadioButton Freitag;
        private RadioButton Donnerstag;
        private RadioButton Mittwoch;
        private RadioButton Dienstag;
        private CheckBox Feiertag;
        private TrackBar TabBar;
    }
}
