using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bab3_manipulasiRGB_image3
{
   public partial class Form1 : Form
   {
      Bitmap objBitmap;
      Bitmap objBitmap1;
      public Form1()
      {
         InitializeComponent();
      }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      private void button1_Click(object sender, EventArgs e)
      {
         DialogResult d = openFileDialog1.ShowDialog();
         if(d == DialogResult.OK)
         {
            objBitmap = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = objBitmap;
         }

      }

      private void button2_Click(object sender, EventArgs e)
      {
         objBitmap1 = new Bitmap(objBitmap);
         for(int x = 0; x < objBitmap.Width; x++)
            for(int y = 0; y < objBitmap.Height; y++)
            {
               Color W = objBitmap.GetPixel(x,y);
               int r = W.R;
               int g = W.G;
               int b = W.B;
               Color wb = Color.FromArgb(r,g,b);
               objBitmap1.SetPixel(x, y, wb);
            }
         pictureBox2.Image = objBitmap1;
      }

      private void button3_Click(object sender, EventArgs e)
      {
         objBitmap1 = new Bitmap(objBitmap);
         for(int x = 0; x < objBitmap.Width; x++)
            for(int y = 0; y < objBitmap1.Height; y++)
            {
               Color W = objBitmap.GetPixel(x, y);
               int r = W.R;
               Color wb = Color.FromArgb(r, 0, 0);
               objBitmap1.SetPixel(x, y, wb);
            }
         pictureBox2.Image = objBitmap1;
      }

      private void pictureBox2_Click(object sender, EventArgs e)
      {

      }
   }
}
