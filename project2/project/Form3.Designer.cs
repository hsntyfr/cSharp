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
            materialAddButton = new Button();
            materialLabel = new Label();
            showButton = new Button();
            materialEditButton = new Button();
            saveMaterialButton = new Button();
            deleteMaterialButton = new Button();
            homeButton = new Button();
            clearButton = new Button();
            SuspendLayout();
            // 
            // materialCombobox
            // 
            materialCombobox.FormattingEnabled = true;
            materialCombobox.Location = new Point(245, 115);
            materialCombobox.Name = "materialCombobox";
            materialCombobox.Size = new Size(121, 23);
            materialCombobox.TabIndex = 0;
            materialCombobox.SelectedIndexChanged += materialCombobox_SelectedIndexChanged;
            // 
            // materialTextBox
            // 
            materialTextBox.Location = new Point(125, 45);
            materialTextBox.Name = "materialTextBox";
            materialTextBox.Size = new Size(575, 23);
            materialTextBox.TabIndex = 1;
            // 
            // materialAddButton
            // 
            materialAddButton.BackColor = Color.SkyBlue;
            materialAddButton.Location = new Point(385, 343);
            materialAddButton.Name = "materialAddButton";
            materialAddButton.Size = new Size(75, 23);
            materialAddButton.TabIndex = 2;
            materialAddButton.Text = "Add";
            materialAddButton.UseVisualStyleBackColor = false;
            materialAddButton.Click += materialAddButton_Click;
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.BackColor = Color.Gray;
            materialLabel.Location = new Point(460, 115);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new Size(128, 15);
            materialLabel.TabIndex = 3;
            materialLabel.Text = "Material is not selected";
            // 
            // showButton
            // 
            showButton.BackColor = Color.Aqua;
            showButton.Location = new Point(385, 295);
            showButton.Name = "showButton";
            showButton.Size = new Size(75, 23);
            showButton.TabIndex = 4;
            showButton.Text = "Show";
            showButton.UseVisualStyleBackColor = false;
            showButton.Click += showButton_Click;
            // 
            // materialEditButton
            // 
            materialEditButton.BackColor = Color.LightBlue;
            materialEditButton.Location = new Point(513, 296);
            materialEditButton.Name = "materialEditButton";
            materialEditButton.Size = new Size(75, 23);
            materialEditButton.TabIndex = 5;
            materialEditButton.Text = "Edit";
            materialEditButton.UseVisualStyleBackColor = false;
            materialEditButton.Click += materialEditButton_Click;
            // 
            // saveMaterialButton
            // 
            saveMaterialButton.BackColor = Color.DeepSkyBlue;
            saveMaterialButton.Location = new Point(513, 343);
            saveMaterialButton.Name = "saveMaterialButton";
            saveMaterialButton.Size = new Size(75, 23);
            saveMaterialButton.TabIndex = 6;
            saveMaterialButton.Text = "Save";
            saveMaterialButton.UseVisualStyleBackColor = false;
            saveMaterialButton.Click += saveMaterialButton_Click;
            // 
            // deleteMaterialButton
            // 
            deleteMaterialButton.BackColor = Color.OrangeRed;
            deleteMaterialButton.Location = new Point(245, 343);
            deleteMaterialButton.Name = "deleteMaterialButton";
            deleteMaterialButton.Size = new Size(75, 23);
            deleteMaterialButton.TabIndex = 7;
            deleteMaterialButton.Text = "Delete";
            deleteMaterialButton.UseVisualStyleBackColor = false;
            deleteMaterialButton.Click += deleteMaterialButton_Click;
            // 
            // homeButton
            // 
            homeButton.BackColor = Color.GreenYellow;
            homeButton.Location = new Point(680, 390);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(75, 23);
            homeButton.TabIndex = 8;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = SystemColors.ControlDark;
            clearButton.Location = new Point(245, 295);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 9;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(clearButton);
            Controls.Add(homeButton);
            Controls.Add(deleteMaterialButton);
            Controls.Add(saveMaterialButton);
            Controls.Add(materialEditButton);
            Controls.Add(showButton);
            Controls.Add(materialLabel);
            Controls.Add(materialAddButton);
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
        public Button materialAddButton;
        private Label materialLabel;
        private Button showButton;
        private Button materialEditButton;
        private Button saveMaterialButton;
        private Button deleteMaterialButton;
        private Button homeButton;
        private Button clearButton;
    }
}