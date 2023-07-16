namespace project
{
    partial class Form2
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
            homeButton = new Button();
            addFoodButton = new Button();
            removeFoodButton = new Button();
            submitButton = new Button();
            orderCombobox = new ComboBox();
            orderLabel = new Label();
            orderReviewCombobox = new ComboBox();
            SuspendLayout();
            // 
            // homeButton
            // 
            homeButton.BackColor = Color.GreenYellow;
            homeButton.Location = new Point(680, 390);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(75, 23);
            homeButton.TabIndex = 0;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // addFoodButton
            // 
            addFoodButton.BackColor = Color.SkyBlue;
            addFoodButton.Location = new Point(239, 212);
            addFoodButton.Name = "addFoodButton";
            addFoodButton.Size = new Size(75, 23);
            addFoodButton.TabIndex = 1;
            addFoodButton.Text = "Add";
            addFoodButton.UseVisualStyleBackColor = false;
            addFoodButton.Click += addFoodButton_Click;
            // 
            // removeFoodButton
            // 
            removeFoodButton.BackColor = Color.OrangeRed;
            removeFoodButton.Location = new Point(379, 212);
            removeFoodButton.Name = "removeFoodButton";
            removeFoodButton.Size = new Size(75, 23);
            removeFoodButton.TabIndex = 2;
            removeFoodButton.Text = "Remove";
            removeFoodButton.UseVisualStyleBackColor = false;
            removeFoodButton.Click += removeFoodButton_Click;
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.LightGreen;
            submitButton.Location = new Point(512, 212);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 3;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // orderCombobox
            // 
            orderCombobox.FormattingEnabled = true;
            orderCombobox.Location = new Point(204, 97);
            orderCombobox.Name = "orderCombobox";
            orderCombobox.Size = new Size(121, 23);
            orderCombobox.TabIndex = 4;
            // 
            // orderLabel
            // 
            orderLabel.AutoSize = true;
            orderLabel.BackColor = Color.Gray;
            orderLabel.Location = new Point(524, 45);
            orderLabel.Name = "orderLabel";
            orderLabel.Size = new Size(77, 15);
            orderLabel.TabIndex = 5;
            orderLabel.Text = "Order Review";
            // 
            // orderReviewCombobox
            // 
            orderReviewCombobox.FormattingEnabled = true;
            orderReviewCombobox.Location = new Point(502, 97);
            orderReviewCombobox.Name = "orderReviewCombobox";
            orderReviewCombobox.Size = new Size(121, 23);
            orderReviewCombobox.TabIndex = 6;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(orderReviewCombobox);
            Controls.Add(orderLabel);
            Controls.Add(orderCombobox);
            Controls.Add(submitButton);
            Controls.Add(removeFoodButton);
            Controls.Add(addFoodButton);
            Controls.Add(homeButton);
            Name = "Form2";
            Text = "Order";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button homeButton;
        private Button addFoodButton;
        private Button removeFoodButton;
        public ComboBox orderReviewCombobox;
        private Button submitButton;
        public Label orderLabel;
        public ComboBox orderCombobox;
    }
}