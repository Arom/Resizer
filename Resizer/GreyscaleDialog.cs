using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resizer
{
    public partial class GreyscaleDialog : Form
    {
        public int greyscaleMode;


        public GreyscaleDialog()
        {
            InitializeComponent();

        }

        public GreyscaleDialog(int greyscaleMode)
        {
            // TODO: Complete member initialization
            this.greyscaleMode = greyscaleMode;
            InitializeComponent();
            switch (greyscaleMode)
            {
                case 1:
                    radioButton1.Checked = true;
                    break;
                case 2:
                    radioButton2.Checked = true;
                    break;
                case 3:
                    radioButton3.Checked = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            greyscaleMode = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            greyscaleMode = 3;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            greyscaleMode = 1;
        }
    }
}
