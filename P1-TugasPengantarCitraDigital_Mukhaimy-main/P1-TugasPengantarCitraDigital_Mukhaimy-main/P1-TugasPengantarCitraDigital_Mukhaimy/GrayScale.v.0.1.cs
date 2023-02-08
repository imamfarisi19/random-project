using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_TugasPengantarCitraDigital_Mukhaimy
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

        private void button1_Click(object sender, EventArgs e)
        {

        }

      private void panel2_Paint(object sender, PaintEventArgs e)
      {

      }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      private void Form1_Load(object sender, EventArgs e)
      {
         //read image
         Bitmap bmp = new Bitmap("C:\\Users\\USER\\Downloads\\Tokyo University.jpg");

         //load original image in picturebox1
         pictureBox1.Image = Image.FromFile("C:\\Users\\USER\\Downloads\\Tokyo University.jpg");

         //get image dimension
         int width = bmp.Width;
         int height = bmp.Height;

         // color of pixel
         Color p;

         //grayscale
         for (int y = 0; y < height; y++)
         {
            for(int x = 0; x < width; x++)
            {
               //get pixel value
               p = bmp.GetPixel(x, y);

               //extract pixel component ARGB
               int a = p.A;
               int r = p.R;
               int g = p.G;
               int b = p.B;

               //find average
               int avg = (r + g + b) / 3;

               //set new pixel value
               bmp.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
            }
         }

         //load grayscale image in picturebox2
         pictureBox2.Image = bmp;

         //write the grayscale image
         bmp.Save("C:\\Users\\USER\\Downloads\\Tokyo University Grayscale.png");
      }
   }
}
