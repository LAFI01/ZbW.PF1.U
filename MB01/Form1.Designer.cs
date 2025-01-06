namespace MB01
{
    partial class Form1
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
            LblShow = new Label();
            CmdHallo = new Button();
            CmdEnd = new Button();
            SuspendLayout();
            // 
            // LblShow
            // 
            LblShow.AutoSize = true;
            LblShow.Location = new Point(49, 48);
            LblShow.Name = "LblShow";
            LblShow.Size = new Size(44, 25);
            LblShow.TabIndex = 0;
            LblShow.Text = "Leer";
            // 
            // CmdHallo
            // 
            CmdHallo.Location = new Point(49, 100);
            CmdHallo.Name = "CmdHallo";
            CmdHallo.Size = new Size(112, 34);
            CmdHallo.TabIndex = 1;
            CmdHallo.Text = "Hallo";
            CmdHallo.UseVisualStyleBackColor = true;
            CmdHallo.Click += CmdHallo_Click;
            // 
            // CmdEnd
            // 
            CmdEnd.Location = new Point(49, 156);
            CmdEnd.Name = "CmdEnd";
            CmdEnd.Size = new Size(112, 34);
            CmdEnd.TabIndex = 2;
            CmdEnd.Text = "End";
            CmdEnd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdEnd);
            Controls.Add(CmdHallo);
            Controls.Add(LblShow);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblShow;
        private Button CmdHallo;
        private Button CmdEnd;
    }
}
