namespace project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            orderTabOpenButton = new Button();
            menuTabOpenButton = new Button();
            repoTabOpenButton = new Button();
            SuspendLayout();
            // 
            // orderTabOpenButton
            // 
            orderTabOpenButton.Location = new Point(147, 123);
            orderTabOpenButton.Name = "orderTabOpenButton";
            orderTabOpenButton.Size = new Size(75, 23);
            orderTabOpenButton.TabIndex = 1;
            orderTabOpenButton.Text = "Order";
            orderTabOpenButton.UseVisualStyleBackColor = true;
            orderTabOpenButton.Click += orderTabOpenButton_Click;
            // 
            // menuTabOpenButton
            // 
            menuTabOpenButton.Location = new Point(594, 123);
            menuTabOpenButton.Name = "menuTabOpenButton";
            menuTabOpenButton.Size = new Size(75, 23);
            menuTabOpenButton.TabIndex = 2;
            menuTabOpenButton.Text = "Menu";
            menuTabOpenButton.UseVisualStyleBackColor = true;
            menuTabOpenButton.Click += menuTabOpenButton_Click;
            // 
            // repoTabOpenButton
            // 
            repoTabOpenButton.Location = new Point(376, 123);
            repoTabOpenButton.Name = "repoTabOpenButton";
            repoTabOpenButton.Size = new Size(75, 23);
            repoTabOpenButton.TabIndex = 3;
            repoTabOpenButton.Text = "Repo";
            repoTabOpenButton.UseVisualStyleBackColor = true;
            repoTabOpenButton.Click += repoTabOpenButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(repoTabOpenButton);
            Controls.Add(menuTabOpenButton);
            Controls.Add(orderTabOpenButton);
            Name = "Form1";
            Text = "Restaurant Management System";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button orderTabOpenButton;
        private Button menuTabOpenButton;
        private Button repoTabOpenButton;
    }
}