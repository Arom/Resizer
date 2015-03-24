using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resizer
{
    public partial class MainForm : Form
    {
        string[] files;
        Resize resize;
        string savePath;
        public MainForm()
        {
            InitializeComponent();
            fileBrowser.Multiselect = true;
            fileBrowser.Filter = "JPG|*.jpg;*.jpeg|BMP|*.bmp|GIF|*.gif|PNG|*.png|TIFF|*.tif;*.tiff|"
       + "All Image Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resize = new Resize();
        }

        private bool isNumber(string text)
        {
            double n;
            bool isNumeric = double.TryParse(text, out n);
            return isNumeric;

        }
        private bool isInputCorrect()
        {
            bool errors = true;
            if (radioPercent.Checked)
            {
                if (!isNumber(txtPercent.Text))
                {
                    errors = false;
                }
            }
            else if (radioPixels.Checked)
            {
                if (!isNumber(txtHeight.Text) || !isNumber(txtWidth.Text))
                {
                    errors = false;
                }
            }
            return errors;

        }
        private void btnSelectImages_Click(object sender, EventArgs e)
        {
            if (isInputCorrect())
            {
                DialogResult result = fileBrowser.ShowDialog();
                if (result.Equals(DialogResult.OK))
                {
                    files = fileBrowser.FileNames;

                    if (radioPercent.Checked)
                    {
                        
                        Array.ForEach(files, f => resize.ResizeImagePercent(f, 
                            Convert.ToInt32(txtPercent.Text),
                            savePath));
                    }
                    else if (radioPixels.Checked)
                    {
                        Array.ForEach(files, f => resize.ResizeImage(f,
                            Convert.ToInt32(txtWidth.Text),
                            Convert.ToInt32(txtHeight.Text),
                            savePath));
                    }
                }
            }
            else
            {
                MessageBox.Show("Check inputs");
            }
         
        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {
            DialogResult result = savePathBrowser.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                txtSavePath.Text = savePath = savePathBrowser.SelectedPath;
            }
        }
    }
}
