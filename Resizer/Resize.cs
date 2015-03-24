using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resizer
{
    class Resize
    {
        string DEFAULT_SAVE_PATH = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        private string getFileName(string path)
        {
            return path.Substring(path.LastIndexOf("\\")).Insert(1, "Resized");
        }

        private ImageFormat getFileExtension(string path)
        {
            string ext = Path.GetExtension(path);
            if (String.IsNullOrEmpty(ext))
            {
                throw new ArgumentException(
                    String.Format("Cannot find extension for file {0}", path));
            }
            switch (ext.ToLower())
            {
                case @".bmp":
                    return ImageFormat.Bmp;

                case @".gif":
                    return ImageFormat.Gif;

                case @".ico":
                    return ImageFormat.Icon;

                case @".jpg":
                case @".jpeg":
                    return ImageFormat.Jpeg;

                case @".png":
                    return ImageFormat.Png;

                case @".tif":
                case @".tiff":
                    return ImageFormat.Tiff;

                case @".wmf":
                    return ImageFormat.Wmf;

                default:
                    throw new NotImplementedException();
            }
        }
        public void saveImage(Bitmap img, string destPath, ImageFormat ext)
        {
            try
            {
                img.Save(destPath, ext);
            }
            catch (Exception ex)
            {
                Console.WriteLine(String.Format("Save error : {0}", ex.ToString()));
            }
        }
        public void ResizeImage(string imgPath, int width, int height, string destPath = null)
        {
            if (String.IsNullOrEmpty(destPath))
            {
                destPath = DEFAULT_SAVE_PATH;
            }
            try
            {
                Image img = Image.FromFile(imgPath);

                var destRect = new Rectangle(0, 0, width, height);
                var toResize = new Bitmap(width, height);

                var resizedImg = ProcessImage(toResize, img, destRect); ;


                string destination = String.Format("{0}{1}", destPath, getFileName(imgPath));
                saveImage(resizedImg, destination, getFileExtension(imgPath));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(String.Format("{0} is not an image.", imgPath));
            }

        }
        public void ResizeImagePercent(string imgPath, int percent, string destPath = null)
        {
            if (String.IsNullOrEmpty(destPath))
            {
                destPath = DEFAULT_SAVE_PATH;
            }
            try
            {
                var img = Image.FromFile(imgPath);

                double resizePercent = (double)percent / 100.00;
                int width = (int)Math.Round((double)img.Width * resizePercent);
                int height = (int)Math.Round((double)img.Height * resizePercent);
                var destRect = new Rectangle(0, 0, width, height);
                var toResize = new Bitmap(width, height);

                var resizedImg = ProcessImage(toResize, img, destRect);

                string destination = String.Format("{0}{1}", destPath, getFileName(imgPath));
                saveImage(resizedImg, destination, getFileExtension(imgPath));


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(String.Format("{0} is not an image.", imgPath));
            }

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
