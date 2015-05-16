using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Resizer
{
    class Img2Sephia
    {
        int r;
        int g;
        int b;
        internal Image ConvertImage(System.Drawing.Image img)
        {
            Bitmap bmp = new Bitmap(img);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color clr = bmp.GetPixel(i, j);
                    clr = ConvertPixel(clr);
                    bmp.SetPixel(i, j, clr);
                }
            }
            return bmp;
        }

        private Color ConvertPixel(Color clr)
        {
            r=Convert.ToInt32(clr.R * .393 + clr.G * .769 + clr.B * .189);
            g=Convert.ToInt32(clr.R * .349 + clr.G * .686 + clr.B * 0.186);
            b=Convert.ToInt32(clr.R * 0.272 + clr.G * 0.534 + clr.B * 0.131);
            if(r>255){
                r=255;
            }
            if (g > 255)
            {
                g = 255;
            }
            if (b > 255)
            {
                b = 255;
            }
            Color newClr = Color.FromArgb(r, g , b);
            return newClr;

        }
    }
}
