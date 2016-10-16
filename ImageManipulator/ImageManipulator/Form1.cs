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

        private void imageLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap importedImage = new Bitmap(openFileDialog1.FileName);
                originalImage = importedImage;
                modifiableImage = importedImage;
                updatePicture(modifiableImage);
            }
        }

        private void imageReset_Click(object sender, EventArgs e)
        {
            modifiableImage = new Bitmap(openFileDialog1.FileName);
            updatePicture(modifiableImage);
        }

        private void imageSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salve como .png");
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                modifiableImage.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void imageRotate_Click(object sender, EventArgs e)
        {
            if (rotationTextBox.Text == "") { }
            else
            {
                double angle = Convert.ToDouble(rotationTextBox.Text);
                modifiableImage = RotateImage(modifiableImage, angle);
                updatePicture(modifiableImage);
            }
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
            updatePicture(modifiableImage);
        }

        private void imageThresholding_Click(object sender, EventArgs e)
        {
            int sx, sy;
            sx = modifiableImage.Width;
            sy = modifiableImage.Height;
            Color newColor;
            Color oldColor;
            for (int y = 0; y < sy; y++)
            {
                for (int x = 0; x < sx; x++)
                {
                    oldColor = modifiableImage.GetPixel(x, y);
                    if (Convert.ToInt32(oldColor.R * 0.299 + oldColor.G * 0.587 + oldColor.B * 0.114) > illuminanceTrackBar.Value)
                    {
                        newColor = Color.FromArgb(255, 255, 255);
                    }
                    else
                    {
                        newColor = Color.FromArgb(0, 0, 0);
                    }
                    modifiableImage.SetPixel(x, y, newColor);
                }
            }
            updatePicture(modifiableImage);
        }

        private void imageRGBUpdate_Click(object sender, EventArgs e)
        {
            int sx, sy, newR, newG, newB;
            sx = modifiableImage.Width;
            sy = modifiableImage.Height;
            double rr, rg, rb, gr, gg, gb, br, bg, bb;
            rr = Convert.ToDouble(matrixRr.Text.Replace('.',','));
            rg = Convert.ToDouble(matrixRg.Text.Replace('.', ','));
            rb = Convert.ToDouble(matrixRb.Text.Replace('.', ','));
            gr = Convert.ToDouble(matrixGr.Text.Replace('.', ','));
            gg = Convert.ToDouble(matrixGg.Text.Replace('.', ','));
            gb = Convert.ToDouble(matrixGb.Text.Replace('.', ','));
            br = Convert.ToDouble(matrixBr.Text.Replace('.', ','));
            bg = Convert.ToDouble(matrixBg.Text.Replace('.', ','));
            bb = Convert.ToDouble(matrixBb.Text.Replace('.', ','));
            for (int y = 0; y < sy; y++)
            {
                for (int x = 0; x < sx; x++)
                {
                    Color oldColor = modifiableImage.GetPixel(x, y);
                    newR = (int) Math.Min((oldColor.R * rr + oldColor.G * rg + oldColor.B * rb), 255);
                    newG = (int) Math.Min((oldColor.R * gr + oldColor.G * gg + oldColor.B * gb), 255);
                    newB = (int) Math.Min((oldColor.R * br + oldColor.G * bg + oldColor.B * bb), 255);
                    Color newColor = Color.FromArgb(newR, newG, newB);
                    modifiableImage.SetPixel(x, y, newColor);
                }
            }
            updatePicture(modifiableImage);
        }




        //Funções necessárias

        public static Bitmap RotateImage(Image image, double angle) // rever, quero fazer do meu jeito.
        {
            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            Graphics g = Graphics.FromImage(rotatedBmp);
            g.TranslateTransform((float)image.Width / 2, (float)image.Height / 2);
            g.RotateTransform((float)angle);
            g.TranslateTransform(-(float)image.Width / 2, -(float)image.Height / 2);
            g.DrawImage(image, new PointF(0, 0));

            return rotatedBmp;
        }
    }
}
