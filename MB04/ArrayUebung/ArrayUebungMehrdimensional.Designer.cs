namespace MB04.ArrayUebung
{
    partial class ArrayUebungMehrdimensional
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
            CmdShow = new Button();
            LblShow = new Label();
            SuspendLayout();
            // 
            // CmdShow
            // 
            CmdShow.Location = new Point(39, 46);
            CmdShow.Name = "CmdShow";
            CmdShow.Size = new Size(75, 23);
            CmdShow.TabIndex = 0;
            CmdShow.Text = "Show";
            CmdShow.UseVisualStyleBackColor = true;
            CmdShow.Click += CmdShow_Click;
            // 
            // LblShow
            // 
            LblShow.AutoSize = true;
            LblShow.Location = new Point(39, 87);
            LblShow.Name = "LblShow";
            LblShow.Size = new Size(19, 15);
            LblShow.TabIndex = 1;
            LblShow.Text = "....";
            // 
            // ArrayUebung_Mehrdimensional
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(212, 450);
            Controls.Add(LblShow);
            Controls.Add(CmdShow);
            Name = "ArrayUebung_Mehrdimensional";
            Text = "WeekActivity";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdShow;
        private Label LblShow;
    }
}