﻿namespace project
{
    partial class Form5
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
            okayButton = new Button();
            backButton = new Button();
            orderReviewLabel = new Label();
            SuspendLayout();
            // 
            // okayButton
            // 
            okayButton.BackColor = Color.GreenYellow;
            okayButton.Location = new Point(424, 302);
            okayButton.Name = "okayButton";
            okayButton.Size = new Size(75, 23);
            okayButton.TabIndex = 0;
            okayButton.Text = "Okay";
            okayButton.UseVisualStyleBackColor = false;
            okayButton.Click += okayButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.OrangeRed;
            backButton.Location = new Point(322, 302);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 1;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // orderReviewLabel
            // 
            orderReviewLabel.AutoSize = true;
            orderReviewLabel.BackColor = Color.Gray;
            orderReviewLabel.Location = new Point(322, 143);
            orderReviewLabel.Name = "orderReviewLabel";
            orderReviewLabel.Size = new Size(0, 15);
            orderReviewLabel.TabIndex = 2;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(orderReviewLabel);
            Controls.Add(backButton);
            Controls.Add(okayButton);
            Name = "Form5";
            Text = "Order Review";
            FormClosing += Form5_FormClosing;
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okayButton;
        private Button backButton;
        public Label orderReviewLabel;
    }
}