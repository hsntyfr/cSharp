﻿namespace project
{
    partial class Form6
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
            reportRichTextbox = new RichTextBox();
            SuspendLayout();
            // 
            // reportRichTextbox
            // 
            reportRichTextbox.Location = new Point(0, 0);
            reportRichTextbox.Name = "reportRichTextbox";
            reportRichTextbox.Size = new Size(788, 450);
            reportRichTextbox.TabIndex = 0;
            reportRichTextbox.Text = "";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reportRichTextbox);
            Name = "Form6";
            Text = "Report";
            FormClosing += Form6_FormClosing;
            Load += Form6_Load;
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        public RichTextBox reportRichTextbox;
    }
}