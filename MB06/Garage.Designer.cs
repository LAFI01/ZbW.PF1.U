namespace MB06
{
    partial class Garage
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
            CmdCreate = new Button();
            label1 = new Label();
            label2 = new Label();
            LblShow = new Label();
            NumWeight = new NumericUpDown();
            TxtColor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)NumWeight).BeginInit();
            SuspendLayout();
            // 
            // CmdCreate
            // 
            CmdCreate.Location = new Point(132, 142);
            CmdCreate.Name = "CmdCreate";
            CmdCreate.Size = new Size(186, 34);
            CmdCreate.TabIndex = 0;
            CmdCreate.Text = "Erzeuge Fahrrad";
            CmdCreate.UseVisualStyleBackColor = true;
            CmdCreate.Click += BtnCreate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 34);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 1;
            label1.Text = "Farbe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 87);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 2;
            label2.Text = "Gewicht";
            // 
            // LblShow
            // 
            LblShow.AutoSize = true;
            LblShow.Location = new Point(132, 215);
            LblShow.Name = "LblShow";
            LblShow.Size = new Size(59, 25);
            LblShow.TabIndex = 3;
            LblShow.Text = "label3";
            // 
            // NumWeight
            // 
            NumWeight.Location = new Point(132, 81);
            NumWeight.Name = "NumWeight";
            NumWeight.Size = new Size(180, 31);
            NumWeight.TabIndex = 4;
            // 
            // TxtColor
            // 
            TxtColor.Location = new Point(132, 28);
            TxtColor.Name = "TxtColor";
            TxtColor.Size = new Size(186, 31);
            TxtColor.TabIndex = 5;
            // 
            // Garage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 403);
            Controls.Add(TxtColor);
            Controls.Add(NumWeight);
            Controls.Add(LblShow);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CmdCreate);
            Name = "Garage";
            Text = "Garage";
            ((System.ComponentModel.ISupportInitialize)NumWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdCreate;
        private Label label1;
        private Label label2;
        private Label LblShow;
        private NumericUpDown NumWeight;
        private TextBox TxtColor;
    }
}