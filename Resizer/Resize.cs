using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resizer
{
    class Resize
    {
        public Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var resizedImage = new Bitmap(width, height);
            return ProcessImage(resizedImage, image, destRect);
        }
        public Bitmap ResizeImagePercent(Image image, int percent)
        {
            double resizePercent = (double)percent / 100.00;
            int width = (int)Math.Round((double)image.Width * resizePercent);

            int height = (int)Math.Round((double)image.Height * resizePercent);
            var destRect = new Rectangle(0, 0, width, height);
            var resizedImage = new Bitmap(width, height);

            return ProcessImage(resizedImage, image, destRect);
        }
        public Bitmap ProcessImage(Bitmap resizedImage, Image image, Rectangle destRect)
        {
            //Maintains the DPI of the image

            resizedImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(resizedImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                //Anti-Aliasing
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                //Improve rendering quality
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                using (var wrapMode = new ImageAttributes())
                {
                    //No ghosting around borders
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
                return resizedImage;
            }
        }
    }
}
