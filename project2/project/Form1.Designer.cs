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
            label1 = new Label();
            exitButton = new Button();
            SuspendLayout();
            // 
            // orderTabOpenButton
            // 
            orderTabOpenButton.BackColor = Color.Pink;
            orderTabOpenButton.Location = new Point(150, 245);
            orderTabOpenButton.Name = "orderTabOpenButton";
            orderTabOpenButton.Size = new Size(75, 23);
            orderTabOpenButton.TabIndex = 1;
            orderTabOpenButton.Text = "Order";
            orderTabOpenButton.UseVisualStyleBackColor = false;
            orderTabOpenButton.Click += orderTabOpenButton_Click;
            // 
            // menuTabOpenButton
            // 
            menuTabOpenButton.BackColor = Color.Pink;
            menuTabOpenButton.Location = new Point(597, 245);
            menuTabOpenButton.Name = "menuTabOpenButton";
            menuTabOpenButton.Size = new Size(75, 23);
            menuTabOpenButton.TabIndex = 2;
            menuTabOpenButton.Text = "Menu";
            menuTabOpenButton.UseVisualStyleBackColor = false;
            menuTabOpenButton.Click += menuTabOpenButton_Click;
            // 
            // repoTabOpenButton
            // 
            repoTabOpenButton.BackColor = Color.Pink;
            repoTabOpenButton.Location = new Point(379, 245);
            repoTabOpenButton.Name = "repoTabOpenButton";
            repoTabOpenButton.Size = new Size(75, 23);
            repoTabOpenButton.TabIndex = 3;
            repoTabOpenButton.Text = "Repo";
            repoTabOpenButton.UseVisualStyleBackColor = false;
            repoTabOpenButton.Click += repoTabOpenButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(323, 116);
            label1.Name = "label1";
            label1.Size = new Size(178, 15);
            label1.TabIndex = 4;
            label1.Text = "Restaurant Management System";
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.OrangeRed;
            exitButton.Location = new Point(688, 395);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 5;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(label1);
            Controls.Add(repoTabOpenButton);
            Controls.Add(menuTabOpenButton);
            Controls.Add(orderTabOpenButton);
            Name = "Form1";
            Text = "Restaurant Management System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button orderTabOpenButton;
        private Button menuTabOpenButton;
        private Button repoTabOpenButton;
        private Label label1;
        private Button exitButton;
    }
}