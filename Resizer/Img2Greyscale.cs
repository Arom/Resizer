using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resizer
{
    class Img2Greyscale
    {

        internal Image Convert(Image img)
        {
            Bitmap bmp = new Bitmap(img);
            
                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        Color clr = bmp.GetPixel(i, j);
                        clr = ConvertPixel(clr, 1);
                        bmp.SetPixel( i, j, clr);
                    }
                }
            return bmp;
        }

        private Color ConvertPixel(Color clr, int mode)
        {
           return Color.FromArgb((clr.R + clr.G + clr.B) / 3, (clr.R + clr.G + clr.B) / 3, (clr.R + clr.G + clr.B) / 3);
        }
    }
}
