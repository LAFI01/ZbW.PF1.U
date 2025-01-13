namespace MB09.Einstieg
{
    partial class StaticExample
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
            CmdCreatePerson = new Button();
            SuspendLayout();
            // 
            // LblShow
            // 
            LblShow.AutoSize = true;
            LblShow.Location = new Point(74, 100);
            LblShow.Name = "LblShow";
            LblShow.Size = new Size(59, 25);
            LblShow.TabIndex = 0;
            LblShow.Text = "label1";
            // 
            // CmdCreatePerson
            // 
            CmdCreatePerson.Location = new Point(45, 43);
            CmdCreatePerson.Name = "CmdCreatePerson";
            CmdCreatePerson.Size = new Size(112, 34);
            CmdCreatePerson.TabIndex = 1;
            CmdCreatePerson.Text = "Erzeuge Person";
            CmdCreatePerson.UseVisualStyleBackColor = true;
            CmdCreatePerson.Click += CmdCreatePerson_Click;
            // 
            // StaticExample
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdCreatePerson);
            Controls.Add(LblShow);
            Name = "StaticExample";
            Text = "StaticExample";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblShow;
        private Button CmdCreatePerson;
    }
}