namespace MB07.ReferenzBeispiel
{
    partial class ReferenceExampleView
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
            BtnCheck = new Button();
            label1 = new Label();
            TxtPersonA = new TextBox();
            label2 = new Label();
            LblResponseEvenSign = new Label();
            TxtPersonB = new TextBox();
            label3 = new Label();
            label4 = new Label();
            LblResponseEquals = new Label();
            SuspendLayout();
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(43, 224);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(338, 46);
            BtnCheck.TabIndex = 0;
            BtnCheck.Text = "Check";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += ClickOnBtnCheck;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 28);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 1;
            label1.Text = "Person A";
            // 
            // TxtPersonA
            // 
            TxtPersonA.Location = new Point(53, 71);
            TxtPersonA.Name = "TxtPersonA";
            TxtPersonA.Size = new Size(150, 31);
            TxtPersonA.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 127);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 3;
            label2.Text = "Resultat \"==\"?";
            // 
            // LblResponseEvenSign
            // 
            LblResponseEvenSign.AutoSize = true;
            LblResponseEvenSign.Location = new Point(228, 127);
            LblResponseEvenSign.Name = "LblResponseEvenSign";
            LblResponseEvenSign.Size = new Size(52, 25);
            LblResponseEvenSign.TabIndex = 4;
            LblResponseEvenSign.Text = "?????";
            // 
            // TxtPersonB
            // 
            TxtPersonB.Location = new Point(241, 71);
            TxtPersonB.Name = "TxtPersonB";
            TxtPersonB.Size = new Size(150, 31);
            TxtPersonB.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(241, 28);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 6;
            label3.Text = "Person B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 178);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 7;
            label4.Text = "Resultat \"Equals\"?";
            // 
            // LblResponseEquals
            // 
            LblResponseEquals.AutoSize = true;
            LblResponseEquals.Location = new Point(228, 178);
            LblResponseEquals.Name = "LblResponseEquals";
            LblResponseEquals.Size = new Size(52, 25);
            LblResponseEquals.TabIndex = 8;
            LblResponseEquals.Text = "?????";
            // 
            // ReferenceExampleView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 331);
            Controls.Add(LblResponseEquals);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TxtPersonB);
            Controls.Add(LblResponseEvenSign);
            Controls.Add(label2);
            Controls.Add(TxtPersonA);
            Controls.Add(label1);
            Controls.Add(BtnCheck);
            Name = "ReferenceExampleView";
            Text = "ReferenceExampleView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCheck;
        private Label label1;
        private TextBox TxtPersonA;
        private Label label2;
        private Label LblResponseEvenSign;
        private TextBox TxtPersonB;
        private Label label3;
        private Label label4;
        private Label LblResponseEquals;
    }
}