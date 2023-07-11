namespace project
{
    partial class Form4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            menuTextbox = new TextBox();
            mealCombobox = new ComboBox();
            saladCombobox = new ComboBox();
            snackCombobox = new ComboBox();
            desertCombobox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 89);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Meals";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 89);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Salads";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(477, 89);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Snacks";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(664, 89);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Deserts";
            // 
            // menuTextbox
            // 
            menuTextbox.Location = new Point(196, 31);
            menuTextbox.Name = "menuTextbox";
            menuTextbox.Size = new Size(413, 23);
            menuTextbox.TabIndex = 4;
            // 
            // mealCombobox
            // 
            mealCombobox.FormattingEnabled = true;
            mealCombobox.Location = new Point(53, 119);
            mealCombobox.Name = "mealCombobox";
            mealCombobox.Size = new Size(121, 23);
            mealCombobox.TabIndex = 5;
            // 
            // saladCombobox
            // 
            saladCombobox.FormattingEnabled = true;
            saladCombobox.Location = new Point(224, 119);
            saladCombobox.Name = "saladCombobox";
            saladCombobox.Size = new Size(121, 23);
            saladCombobox.TabIndex = 6;
            // 
            // snackCombobox
            // 
            snackCombobox.FormattingEnabled = true;
            snackCombobox.Location = new Point(427, 119);
            snackCombobox.Name = "snackCombobox";
            snackCombobox.Size = new Size(121, 23);
            snackCombobox.TabIndex = 7;
            // 
            // desertCombobox
            // 
            desertCombobox.FormattingEnabled = true;
            desertCombobox.Location = new Point(624, 119);
            desertCombobox.Name = "desertCombobox";
            desertCombobox.Size = new Size(121, 23);
            desertCombobox.TabIndex = 8;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(desertCombobox);
            Controls.Add(snackCombobox);
            Controls.Add(saladCombobox);
            Controls.Add(mealCombobox);
            Controls.Add(menuTextbox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "v";
            FormClosing += Form4_FormClosing;
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public TextBox menuTextbox;
        private ComboBox mealCombobox;
        private ComboBox saladCombobox;
        private ComboBox snackCombobox;
        private ComboBox desertCombobox;
    }
}