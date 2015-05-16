using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resizer
{
    class Img2Greyscale
    {


       
        int max;
        int min;
        internal Image ConvertImage(System.Drawing.Image img, int mode)

        {
            Bitmap bmp = new Bitmap(img);
            
                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        Color clr = bmp.GetPixel(i, j);
                        clr = ConvertPixel(clr, mode);
                        bmp.SetPixel( i, j, clr);
                    }
                }
                return bmp;
        }

        private Color ConvertPixel(Color clr, int mode)
        {

           

            if (mode == 1)
            {
                Color newClr = Color.FromArgb((clr.R + clr.G + clr.B) / 3, (clr.R + clr.G + clr.B) / 3, (clr.R + clr.G + clr.B) / 3);
                return newClr;
            }
            if (mode == 2)
            {
                max = Math.Max(clr.R,clr.G );
                max = Math.Max(max, clr.B);
                min = Math.Min(clr.R ,clr.G);
                min = Math.Min(min, clr.G);
                Color newClr = Color.FromArgb((max + min) / 2, (max + min) / 2, (max + min) / 2);
                return newClr;

            }
            else
            {
                Color newClr = Color.FromArgb(Convert.ToInt32(clr.R * 0.21 + clr.G * 0.72 + clr.B * 0.07), Convert.ToInt32(clr.R * 0.21 + clr.G * 0.72 + clr.B * 0.07), Convert.ToInt32(clr.R * 0.21 + clr.G * 0.72 + clr.B * 0.07));
                return newClr;
            }

        }
    }
}
