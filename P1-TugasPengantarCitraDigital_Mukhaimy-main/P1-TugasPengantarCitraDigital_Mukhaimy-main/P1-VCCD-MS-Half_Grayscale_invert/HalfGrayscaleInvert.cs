using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_VCCD_MS_Half_Grayscale_invert
{
   public partial class HalfGrayscaleInvert : Form
   {
      public HalfGrayscaleInvert()
      {
         InitializeComponent();
      }

      Bitmap newBitmap;
      Image file;
      Boolean opened = false;

      private void button1_Click(object sender, EventArgs e)
      {
         DialogResult dr = openFileDialog1.ShowDialog();

         if (dr == DialogResult.OK)
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
            OlahCitra oc = new OlahCitra();
            oc.olahgambar();
            pictureBox2.Image = newBitmap;
            newBitmap.Save("C:\\Users\\USER\\Downloads\\Hasil\\Hasil Half Grayscale and Invert.png");
         }
         else
         {
            MessageBox.Show("Please! upload an image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }

      private void label2_Click(object sender, EventArgs e)
      {

      }

      private void label1_Click(object sender, EventArgs e)
      {

      }

        private void HalfGrayscaleInvert_Load(object sender, EventArgs e)
        {

        }
    }
}
