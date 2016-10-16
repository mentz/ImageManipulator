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
    
    public partial class Form1 : Form
    {
        public Bitmap originalImage;
        public Bitmap modifiableImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void imageRotate_Click(object sender, EventArgs e)
        {
            RotationForm rotateform = new RotationForm();
            rotateform.ShowDialog();
        }

        private void imageLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Bitmap importedImage = new Bitmap(openFileDialog1.FileName);
            originalImage = importedImage;
            modifiableImage = importedImage;
            pictureBox1.Image = modifiableImage;
        }

        private void imageReset_Click(object sender, EventArgs e)
        {
            modifiableImage = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = modifiableImage;
        }

        private void imageInvertColors_Click(object sender, EventArgs e)
        {
            int sx, sy;
            sx = modifiableImage.Width;
            sy = modifiableImage.Height;
            for (int y = 0; y < sy; y++)
            {
                for (int x = 0; x < sx; x++)
                {
                    Color oldColor = modifiableImage.GetPixel(x, y);
                    Color newColor = Color.FromArgb(255-oldColor.R, 255-oldColor.G, 255-oldColor.B);
                    modifiableImage.SetPixel(x, y, newColor);
                }
            }
            pictureBox1.Image = modifiableImage;
        }

        private void imageGrayscale_Click(object sender, EventArgs e)
        {
            int sx, sy;
            sx = modifiableImage.Width;
            sy = modifiableImage.Height;
            for (int y = 0; y < sy; y++)
            {
                for (int x = 0; x < sx; x++)
                {
                    Color oldColor = modifiableImage.GetPixel(x, y);
                    int grayValue = Convert.ToInt32(oldColor.R * 0.299 + oldColor.G * 0.587 + oldColor.B * 0.114);
                    Color newColor = Color.FromArgb(grayValue, grayValue, grayValue);
                    modifiableImage.SetPixel(x, y, newColor);
                }
            }
            pictureBox1.Image = modifiableImage;
        }
    }
}
