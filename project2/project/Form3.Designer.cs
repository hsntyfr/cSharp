namespace project
{
    partial class Form3
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
            materialCombobox = new ComboBox();
            materialTextBox = new TextBox();
            materialsButton = new Button();
            SuspendLayout();
            // 
            // materialCombobox
            // 
            materialCombobox.FormattingEnabled = true;
            materialCombobox.Location = new Point(137, 76);
            materialCombobox.Name = "materialCombobox";
            materialCombobox.Size = new Size(121, 23);
            materialCombobox.TabIndex = 0;
            materialCombobox.SelectedIndexChanged += materialCombobox_SelectedIndexChanged;
            // 
            // materialTextBox
            // 
            materialTextBox.Location = new Point(388, 76);
            materialTextBox.Name = "materialTextBox";
            materialTextBox.Size = new Size(100, 23);
            materialTextBox.TabIndex = 1;
            // 
            // materialsButton
            // 
            materialsButton.Location = new Point(413, 146);
            materialsButton.Name = "materialsButton";
            materialsButton.Size = new Size(75, 23);
            materialsButton.TabIndex = 2;
            materialsButton.Text = "button1";
            materialsButton.UseVisualStyleBackColor = true;
            materialsButton.Click += materialsButton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(materialsButton);
            Controls.Add(materialTextBox);
            Controls.Add(materialCombobox);
            Name = "Form3";
            Text = "Repo";
            FormClosing += Form3_FormClosing;
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ComboBox materialCombobox;
        public TextBox materialTextBox;
        public Button materialsButton;
    }
}