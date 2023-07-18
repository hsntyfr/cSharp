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
            foodLabel = new Label();
            menuTextbox = new TextBox();
            foodCombobox = new ComboBox();
            foodAddButton = new Button();
            showButton = new Button();
            editFoodButton = new Button();
            saveFoodButton = new Button();
            deleteFoodButton = new Button();
            homeButton = new Button();
            clearButton = new Button();
            foodReportCombobox = new ComboBox();
            getReportButton = new Button();
            SuspendLayout();
            // 
            // foodLabel
            // 
            foodLabel.AutoSize = true;
            foodLabel.BackColor = Color.Gray;
            foodLabel.Location = new Point(460, 115);
            foodLabel.Name = "foodLabel";
            foodLabel.Size = new Size(112, 75);
            foodLabel.TabIndex = 3;
            foodLabel.Text = "Food is not selected\r\n1-Salad\r\n2-Meal\r\n3-Snack\r\n4-Desert\r\n";
            // 
            // menuTextbox
            // 
            menuTextbox.Location = new Point(125, 45);
            menuTextbox.Name = "menuTextbox";
            menuTextbox.Size = new Size(575, 23);
            menuTextbox.TabIndex = 4;
            // 
            // foodCombobox
            // 
            foodCombobox.FormattingEnabled = true;
            foodCombobox.Location = new Point(245, 115);
            foodCombobox.Name = "foodCombobox";
            foodCombobox.Size = new Size(121, 23);
            foodCombobox.TabIndex = 6;
            // 
            // foodAddButton
            // 
            foodAddButton.BackColor = Color.SkyBlue;
            foodAddButton.Location = new Point(358, 281);
            foodAddButton.Name = "foodAddButton";
            foodAddButton.Size = new Size(75, 23);
            foodAddButton.TabIndex = 7;
            foodAddButton.Text = "Add";
            foodAddButton.UseVisualStyleBackColor = false;
            foodAddButton.Click += foodAddButton_Click;
            // 
            // showButton
            // 
            showButton.BackColor = Color.Aqua;
            showButton.Location = new Point(358, 233);
            showButton.Name = "showButton";
            showButton.Size = new Size(75, 23);
            showButton.TabIndex = 8;
            showButton.Text = "Show";
            showButton.UseVisualStyleBackColor = false;
            showButton.Click += showButton_Click;
            // 
            // editFoodButton
            // 
            editFoodButton.BackColor = Color.LightBlue;
            editFoodButton.Location = new Point(497, 233);
            editFoodButton.Name = "editFoodButton";
            editFoodButton.Size = new Size(75, 23);
            editFoodButton.TabIndex = 9;
            editFoodButton.Text = "Edit";
            editFoodButton.UseVisualStyleBackColor = false;
            editFoodButton.Click += editFoodButton_Click;
            // 
            // saveFoodButton
            // 
            saveFoodButton.BackColor = Color.DeepSkyBlue;
            saveFoodButton.Location = new Point(497, 281);
            saveFoodButton.Name = "saveFoodButton";
            saveFoodButton.Size = new Size(75, 23);
            saveFoodButton.TabIndex = 10;
            saveFoodButton.Text = "Save";
            saveFoodButton.UseVisualStyleBackColor = false;
            saveFoodButton.Click += saveFoodButton_Click;
            // 
            // deleteFoodButton
            // 
            deleteFoodButton.BackColor = Color.OrangeRed;
            deleteFoodButton.Location = new Point(217, 281);
            deleteFoodButton.Name = "deleteFoodButton";
            deleteFoodButton.Size = new Size(75, 23);
            deleteFoodButton.TabIndex = 11;
            deleteFoodButton.Text = "Delete";
            deleteFoodButton.UseVisualStyleBackColor = false;
            deleteFoodButton.Click += deleteFoodButton_Click;
            // 
            // homeButton
            // 
            homeButton.BackColor = Color.GreenYellow;
            homeButton.Location = new Point(680, 390);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(75, 23);
            homeButton.TabIndex = 12;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = SystemColors.ControlDark;
            clearButton.Location = new Point(217, 233);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 13;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // foodReportCombobox
            // 
            foodReportCombobox.FormattingEnabled = true;
            foodReportCombobox.Items.AddRange(new object[] { "Price low to high", "Price high to low", "Tax low to high", "Tax high to low" });
            foodReportCombobox.Location = new Point(265, 353);
            foodReportCombobox.Name = "foodReportCombobox";
            foodReportCombobox.Size = new Size(121, 23);
            foodReportCombobox.TabIndex = 14;
            // 
            // getReportButton
            // 
            getReportButton.BackColor = Color.Silver;
            getReportButton.Location = new Point(432, 353);
            getReportButton.Name = "getReportButton";
            getReportButton.Size = new Size(75, 23);
            getReportButton.TabIndex = 15;
            getReportButton.Text = "Get Report";
            getReportButton.UseVisualStyleBackColor = false;
            getReportButton.Click += getReportButton_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(getReportButton);
            Controls.Add(foodReportCombobox);
            Controls.Add(clearButton);
            Controls.Add(homeButton);
            Controls.Add(deleteFoodButton);
            Controls.Add(saveFoodButton);
            Controls.Add(editFoodButton);
            Controls.Add(showButton);
            Controls.Add(foodAddButton);
            Controls.Add(foodCombobox);
            Controls.Add(menuTextbox);
            Controls.Add(foodLabel);
            Name = "Form4";
            Text = "Menu";
            FormClosing += Form4_FormClosing;
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label foodLabel;
        public TextBox menuTextbox;
        private ComboBox foodCombobox;
        private Button foodAddButton;
        private Button showButton;
        private Button editFoodButton;
        private Button saveFoodButton;
        private Button deleteFoodButton;
        private Button homeButton;
        private Button clearButton;
        private ComboBox foodReportCombobox;
        private Button getReportButton;
    }
}