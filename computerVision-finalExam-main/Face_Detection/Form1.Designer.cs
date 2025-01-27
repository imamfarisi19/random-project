﻿namespace Face_Detection
{
    partial class Form1
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
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.detectFaceHaarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.detectFaceLBPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.menuStrip1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // menuStrip1
         // 
         this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
         this.menuStrip1.Size = new System.Drawing.Size(561, 24);
         this.menuStrip1.TabIndex = 0;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.detectFaceHaarToolStripMenuItem,
            this.detectFaceLBPToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "File";
         // 
         // openToolStripMenuItem
         // 
         this.openToolStripMenuItem.Name = "openToolStripMenuItem";
         this.openToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
         this.openToolStripMenuItem.Text = "Open";
         this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
         // 
         // detectFaceHaarToolStripMenuItem
         // 
         this.detectFaceHaarToolStripMenuItem.Name = "detectFaceHaarToolStripMenuItem";
         this.detectFaceHaarToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
         this.detectFaceHaarToolStripMenuItem.Text = "Detect Face Haar";
         this.detectFaceHaarToolStripMenuItem.Click += new System.EventHandler(this.detectFaceHaarToolStripMenuItem_Click);
         // 
         // detectFaceLBPToolStripMenuItem
         // 
         this.detectFaceLBPToolStripMenuItem.Name = "detectFaceLBPToolStripMenuItem";
         this.detectFaceLBPToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
         this.detectFaceLBPToolStripMenuItem.Text = "Detect Face LBP";
         this.detectFaceLBPToolStripMenuItem.Click += new System.EventHandler(this.detectFaceLBPToolStripMenuItem_Click);
         // 
         // pictureBox1
         // 
         this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.pictureBox1.Location = new System.Drawing.Point(0, 24);
         this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(561, 360);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 1;
         this.pictureBox1.TabStop = false;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(561, 384);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.menuStrip1);
         this.MainMenuStrip = this.menuStrip1;
         this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Face Detection";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detectFaceHaarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detectFaceLBPToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

