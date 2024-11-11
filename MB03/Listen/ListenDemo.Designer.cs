namespace MB03.Listen
{
    partial class ListenDemo
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
            btnHinzufuegen = new Button();
            btnEntfernen = new Button();
            listBoxAusgabe = new ListBox();
            comboEintrag = new ComboBox();
            btnAusgabe = new Button();
            Ausgabe = new Label();
            SuspendLayout();
            // 
            // btnHinzufuegen
            // 
            btnHinzufuegen.Location = new Point(799, 114);
            btnHinzufuegen.Name = "btnHinzufuegen";
            btnHinzufuegen.Size = new Size(150, 46);
            btnHinzufuegen.TabIndex = 1;
            btnHinzufuegen.Text = "Hinzufügen";
            btnHinzufuegen.UseVisualStyleBackColor = true;
            btnHinzufuegen.Click += btnHinzufuegen_Click;
            // 
            // btnEntfernen
            // 
            btnEntfernen.Location = new Point(1047, 114);
            btnEntfernen.Name = "btnEntfernen";
            btnEntfernen.Size = new Size(150, 46);
            btnEntfernen.TabIndex = 2;
            btnEntfernen.Text = "Entfernen";
            btnEntfernen.UseVisualStyleBackColor = true;
            // 
            // listBoxAusgabe
            // 
            listBoxAusgabe.FormattingEnabled = true;
            listBoxAusgabe.ItemHeight = 32;
            listBoxAusgabe.Location = new Point(59, 104);
            listBoxAusgabe.Name = "listBoxAusgabe";
            listBoxAusgabe.Size = new Size(650, 612);
            listBoxAusgabe.TabIndex = 3;
            // 
            // comboEintrag
            // 
            comboEintrag.FormattingEnabled = true;
            comboEintrag.Location = new Point(799, 198);
            comboEintrag.Name = "comboEintrag";
            comboEintrag.Size = new Size(400, 40);
            comboEintrag.TabIndex = 4;
            comboEintrag.SelectedIndexChanged += comboEintrag_SelectedIndexChanged;
            // 
            // btnAusgabe
            // 
            btnAusgabe.Location = new Point(61, 756);
            btnAusgabe.Name = "btnAusgabe";
            btnAusgabe.Size = new Size(150, 46);
            btnAusgabe.TabIndex = 5;
            btnAusgabe.Text = "Listbox ausgeben";
            btnAusgabe.UseVisualStyleBackColor = true;
            // 
            // Ausgabe
            // 
            Ausgabe.AutoSize = true;
            Ausgabe.Location = new Point(62, 896);
            Ausgabe.Name = "Ausgabe";
            Ausgabe.Size = new Size(34, 32);
            Ausgabe.TabIndex = 6;
            Ausgabe.Text = "--";
            // 
            // ListenDemo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2710, 1726);
            Controls.Add(Ausgabe);
            Controls.Add(btnAusgabe);
            Controls.Add(comboEintrag);
            Controls.Add(listBoxAusgabe);
            Controls.Add(btnEntfernen);
            Controls.Add(btnHinzufuegen);
            Margin = new Padding(6, 6, 6, 6);
            Name = "ListenDemo";
            Text = "ListenDemo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHinzufuegen;
        private Button btnEntfernen;
        private ListBox listBoxAusgabe;
        private ComboBox comboEintrag;
        private Button btnAusgabe;
        private Label Ausgabe;
    }
}