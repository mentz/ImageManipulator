using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageManipulator
{
    public partial class RotationForm : Form
    {
        private Form1 otherForm;
        public RotationForm()
        {
            InitializeComponent();
        }

        private void rotationApplyButton_Click(object sender, EventArgs e)
        {
            double h, w;
            h = otherForm.modifiableImage.Height;
            w = otherForm.modifiableImage.Width;
            int newSize = Convert.ToInt32(Math.Sqrt(h*h + w*w));
            Bitmap rotatedImage = new Bitmap(newSize, newSize);
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {

                }
            }
        }
    }
}
