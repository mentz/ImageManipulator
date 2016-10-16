using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        public void updatePicture(Bitmap picture)
        {
            pictureBox1.Image = picture;
        }

        private void imageRotate_Click(object sender, EventArgs e)
        {
            double angle = Convert.ToDouble(rotationTextBox.Text);
            double h = Convert.ToDouble(modifiableImage.Height);
            double w = Convert.ToDouble(modifiableImage.Width);
            int newSize = Convert.ToInt32(Math.Sqrt(h * h + w * w));
            //for (int i = 0; i < h; i++)
            //{
            //    for (int j = 0; j < w; j++)
            //    {
            //        int newX = Convert.ToInt32((j - w / 2) * Math.Cos(angle) - (i - h / 2) * Math.Sin(angle));
            //        int newY = Convert.ToInt32((j - w / 2) * Math.Sin(angle) + (i - h / 2) * Math.Cos(angle));
            //        MessageBox.Show("newX = " + newX.ToString("D") + '\n' + "newY = " + newY.ToString("D"));
            //        rotatedImage.SetPixel(newX, newY, modifiableImage.GetPixel(j, i));
            //    }
            //}
            Bitmap rotatedImage = RotateImage(modifiableImage, angle);
            updatePicture(rotatedImage);
        }

        public static Bitmap RotateImage(Image image, double angle)
        {
            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            
            //make a graphics object from the empty bitmap
            Graphics g = Graphics.FromImage(rotatedBmp);

            //Put the rotation point in the center of the image
            g.TranslateTransform((float)image.Width / 2, (float)image.Height / 2);

            //rotate the image
            g.RotateTransform((float)angle);

            //move the image back
            g.TranslateTransform(-(float)image.Width / 2, -(float)image.Height / 2);

            //draw passed in image onto graphics object
            g.DrawImage(image, new PointF(0, 0));

            return rotatedBmp;
        }

        private void imageLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Bitmap importedImage = new Bitmap(openFileDialog1.FileName);
            originalImage = importedImage;
            modifiableImage = importedImage;
            updatePicture(modifiableImage);
        }

        private void imageReset_Click(object sender, EventArgs e)
        {
            modifiableImage = new Bitmap(openFileDialog1.FileName);
            updatePicture(modifiableImage);
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
