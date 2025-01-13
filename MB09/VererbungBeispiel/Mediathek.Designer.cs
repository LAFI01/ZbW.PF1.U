namespace MB09.VererbungBeispiel
{
    partial class Mediathek
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
            label1 = new Label();
            label2 = new Label();
            RadCd = new RadioButton();
            RadDvd = new RadioButton();
            TxtTitle = new TextBox();
            TxtRessigeur = new TextBox();
            TxtArtist = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // CmdAdd
            // 
            CmdAdd.Location = new Point(149, 249);
            CmdAdd.Name = "CmdAdd";
            CmdAdd.Size = new Size(150, 34);
            CmdAdd.TabIndex = 0;
            CmdAdd.Text = "Hinzufügen";
            CmdAdd.UseVisualStyleBackColor = true;
            CmdAdd.Click += CmdAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 78);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 1;
            label1.Text = "Titel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 130);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 2;
            label2.Text = "Regisseur";
            // 
            // RadCd
            // 
            RadCd.AutoSize = true;
            RadCd.Location = new Point(155, 22);
            RadCd.Name = "RadCd";
            RadCd.Size = new Size(59, 29);
            RadCd.TabIndex = 3;
            RadCd.TabStop = true;
            RadCd.Text = "Cd";
            RadCd.UseVisualStyleBackColor = true;
            // 
            // RadDvd
            // 
            RadDvd.AutoSize = true;
            RadDvd.Location = new Point(235, 22);
            RadDvd.Name = "RadDvd";
            RadDvd.Size = new Size(70, 29);
            RadDvd.TabIndex = 4;
            RadDvd.TabStop = true;
            RadDvd.Text = "Dvd";
            RadDvd.UseVisualStyleBackColor = true;
            // 
            // TxtTitle
            // 
            TxtTitle.Location = new Point(149, 75);
            TxtTitle.Name = "TxtTitle";
            TxtTitle.Size = new Size(150, 31);
            TxtTitle.TabIndex = 5;
            // 
            // TxtRessigeur
            // 
            TxtRessigeur.Location = new Point(149, 132);
            TxtRessigeur.Name = "TxtRessigeur";
            TxtRessigeur.Size = new Size(150, 31);
            TxtRessigeur.TabIndex = 6;
            // 
            // TxtArtist
            // 
            TxtArtist.Location = new Point(149, 180);
            TxtArtist.Name = "TxtArtist";
            TxtArtist.Size = new Size(150, 31);
            TxtArtist.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 186);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 8;
            label3.Text = "Künstler";
            // 
            // Mediathek
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(TxtArtist);
            Controls.Add(TxtRessigeur);
            Controls.Add(TxtTitle);
            Controls.Add(RadDvd);
            Controls.Add(RadCd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CmdAdd);
            Name = "Mediathek";
            Text = "Mediathek";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAdd;
        private Label label1;
        private Label label2;
        private RadioButton RadCd;
        private RadioButton RadDvd;
        private TextBox TxtTitle;
        private TextBox TxtRessigeur;
        private TextBox TxtArtist;
        private Label label3;
    }
}