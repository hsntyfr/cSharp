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
            SuspendLayout();
            // 
            // foodLabel
            // 
            foodLabel.AutoSize = true;
            foodLabel.Location = new Point(649, 31);
            foodLabel.Name = "foodLabel";
            foodLabel.Size = new Size(112, 75);
            foodLabel.TabIndex = 3;
            foodLabel.Text = "Food is not selected\r\n1-Salad\r\n2-Meal\r\n3-Snack\r\n4-Desert\r\n";
            // 
            // menuTextbox
            // 
            menuTextbox.Location = new Point(141, 31);
            menuTextbox.Name = "menuTextbox";
            menuTextbox.Size = new Size(413, 23);
            menuTextbox.TabIndex = 4;
            // 
            // foodCombobox
            // 
            foodCombobox.FormattingEnabled = true;
            foodCombobox.Location = new Point(173, 109);
            foodCombobox.Name = "foodCombobox";
            foodCombobox.Size = new Size(121, 23);
            foodCombobox.TabIndex = 6;
            // 
            // foodAddButton
            // 
            foodAddButton.Location = new Point(390, 109);
            foodAddButton.Name = "foodAddButton";
            foodAddButton.Size = new Size(75, 23);
            foodAddButton.TabIndex = 7;
            foodAddButton.Text = "Add";
            foodAddButton.UseVisualStyleBackColor = true;
            foodAddButton.Click += foodAddButton_Click;
            // 
            // showButton
            // 
            showButton.Location = new Point(390, 165);
            showButton.Name = "showButton";
            showButton.Size = new Size(75, 23);
            showButton.TabIndex = 8;
            showButton.Text = "Show";
            showButton.UseVisualStyleBackColor = true;
            showButton.Click += showButton_Click;
            // 
            // editFoodButton
            // 
            editFoodButton.Location = new Point(390, 226);
            editFoodButton.Name = "editFoodButton";
            editFoodButton.Size = new Size(75, 23);
            editFoodButton.TabIndex = 9;
            editFoodButton.Text = "Edit";
            editFoodButton.UseVisualStyleBackColor = true;
            editFoodButton.Click += editFoodButton_Click;
            // 
            // saveFoodButton
            // 
            saveFoodButton.Location = new Point(506, 108);
            saveFoodButton.Name = "saveFoodButton";
            saveFoodButton.Size = new Size(75, 23);
            saveFoodButton.TabIndex = 10;
            saveFoodButton.Text = "Save";
            saveFoodButton.UseVisualStyleBackColor = true;
            saveFoodButton.Click += saveFoodButton_Click;
            // 
            // deleteFoodButton
            // 
            deleteFoodButton.Location = new Point(506, 165);
            deleteFoodButton.Name = "deleteFoodButton";
            deleteFoodButton.Size = new Size(75, 23);
            deleteFoodButton.TabIndex = 11;
            deleteFoodButton.Text = "Delete";
            deleteFoodButton.UseVisualStyleBackColor = true;
            deleteFoodButton.Click += deleteFoodButton_Click;
            // 
            // homeButton
            // 
            homeButton.Location = new Point(506, 226);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(75, 23);
            homeButton.TabIndex = 12;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += homeButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(506, 69);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 13;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}