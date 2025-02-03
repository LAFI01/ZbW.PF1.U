namespace MB09.VererbungBeispiel
{
    partial class MediumView
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
            CmdAdd = new Button();
            SuspendLayout();
            // 
            // CmdAdd
            // 
            CmdAdd.Location = new Point(53, 132);
            CmdAdd.Name = "CmdAdd";
            CmdAdd.Size = new Size(112, 34);
            CmdAdd.TabIndex = 0;
            CmdAdd.Text = "Hinzufügen";
            CmdAdd.UseVisualStyleBackColor = true;
            CmdAdd.Click += CmdAdd_Click;
            // 
            // MediumView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdAdd);
            Name = "MediumView";
            Text = "MediumView";
            ResumeLayout(false);
        }

        #endregion

        private Button CmdAdd;
    }
}