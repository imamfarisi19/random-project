namespace UTS_P9_VKPC
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
         this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
         this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.flipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.vertikalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.bottomSobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.embossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.identityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.leftSobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.outlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.rightSobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.topSobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.pictureBox2 = new System.Windows.Forms.PictureBox();
         this.menuStrip1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
         this.SuspendLayout();
         // 
         // openFileDialog1
         // 
         this.openFileDialog1.FileName = "openFileDialog1";
         // 
         // saveFileDialog1
         // 
         this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.flipToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.exitToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(449, 24);
         this.menuStrip1.TabIndex = 0;
         this.menuStrip1.Text = "menuStrip1";
         this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "File";
         // 
         // openToolStripMenuItem
         // 
         this.openToolStripMenuItem.Name = "openToolStripMenuItem";
         this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
         this.openToolStripMenuItem.Text = "Open";
         this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
         // 
         // saveToolStripMenuItem
         // 
         this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
         this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
         this.saveToolStripMenuItem.Text = "Save";
         this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
         // 
         // clearToolStripMenuItem
         // 
         this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
         this.clearToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
         this.clearToolStripMenuItem.Text = "Clear";
         this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
         // 
         // flipToolStripMenuItem
         // 
         this.flipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.vertikalToolStripMenuItem});
         this.flipToolStripMenuItem.Name = "flipToolStripMenuItem";
         this.flipToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
         this.flipToolStripMenuItem.Text = "Position";
         this.flipToolStripMenuItem.Click += new System.EventHandler(this.flipToolStripMenuItem_Click);
         // 
         // normalToolStripMenuItem
         // 
         this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
         this.normalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
         this.normalToolStripMenuItem.Text = "Normal";
         this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
         // 
         // horizontalToolStripMenuItem
         // 
         this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
         this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
         this.horizontalToolStripMenuItem.Text = "Horizontal";
         this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
         // 
         // vertikalToolStripMenuItem
         // 
         this.vertikalToolStripMenuItem.Name = "vertikalToolStripMenuItem";
         this.vertikalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
         this.vertikalToolStripMenuItem.Text = "Vertical";
         this.vertikalToolStripMenuItem.Click += new System.EventHandler(this.vertikalToolStripMenuItem_Click);
         // 
         // operationsToolStripMenuItem
         // 
         this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
         this.operationsToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
         this.operationsToolStripMenuItem.Text = "Operation";
         this.operationsToolStripMenuItem.Click += new System.EventHandler(this.operationsToolStripMenuItem_Click);
         // 
         // filterToolStripMenuItem
         // 
         this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem,
            this.bottomSobelToolStripMenuItem,
            this.embossToolStripMenuItem,
            this.identityToolStripMenuItem,
            this.leftSobelToolStripMenuItem,
            this.outlineToolStripMenuItem,
            this.rightSobelToolStripMenuItem,
            this.sharpenToolStripMenuItem,
            this.topSobelToolStripMenuItem});
         this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
         this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
         this.filterToolStripMenuItem.Text = "Filter";
         // 
         // blurToolStripMenuItem
         // 
         this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
         this.blurToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
         this.blurToolStripMenuItem.Text = "Blur";
         this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
         // 
         // bottomSobelToolStripMenuItem
         // 
         this.bottomSobelToolStripMenuItem.Name = "bottomSobelToolStripMenuItem";
         this.bottomSobelToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
         this.bottomSobelToolStripMenuItem.Text = "Bottom Sobel";
         this.bottomSobelToolStripMenuItem.Click += new System.EventHandler(this.bottomSobelToolStripMenuItem_Click);
         // 
         // embossToolStripMenuItem
         // 
         this.embossToolStripMenuItem.Name = "embossToolStripMenuItem";
         this.embossToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
         this.embossToolStripMenuItem.Text = "Emboss";
         this.embossToolStripMenuItem.Click += new System.EventHandler(this.embossToolStripMenuItem_Click);
         // 
         // identityToolStripMenuItem
         // 
         this.identityToolStripMenuItem.Name = "identityToolStripMenuItem";
         this.identityToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
         this.identityToolStripMenuItem.Text = "Identity";
         this.identityToolStripMenuItem.Click += new System.EventHandler(this.identityToolStripMenuItem_Click);
         // 
         // leftSobelToolStripMenuItem
         // 
         this.leftSobelToolStripMenuItem.Name = "leftSobelToolStripMenuItem";
         this.leftSobelToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
         this.leftSobelToolStripMenuItem.Text = "Left Sobel";
         this.leftSobelToolStripMenuItem.Click += new System.EventHandler(this.leftSobelToolStripMenuItem_Click);
         // 
         // outlineToolStripMenuItem
         // 
         this.outlineToolStripMenuItem.Name = "outlineToolStripMenuItem";
         this.outlineToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
         this.outlineToolStripMenuItem.Text = "Outline";
         this.outlineToolStripMenuItem.Click += new System.EventHandler(this.outlineToolStripMenuItem_Click);
         // 
         // rightSobelToolStripMenuItem
         // 
         this.rightSobelToolStripMenuItem.Name = "rightSobelToolStripMenuItem";
         this.rightSobelToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
         this.rightSobelToolStripMenuItem.Text = "Right Sobel";
         this.rightSobelToolStripMenuItem.Click += new System.EventHandler(this.rightSobelToolStripMenuItem_Click);
         // 
         // sharpenToolStripMenuItem
         // 
         this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
         this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
         this.sharpenToolStripMenuItem.Text = "Sharpen";
         this.sharpenToolStripMenuItem.Click += new System.EventHandler(this.sharpenToolStripMenuItem_Click);
         // 
         // topSobelToolStripMenuItem
         // 
         this.topSobelToolStripMenuItem.Name = "topSobelToolStripMenuItem";
         this.topSobelToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
         this.topSobelToolStripMenuItem.Text = "Top Sobel";
         this.topSobelToolStripMenuItem.Click += new System.EventHandler(this.topSobelToolStripMenuItem_Click);
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.exitToolStripMenuItem.Text = "Exit";
         this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
         // 
         // pictureBox1
         // 
         this.pictureBox1.Location = new System.Drawing.Point(12, 36);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(200, 163);
         this.pictureBox1.TabIndex = 1;
         this.pictureBox1.TabStop = false;
         // 
         // pictureBox2
         // 
         this.pictureBox2.Location = new System.Drawing.Point(233, 36);
         this.pictureBox2.Name = "pictureBox2";
         this.pictureBox2.Size = new System.Drawing.Size(200, 163);
         this.pictureBox2.TabIndex = 2;
         this.pictureBox2.TabStop = false;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(449, 208);
         this.Controls.Add(this.pictureBox2);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.menuStrip1);
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Main Menu - Simple Application of Image Processing";
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vertikalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomSobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftSobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightSobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topSobelToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

