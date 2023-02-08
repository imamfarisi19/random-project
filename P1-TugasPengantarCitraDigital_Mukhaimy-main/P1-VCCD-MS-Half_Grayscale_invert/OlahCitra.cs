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
   public class OlahCitra
   {
      HalfGrayscaleInvert HGI = new HalfGrayscaleInvert();
      Bitmap newBitmap;
      Boolean opened = false;
      public void olahgambar ()
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
      }
   }
}