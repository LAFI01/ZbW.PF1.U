namespace MB05.HandtaschenBeispiel
{
    partial class Handtaschenverwaltung
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
            BtnAdd = new Button();
            LblName = new Label();
            TxtName = new TextBox();
            LblPreis = new Label();
            NuDPrice = new NumericUpDown();
            txtHandtaschenListe = new TextBox();
            lblHandtaschenListe = new Label();
            ((System.ComponentModel.ISupportInitialize)NuDPrice).BeginInit();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(204, 128);
            BtnAdd.Margin = new Padding(3, 4, 3, 4);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(97, 31);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "Hinzufügen";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(12, 20);
            LblName.Name = "LblName";
            LblName.Size = new Size(49, 20);
            LblName.TabIndex = 1;
            LblName.Text = "Name";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(125, 13);
            TxtName.Margin = new Padding(3, 4, 3, 4);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(210, 27);
            TxtName.TabIndex = 2;
            // 
            // LblPreis
            // 
            LblPreis.AutoSize = true;
            LblPreis.Location = new Point(12, 55);
            LblPreis.Name = "LblPreis";
            LblPreis.Size = new Size(40, 20);
            LblPreis.TabIndex = 3;
            LblPreis.Text = "Preis";
            // 
            // NuDPrice
            // 
            NuDPrice.Location = new Point(124, 48);
            NuDPrice.Margin = new Padding(3, 4, 3, 4);
            NuDPrice.Name = "NuDPrice";
            NuDPrice.Size = new Size(211, 27);
            NuDPrice.TabIndex = 4;
            // 
            // txtHandtaschenListe
            // 
            txtHandtaschenListe.Location = new Point(12, 287);
            txtHandtaschenListe.Multiline = true;
            txtHandtaschenListe.Name = "txtHandtaschenListe";
            txtHandtaschenListe.Size = new Size(323, 334);
            txtHandtaschenListe.TabIndex = 6;
            // 
            // lblHandtaschenListe
            // 
            lblHandtaschenListe.AutoSize = true;
            lblHandtaschenListe.Location = new Point(12, 264);
            lblHandtaschenListe.Name = "lblHandtaschenListe";
            lblHandtaschenListe.Size = new Size(122, 20);
            lblHandtaschenListe.TabIndex = 7;
            lblHandtaschenListe.Text = "Handtaschenliste";
            // 
            // Handtaschenverwaltung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 633);
            Controls.Add(lblHandtaschenListe);
            Controls.Add(txtHandtaschenListe);
            Controls.Add(NuDPrice);
            Controls.Add(LblPreis);
            Controls.Add(TxtName);
            Controls.Add(LblName);
            Controls.Add(BtnAdd);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Handtaschenverwaltung";
            Text = "Handtaschenverwaltung";
            Load += Handtaschenverwaltung_Load;
            ((System.ComponentModel.ISupportInitialize)NuDPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAdd;
        private Label LblName;
        private TextBox TxtName;
        private Label LblPreis;
        private NumericUpDown NuDPrice;
        private TextBox txtHandtaschenListe;
        private Label lblHandtaschenListe;
    }
}