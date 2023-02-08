using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_P9_VKPC
{
   public partial class Form1 : Form
   {
      
      Bitmap objBitmap;
      Bitmap objBitmap1;
      


      public Form1()
      {
         InitializeComponent();
      }

      private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
      {
         objBitmap1 = new Bitmap(objBitmap);
         for (int x = 0; x < objBitmap.Width; x++)
            for (int y = 0; y < objBitmap.Height; y++)
            {
               Color w = objBitmap.GetPixel(x, y);
               objBitmap1.SetPixel( objBitmap.Width-1-x, y, w);
            }
         pictureBox2.Image = objBitmap1;
      }

      private void openToolStripMenuItem_Click(object sender, EventArgs e)
      {
         DialogResult d = openFileDialog1.ShowDialog();
         if (d == DialogResult.OK)
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

      private void saveToolStripMenuItem_Click(object sender, EventArgs e)
      {
         DialogResult d = saveFileDialog1.ShowDialog();
         if (d == DialogResult.OK)
         {
           objBitmap1.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
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
         }
         else
         {
            MessageBox.Show("No Picture", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         }
      }

      private void vertikalToolStripMenuItem_Click(object sender, EventArgs e)
      {
         objBitmap1 = new Bitmap(objBitmap);
         for (int x = 0; x < objBitmap.Width; x++)
            for (int y = 0; y < objBitmap.Height; y++)
            {
               Color w = objBitmap.GetPixel(x, y);
               objBitmap1.SetPixel( x, objBitmap.Height - 1 - y, w);
            }         
         pictureBox2.Image = objBitmap1;
      }

      private void normalToolStripMenuItem_Click(object sender, EventArgs e)
      {
         pictureBox2.Image = objBitmap;
      }

      private void AdditionToolStripMenuItem_Click(object sender, EventArgs e)
      {

      }

      private void flipToolStripMenuItem_Click(object sender, EventArgs e)
      {

      }

      private void operationsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         this.Hide();
         Form2 form2 = new Form2();
         form2.Show();
      }

      private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
      {

      }

      private void exitToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Environment.Exit(1);
      }

      private void blurToolStripMenuItem_Click(object sender, EventArgs e)
      {
         float[] a = new float[10];
         a[1] = (float)0.0625;
         a[2] = (float)0.125;
         a[3] = (float)0.0625;
         a[4] = (float)0.125;
         a[5] = (float)0.25;
         a[6] = (float)0.125;
         a[7] = (float)0.0625;
         a[8] = (float)0.125;
         a[9] = (float)0.0625;
         objBitmap1 = new Bitmap(objBitmap);
         for (int x = 1; x < objBitmap.Width - 1; x++)
            for (int y = 1; y < objBitmap.Height - 1; y++)
            {
               Color w1 = objBitmap.GetPixel(x - 1, y - 1);
               Color w2 = objBitmap.GetPixel(x - 1, y);
               Color w3 = objBitmap.GetPixel(x - 1, y + 1);
               Color w4 = objBitmap.GetPixel(x, y - 1);
               Color w5 = objBitmap.GetPixel(x, y);
               Color w6 = objBitmap.GetPixel(x, y + 1);
               Color w7 = objBitmap.GetPixel(x + 1, y - 1);
               Color w8 = objBitmap.GetPixel(x + 1, y);
               Color w9 = objBitmap.GetPixel(x + 1, y + 1);
               int x1 = w1.R;
               int x2 = w2.R;
               int x3 = w3.R;
               int x4 = w4.R;
               int x5 = w5.R;
               int x6 = w6.R;
               int x7 = w7.R;
               int x8 = w8.R;
               int x9 = w9.R;
               int xb = (int)(a[1] * x1 + a[2] * x2 + a[3] * x3);
               xb = (int)(xb + a[4] * x4 + a[5] * x5 + a[6] * x6);
               xb = (int)(xb + a[7] * x7 + a[8] * x8 + a[9] * x9);
               if (xb < 0)
               {
                  xb = 0;
               }
               if (xb > 255)
               {
                  xb = 255;
               }
               Color wb = Color.FromArgb(xb, xb, xb);
               objBitmap1.SetPixel(x, y, wb);
            }
         pictureBox2.Image = objBitmap1;
      }      

      private void bottomSobelToolStripMenuItem_Click(object sender, EventArgs e)
      {
         float[] a = new float[10];
         a[1] = (float)-1;
         a[2] = (float)-2;
         a[3] = (float)-1;
         a[4] = (float)0;
         a[5] = (float)0;
         a[6] = (float)0;
         a[7] = (float)1;
         a[8] = (float)2;
         a[9] = (float)1;
         objBitmap1 = new Bitmap(objBitmap);
         for (int x = 1; x < objBitmap.Width - 1; x++)
            for (int y = 1; y < objBitmap.Height - 1; y++)
            {
               Color w1 = objBitmap.GetPixel(x - 1, y - 1);
               Color w2 = objBitmap.GetPixel(x - 1, y);
               Color w3 = objBitmap.GetPixel(x - 1, y + 1);
               Color w4 = objBitmap.GetPixel(x, y - 1);
               Color w5 = objBitmap.GetPixel(x, y);
               Color w6 = objBitmap.GetPixel(x, y + 1);
               Color w7 = objBitmap.GetPixel(x + 1, y - 1);
               Color w8 = objBitmap.GetPixel(x + 1, y);
               Color w9 = objBitmap.GetPixel(x + 1, y + 1);
               int x1 = w1.R;
               int x2 = w2.R;
               int x3 = w3.R;
               int x4 = w4.R;
               int x5 = w5.R;
               int x6 = w6.R;
               int x7 = w7.R;
               int x8 = w8.R;
               int x9 = w9.R;
               int xb = (int)(a[1] * x1 + a[2] * x2 + a[3] * x3);
               xb = (int)(xb + a[4] * x4 + a[5] * x5 + a[6] * x6);
               xb = (int)(xb + a[7] * x7 + a[8] * x8 + a[9] * x9);
               if (xb < 0)
               {
                  xb = 0;
               }
               if (xb > 255)
               {
                  xb = 255;
               }
               Color wb = Color.FromArgb(xb, xb, xb);
               objBitmap1.SetPixel(x, y, wb);
            }
         pictureBox2.Image = objBitmap1;
      }

      private void embossToolStripMenuItem_Click(object sender, EventArgs e)
      {
         float[] a = new float[10];
         a[1] = (float)-2;
         a[2] = (float)-1;
         a[3] = (float)0;
         a[4] = (float)-1;
         a[5] = (float)1;
         a[6] = (float)1;
         a[7] = (float)0;
         a[8] = (float)1;
         a[9] = (float)2;
         objBitmap1 = new Bitmap(objBitmap);
         for (int x = 1; x < objBitmap.Width - 1; x++)
            for (int y = 1; y < objBitmap.Height - 1; y++)
            {
               Color w1 = objBitmap.GetPixel(x - 1, y - 1);
               Color w2 = objBitmap.GetPixel(x - 1, y);
               Color w3 = objBitmap.GetPixel(x - 1, y + 1);
               Color w4 = objBitmap.GetPixel(x, y - 1);
               Color w5 = objBitmap.GetPixel(x, y);
               Color w6 = objBitmap.GetPixel(x, y + 1);
               Color w7 = objBitmap.GetPixel(x + 1, y - 1);
               Color w8 = objBitmap.GetPixel(x + 1, y);
               Color w9 = objBitmap.GetPixel(x + 1, y + 1);
               int x1 = w1.R;
               int x2 = w2.R;
               int x3 = w3.R;
               int x4 = w4.R;
               int x5 = w5.R;
               int x6 = w6.R;
               int x7 = w7.R;
               int x8 = w8.R;
               int x9 = w9.R;
               int xb = (int)(a[1] * x1 + a[2] * x2 + a[3] * x3);
               xb = (int)(xb + a[4] * x4 + a[5] * x5 + a[6] * x6);
               xb = (int)(xb + a[7] * x7 + a[8] * x8 + a[9] * x9);
               if (xb < 0)
               {
                  xb = 0;
               }
               if (xb > 255)
               {
                  xb = 255;
               }
               Color wb = Color.FromArgb(xb, xb, xb);
               objBitmap1.SetPixel(x, y, wb);
            }
         pictureBox2.Image = objBitmap1;
      }

      private void identityToolStripMenuItem_Click(object sender, EventArgs e)
      {
         float[] a = new float[10];
         a[1] = (float)0;
         a[2] = (float)0;
         a[3] = (float)0;
         a[4] = (float)0;
         a[5] = (float)1;
         a[6] = (float)0;
         a[7] = (float)0;
         a[8] = (float)0;
         a[9] = (float)0;
         objBitmap1 = new Bitmap(objBitmap);
         for (int x = 1; x < objBitmap.Width - 1; x++)
            for (int y = 1; y < objBitmap.Height - 1; y++)
            {
               Color w1 = objBitmap.GetPixel(x - 1, y - 1);
               Color w2 = objBitmap.GetPixel(x - 1, y);
               Color w3 = objBitmap.GetPixel(x - 1, y + 1);
               Color w4 = objBitmap.GetPixel(x, y - 1);
               Color w5 = objBitmap.GetPixel(x, y);
               Color w6 = objBitmap.GetPixel(x, y + 1);
               Color w7 = objBitmap.GetPixel(x + 1, y - 1);
               Color w8 = objBitmap.GetPixel(x + 1, y);
               Color w9 = objBitmap.GetPixel(x + 1, y + 1);
               int x1 = w1.R;
               int x2 = w2.R;
               int x3 = w3.R;
               int x4 = w4.R;
               int x5 = w5.R;
               int x6 = w6.R;
               int x7 = w7.R;
               int x8 = w8.R;
               int x9 = w9.R;
               int xb = (int)(a[1] * x1 + a[2] * x2 + a[3] * x3);
               xb = (int)(xb + a[4] * x4 + a[5] * x5 + a[6] * x6);
               xb = (int)(xb + a[7] * x7 + a[8] * x8 + a[9] * x9);
               if (xb < 0)
               {
                  xb = 0;
               }
               if (xb > 255)
               {
                  xb = 255;
               }
               Color wb = Color.FromArgb(xb, xb, xb);
               objBitmap1.SetPixel(x, y, wb);
            }
         pictureBox2.Image = objBitmap1;
      }

      private void leftSobelToolStripMenuItem_Click(object sender, EventArgs e)
      {
         float[] a = new float[10];
         a[1] = (float)1;
         a[2] = (float)0;
         a[3] = (float)-1;
         a[4] = (float)2;
         a[5] = (float)0;
         a[6] = (float)-2;
         a[7] = (float)1;
         a[8] = (float)0;
         a[9] = (float)-1;
         objBitmap1 = new Bitmap(objBitmap);
         for (int x = 1; x < objBitmap.Width - 1; x++)
            for (int y = 1; y < objBitmap.Height - 1; y++)
            {
               Color w1 = objBitmap.GetPixel(x - 1, y - 1);
               Color w2 = objBitmap.GetPixel(x - 1, y);
               Color w3 = objBitmap.GetPixel(x - 1, y + 1);
               Color w4 = objBitmap.GetPixel(x, y - 1);
               Color w5 = objBitmap.GetPixel(x, y);
               Color w6 = objBitmap.GetPixel(x, y + 1);
               Color w7 = objBitmap.GetPixel(x + 1, y - 1);
               Color w8 = objBitmap.GetPixel(x + 1, y);
               Color w9 = objBitmap.GetPixel(x + 1, y + 1);
               int x1 = w1.R;
               int x2 = w2.R;
               int x3 = w3.R;
               int x4 = w4.R;
               int x5 = w5.R;
               int x6 = w6.R;
               int x7 = w7.R;
               int x8 = w8.R;
               int x9 = w9.R;
               int xb = (int)(a[1] * x1 + a[2] * x2 + a[3] * x3);
               xb = (int)(xb + a[4] * x4 + a[5] * x5 + a[6] * x6);
               xb = (int)(xb + a[7] * x7 + a[8] * x8 + a[9] * x9);
               if (xb < 0)
               {
                  xb = 0;
               }
               if (xb > 255)
               {
                  xb = 255;
               }
               Color wb = Color.FromArgb(xb, xb, xb);
               objBitmap1.SetPixel(x, y, wb);
            }
         pictureBox2.Image = objBitmap1;
      }

      private void outlineToolStripMenuItem_Click(object sender, EventArgs e)
      {
         float[] a = new float[10];
         a[1] = (float)-1;
         a[2] = (float)-1;
         a[3] = (float)-1;
         a[4] = (float)-1;
         a[5] = (float)8;
         a[6] = (float)-1;
         a[7] = (float)-1;
         a[8] = (float)-1;
         a[9] = (float)-1;
         objBitmap1 = new Bitmap(objBitmap);
         for (int x = 1; x < objBitmap.Width - 1; x++)
            for (int y = 1; y < objBitmap.Height - 1; y++)
            {
               Color w1 = objBitmap.GetPixel(x - 1, y - 1);
               Color w2 = objBitmap.GetPixel(x - 1, y);
               Color w3 = objBitmap.GetPixel(x - 1, y + 1);
               Color w4 = objBitmap.GetPixel(x, y - 1);
               Color w5 = objBitmap.GetPixel(x, y);
               Color w6 = objBitmap.GetPixel(x, y + 1);
               Color w7 = objBitmap.GetPixel(x + 1, y - 1);
               Color w8 = objBitmap.GetPixel(x + 1, y);
               Color w9 = objBitmap.GetPixel(x + 1, y + 1);
               int x1 = w1.R;
               int x2 = w2.R;
               int x3 = w3.R;
               int x4 = w4.R;
               int x5 = w5.R;
               int x6 = w6.R;
               int x7 = w7.R;
               int x8 = w8.R;
               int x9 = w9.R;
               int xb = (int)(a[1] * x1 + a[2] * x2 + a[3] * x3);
               xb = (int)(xb + a[4] * x4 + a[5] * x5 + a[6] * x6);
               xb = (int)(xb + a[7] * x7 + a[8] * x8 + a[9] * x9);
               if (xb < 0)
               {
                  xb = 0;
               }
               if (xb > 255)
               {
                  xb = 255;
               }
               Color wb = Color.FromArgb(xb, xb, xb);
               objBitmap1.SetPixel(x, y, wb);
            }
         pictureBox2.Image = objBitmap1;
      }

      private void rightSobelToolStripMenuItem_Click(object sender, EventArgs e)
      {
         float[] a = new float[10];
         a[1] = (float)-1;
         a[2] = (float)0;
         a[3] = (float)1;
         a[4] = (float)-2;
         a[5] = (float)0;
         a[6] = (float)2;
         a[7] = (float)-1;
         a[8] = (float)0;
         a[9] = (float)1;
         objBitmap1 = new Bitmap(objBitmap);
         for (int x = 1; x < objBitmap.Width - 1; x++)
            for (int y = 1; y < objBitmap.Height - 1; y++)
            {
               Color w1 = objBitmap.GetPixel(x - 1, y - 1);
               Color w2 = objBitmap.GetPixel(x - 1, y);
               Color w3 = objBitmap.GetPixel(x - 1, y + 1);
               Color w4 = objBitmap.GetPixel(x, y - 1);
               Color w5 = objBitmap.GetPixel(x, y);
               Color w6 = objBitmap.GetPixel(x, y + 1);
               Color w7 = objBitmap.GetPixel(x + 1, y - 1);
               Color w8 = objBitmap.GetPixel(x + 1, y);
               Color w9 = objBitmap.GetPixel(x + 1, y + 1);
               int x1 = w1.R;
               int x2 = w2.R;
               int x3 = w3.R;
               int x4 = w4.R;
               int x5 = w5.R;
               int x6 = w6.R;
               int x7 = w7.R;
               int x8 = w8.R;
               int x9 = w9.R;
               int xb = (int)(a[1] * x1 + a[2] * x2 + a[3] * x3);
               xb = (int)(xb + a[4] * x4 + a[5] * x5 + a[6] * x6);
               xb = (int)(xb + a[7] * x7 + a[8] * x8 + a[9] * x9);
               if (xb < 0)
               {
                  xb = 0;
               }
               if (xb > 255)
               {
                  xb = 255;
               }
               Color wb = Color.FromArgb(xb, xb, xb);
               objBitmap1.SetPixel(x, y, wb);
            }
         pictureBox2.Image = objBitmap1;
      }

      private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
      {
         float[] a = new float[10];
         a[1] = (float)0;
         a[2] = (float)-1;
         a[3] = (float)0;
         a[4] = (float)-1;
         a[5] = (float)5;
         a[6] = (float)-1;
         a[7] = (float)0;
         a[8] = (float)-1;
         a[9] = (float)0;
         objBitmap1 = new Bitmap(objBitmap);
         for (int x = 1; x < objBitmap.Width - 1; x++)
            for (int y = 1; y < objBitmap.Height - 1; y++)
            {
               Color w1 = objBitmap.GetPixel(x - 1, y - 1);
               Color w2 = objBitmap.GetPixel(x - 1, y);
               Color w3 = objBitmap.GetPixel(x - 1, y + 1);
               Color w4 = objBitmap.GetPixel(x, y - 1);
               Color w5 = objBitmap.GetPixel(x, y);
               Color w6 = objBitmap.GetPixel(x, y + 1);
               Color w7 = objBitmap.GetPixel(x + 1, y - 1);
               Color w8 = objBitmap.GetPixel(x + 1, y);
               Color w9 = objBitmap.GetPixel(x + 1, y + 1);
               int x1 = w1.R;
               int x2 = w2.R;
               int x3 = w3.R;
               int x4 = w4.R;
               int x5 = w5.R;
               int x6 = w6.R;
               int x7 = w7.R;
               int x8 = w8.R;
               int x9 = w9.R;
               int xb = (int)(a[1] * x1 + a[2] * x2 + a[3] * x3);
               xb = (int)(xb + a[4] * x4 + a[5] * x5 + a[6] * x6);
               xb = (int)(xb + a[7] * x7 + a[8] * x8 + a[9] * x9);
               if (xb < 0)
               {
                  xb = 0;
               }
               if (xb > 255)
               {
                  xb = 255;
               }
               Color wb = Color.FromArgb(xb, xb, xb);
               objBitmap1.SetPixel(x, y, wb);
            }
         pictureBox2.Image = objBitmap1;
      }

      private void topSobelToolStripMenuItem_Click(object sender, EventArgs e)
      {
         float[] a = new float[10];
         a[1] = (float)1;
         a[2] = (float)2;
         a[3] = (float)1;
         a[4] = (float)0;
         a[5] = (float)0;
         a[6] = (float)0;
         a[7] = (float)-1;
         a[8] = (float)-2;
         a[9] = (float)-1;
         objBitmap1 = new Bitmap(objBitmap);
         for (int x = 1; x < objBitmap.Width - 1; x++)
            for (int y = 1; y < objBitmap.Height - 1; y++)
            {
               Color w1 = objBitmap.GetPixel(x - 1, y - 1);
               Color w2 = objBitmap.GetPixel(x - 1, y);
               Color w3 = objBitmap.GetPixel(x - 1, y + 1);
               Color w4 = objBitmap.GetPixel(x, y - 1);
               Color w5 = objBitmap.GetPixel(x, y);
               Color w6 = objBitmap.GetPixel(x, y + 1);
               Color w7 = objBitmap.GetPixel(x + 1, y - 1);
               Color w8 = objBitmap.GetPixel(x + 1, y);
               Color w9 = objBitmap.GetPixel(x + 1, y + 1);
               int x1 = w1.R;
               int x2 = w2.R;
               int x3 = w3.R;
               int x4 = w4.R;
               int x5 = w5.R;
               int x6 = w6.R;
               int x7 = w7.R;
               int x8 = w8.R;
               int x9 = w9.R;
               int xb = (int)(a[1] * x1 + a[2] * x2 + a[3] * x3);
               xb = (int)(xb + a[4] * x4 + a[5] * x5 + a[6] * x6);
               xb = (int)(xb + a[7] * x7 + a[8] * x8 + a[9] * x9);
               if (xb < 0)
               {
                  xb = 0;
               }
               if (xb > 255)
               {
                  xb = 255;
               }
               Color wb = Color.FromArgb(xb, xb, xb);
               objBitmap1.SetPixel(x, y, wb);
            }
         pictureBox2.Image = objBitmap1;
      }
   }
}
