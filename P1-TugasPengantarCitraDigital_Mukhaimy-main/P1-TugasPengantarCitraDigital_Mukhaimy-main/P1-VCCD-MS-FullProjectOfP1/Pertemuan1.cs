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

namespace P1_VCCD_MS_FullProjectOfP1
{
   public partial class Pertemuan1 : Form
   {
      public Pertemuan1()
      {
         InitializeComponent();
      }

      Bitmap newBitmap;
      Image file;
      Boolean opened = false;
      private void button1_Click(object sender, EventArgs e)
      {
         DialogResult dr = openFileDialog1.ShowDialog();

         if(dr == DialogResult.OK)
         {
            file = Image.FromFile(openFileDialog1.FileName);
            newBitmap = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = file;
            opened = true;
         }
      }

      private void button2_Click(object sender, EventArgs e)
      {
         if (opened == true)
         {
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
               if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "bmp")
               {
                  newBitmap.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
               }
               if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "jpg")
               {
                  newBitmap.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
               }
               if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "png")
               {
                  newBitmap.Save(saveFileDialog1.FileName, ImageFormat.Png);
               }
               if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "gif")
               {
                  newBitmap.Save(saveFileDialog1.FileName, ImageFormat.Gif);
               }
            }
         }
         else
         {
            MessageBox.Show("Please! upload an image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }

      private void button3_Click(object sender, EventArgs e)
      {
         Color p;

         if (opened == true)
         {
            for (int x = 0; x < newBitmap.Width; x++)
            {
               for (int y = 0; y < newBitmap.Height; y++)
               {

                  p = newBitmap.GetPixel(x, y);

                  //extract pixel component ARGB
                  int a = p.A;
                  int r = p.R;
                  int g = p.G;
                  int b = p.B;

                  //find average
                  int avg = (r + g + b) / 3;

                  //set new pixel value
                  newBitmap.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                  /*
                  Color originalColor = newBitmap.GetPixel(x, y);
                  int grayScale = (int)((originalColor.R * .3) + (originalColor.G * .59) + (originalColor.B * .11));
                  Color newColor = Color.FromArgb(grayScale, grayScale, grayScale);
                  newBitmap.SetPixel(x, y, newColor);
                  */
               }
            }
            pictureBox2.Image = newBitmap;
         }
         else
         {
            MessageBox.Show("Please! upload an image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }

      private void button4_Click(object sender, EventArgs e)
      {
         if (opened == true)
         {
            for (int x = 0; x < newBitmap.Width; x++)
            {
               for (int y = 0; y < newBitmap.Height; y++)
               {
                  Color pixel = newBitmap.GetPixel(x, y);

                  int red = pixel.R;
                  int green = pixel.G;
                  int blue = pixel.B;

                  newBitmap.SetPixel(x, y, Color.FromArgb(255 - red, 255 - green, 255 - blue));
               }
            }
            pictureBox2.Image = newBitmap;
         }
         else
         {
            MessageBox.Show("Please! upload an image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }

      private void button5_Click(object sender, EventArgs e)
      {
         if (opened == true)
         {
            for (int x = 0; x < newBitmap.Width; x++)
            {
               for (int y = 0; y < newBitmap.Height; y++)
               {
                  if (x <= (newBitmap.Width / 2))
                  {
                     //change to Grayscale color
                     Color originalColor = newBitmap.GetPixel(x, y);
                     int grayScale = (int)((originalColor.R * .3) + (originalColor.G * .59) + (originalColor.B * .11));
                     Color newColor = Color.FromArgb(grayScale, grayScale, grayScale);
                     newBitmap.SetPixel(x, y, newColor);
                  }
                  else if (x >= (newBitmap.Width / 2))
                  {
                     //change to invert color
                     Color pixel = newBitmap.GetPixel(x, y);
                     int red = pixel.R;
                     int green = pixel.G;
                     int blue = pixel.B;
                     newBitmap.SetPixel(x, y, Color.FromArgb(255 - red, 255 - green, 255 - blue));
                  }
               }
            }
            pictureBox2.Image = newBitmap;
         }
         else
         {
            MessageBox.Show("Please! upload an image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
      private void Form1_Load(object sender, EventArgs e)
      {

      }
   }
}
