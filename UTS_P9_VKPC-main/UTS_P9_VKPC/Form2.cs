using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_P9_VKPC
{
   public partial class Form2 : Form
   {
      Bitmap objBitmap;
      Bitmap objBitmap1;

      public Form2()
      {
         InitializeComponent();
      }
      
      private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
      {

      }

      private void additionToolStripMenuItem_Click(object sender, EventArgs e)
      {
         int ntot, ntest, nmax2;
         decimal n1, n2, n2a;

         Bitmap b1 = new Bitmap(pictureBox1.Image);
         Bitmap b2 = new Bitmap(pictureBox2.Image);
         Bitmap b3 = new Bitmap(pictureBox2.Image);

         pictureBox1.Image = b1; 
         pictureBox2.Image = b2;

         numericUpDown1.Minimum = 0; 
         numericUpDown1.Maximum = 100; 
         numericUpDown2.Minimum = 0; 
         numericUpDown2.Maximum = 100; 

         ntest = (int)numericUpDown1.Value;
         nmax2 = (int)numericUpDown2.Maximum;

         n1 = (decimal)numericUpDown1.Value/100; 
         n2 = (decimal)numericUpDown2.Maximum/100;
         
         if (ntest > 50) 
         { 
            ntot =(int)(nmax2 - n1 * 100);
            n2a = (decimal)ntot / 100;            
            n2 = n2a;
         }
         if (ntest == 50)
         {
            ntot = (int)(nmax2 - n1 * 100);
            n2a = (decimal)ntot / 100;
            n2 = n2a;
         }
         if (ntest < 50)
         {
            ntot = (int)(nmax2 - n1 * 100);
            n2a = (decimal)ntot / 100;
            n2 = n2a;
         }

         if (b1.Width <= 300 && b1.Height <= 300 && b2.Width <= 300 && b2.Height <= 300) 
         {
            if (n1 >= 0 && n1 <= 100 && numericUpDown2.Value >= 0 && numericUpDown2.Value <=100) {
               for (int x = 0; x < b1.Width && x < b2.Width; x++)
                  for (int y = 0; y < b1.Height && y < b2.Height; y++)
                  {
                     Color c1 = b1.GetPixel(x, y);
                     Color c2 = b2.GetPixel(x, y);
                     int red = (int)(c1.R * n1 + c2.R * n2);
                     int green = (int)(c1.G * n1 + c2.G * n2);
                     int blue = (int)(c1.B * n1 + c2.B * n2);
                     Color nc1 = Color.FromArgb(red, green, blue);
                     b3.SetPixel(x, y, nc1);
                  }
               pictureBox3.Image = b3;
               numericUpDown2.Value = n2;
            }
            else
            {
               //numericUpDown2.Value = 0;
               MessageBox.Show("numericUpDown.Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
         }
         else 
         {
            MessageBox.Show("Picture is over than 300 x 300px", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         }
      }
      

      private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
      {

      }

      private void saveToolStripMenuItem_Click(object sender, EventArgs e)
      {
         DialogResult d = saveFileDialog1.ShowDialog();
         if (d == DialogResult.OK)
         {
            pictureBox3.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
         }
      }

      private void clearToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Image pic1 = pictureBox1.Image;
         Image pic2 = pictureBox2.Image;
         if (pic1 != null || pic2 != null)
         {
            pictureBox1.Image = null;
            pictureBox1.Invalidate();

            pictureBox2.Image = null;
            pictureBox2.Invalidate();

            pictureBox3.Image = null;
            pictureBox3.Invalidate();
         }
         else
         {
            MessageBox.Show("No Picture", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         }
      }

      private void exitToolStripMenuItem_Click(object sender, EventArgs e)
      {
         
      }

      private void stImageToolStripMenuItem_Click(object sender, EventArgs e)
      {
         DialogResult d1 = openFileDialog1.ShowDialog();
         if (d1 == DialogResult.OK)
         {
            objBitmap = new Bitmap(openFileDialog1.FileName);
            if (objBitmap.Width <= 300 && objBitmap.Height <= 300)
            {
               pictureBox1.Image = objBitmap;
            }
            else
            {
               MessageBox.Show("The picture size was over than 300 x 300 px", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
         }
      }

      private void image2ToolStripMenuItem_Click(object sender, EventArgs e)
      {
         DialogResult d2 = openFileDialog1.ShowDialog();
         if (d2 == DialogResult.OK)
         {
            objBitmap1 = new Bitmap(openFileDialog1.FileName);
            if (objBitmap1.Width <= 300 && objBitmap.Height <= 300)
            {
               pictureBox2.Image = objBitmap1;
            }
            else
            {
               MessageBox.Show("The picture size was over than 300 x 300 px", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
         }
      }

      private void numericUpDown1_ValueChanged(object sender, EventArgs e)
      {

         decimal a = 100 - numericUpDown1.Value;
         label5.Text = a.ToString();
      }

      private void numericUpDown2_ValueChanged(object sender, EventArgs e)
      {

      }

      private void templateToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Bitmap b1 = new Bitmap("C:/Users/USER/source/repos/UTS_P9_VKPC/Images/adam - small - Copy.jpg");
         Bitmap b2 = new Bitmap("C:/Users/USER/source/repos/UTS_P9_VKPC/Images/squirrel-small - Copy.jpg");
        
         pictureBox1.Image = b1;
         pictureBox2.Image = b2;
      }

      private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
      {
         this.Hide();
         Form1 form1 = new Form1();
         form1.Show();
      }

      private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
      {
         Environment.Exit(1);
      }

      private void Form2_Load(object sender, EventArgs e)
      {
         numericUpDown2.Hide();
      }

      private void subtractionToolStripMenuItem_Click(object sender, EventArgs e)
      {

      }
   }
}
