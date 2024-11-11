namespace MB03
{
    partial class MyStopwatch
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
            BtnStart = new Button();
            LblCounter = new Label();
            MyList = new ListBox();
            MyCombobox = new ComboBox();
            SuspendLayout();
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(69, 135);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(112, 34);
            BtnStart.TabIndex = 0;
            BtnStart.Text = "Start";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // LblCounter
            // 
            LblCounter.AutoSize = true;
            LblCounter.Location = new Point(114, 82);
            LblCounter.Name = "LblCounter";
            LblCounter.Size = new Size(22, 25);
            LblCounter.TabIndex = 1;
            LblCounter.Text = "0";
            // 
            // MyList
            // 
            MyList.FormattingEnabled = true;
            MyList.ItemHeight = 25;
            MyList.Items.AddRange(new object[] { "Hallo", "Hello", "Bonjour" });
            MyList.Location = new Point(356, 53);
            MyList.Name = "MyList";
            MyList.Size = new Size(180, 129);
            MyList.TabIndex = 2;
            // 
            // MyCombobox
            // 
            MyCombobox.FormattingEnabled = true;
            MyCombobox.Location = new Point(642, 59);
            MyCombobox.Name = "MyCombobox";
            MyCombobox.Size = new Size(182, 33);
            MyCombobox.TabIndex = 3;
            // 
            // MyStopwatch
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 450);
            Controls.Add(MyCombobox);
            Controls.Add(MyList);
            Controls.Add(LblCounter);
            Controls.Add(BtnStart);
            Name = "MyStopwatch";
            Text = "MyStopwatch";
            Load += MyStopwatch_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnStart;
        private Label LblCounter;
        private ListBox MyList;
        private ComboBox MyCombobox;
    }
}