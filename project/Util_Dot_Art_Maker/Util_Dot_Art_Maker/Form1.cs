using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Util_Dot_Art_Maker
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string[] pictureImgTypes = new string[] { ".jpg", ".png", ".gif" };
        double threshold = 0.5;

        private void pictureAddBtn_Click(object sender, EventArgs e)
        {
            int imgType = 0;
            OpenFileDialog pictureLoadDialog = new OpenFileDialog();
            string imgFilterText = "any of pictures|*.*";
            for (int i = 0; i < pictureImgTypes.Length; i++)
            {
                imgFilterText += "|" + pictureImgTypes[i] + " files(*" + pictureImgTypes[i] + ")|*" + pictureImgTypes[i];
            }
            pictureLoadDialog.Filter = imgFilterText;
            if (pictureLoadDialog.ShowDialog() == DialogResult.OK)
            {
                bool isPicture = false;
                for (int i = 0; i < pictureImgTypes.Length; i++)
                {
                    if (pictureLoadDialog.SafeFileName.ToLower().EndsWith(pictureImgTypes[i]))
                    {
                        isPicture = true;
                        imgType = i;
                    }
                }
                if (isPicture)
                {
                    pictureLoaded.Load(pictureLoadDialog.FileName);
                    imgProcessToDot(imgType);
                }
                else
                {
                    MessageBox.Show("需要圖片文件!");
                    return;
                }
            }
        }

        private void MainWindow_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void MainWindow_DragEnter(object sender, DragEventArgs e)
        {
            int imgType = 0;
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            string file = files[0];
            bool isPicture = false;
            for (int i = 0; i < pictureImgTypes.Length; i++)
            {
                if (file.ToLower().EndsWith(pictureImgTypes[i]))
                {
                    isPicture = true;
                    imgType = i;
                }
            }
            if (isPicture)
            {
                pictureLoaded.Load(file);
                imgProcessToDot(imgType);
            }
            else
            {
                MessageBox.Show("需要圖片文件!");
                return;
            }
        }

        private void imgProcessToDot(int imgType)
        {
            int pictureWidth = pictureLoaded.Image.Width;
            int pictureHeight = pictureLoaded.Image.Height;
            Bitmap pictureChange = (Bitmap)pictureLoaded.Image;
            double[,] processData = new double[pictureWidth, pictureHeight];

            // turn picture into gray
            for (int i = 0; i < pictureWidth; i++)
            {
                for (int j = 0; j < pictureHeight; j++)
                {
                    Color pixelColor = pictureChange.GetPixel(i, j);
                    int gray = (int)(0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B);
                    processData[i, j] = (double)gray / 255;
                    pixelColor = Color.FromArgb(gray, gray, gray);
                    pictureChange.SetPixel(i, j, pixelColor);
                }
            }

            // process Floyd-Steinberg dithering
            for (int i = 0; i < pictureHeight; i++)
            {
                for (int j = 0; j < pictureWidth; j++)
                {
                    int widthIndex = j;
                    int directionOffset = 1;
                    if (i % 2 != 0)
                    {
                        widthIndex = pictureWidth - j - 1;
                        directionOffset = -1;
                    }
                    double oldGray = processData[widthIndex, i];
                    double newGray;
                    if (oldGray >= threshold)
                    {
                        processData[widthIndex, i] = 1;
                        newGray = 1;
                    }
                    else
                    {
                        processData[widthIndex, i] = 0;
                        newGray = 0;
                    }
                    double quantErr = oldGray - newGray;
                    if (i + 1 < pictureHeight)
                    {
                        processData[widthIndex, i + 1] += quantErr * 5 / 16;
                        if (j + 1 < pictureWidth)
                        {
                            processData[widthIndex + directionOffset, i + 1] += quantErr * 1 / 16;
                        }
                        if (j - 1 >= 0)
                        {
                            processData[widthIndex - directionOffset, i + 1] += quantErr * 3 / 16;
                        }
                    }
                    if (j + 1 < pictureWidth)
                    {
                        processData[widthIndex + directionOffset, i] += quantErr * 7 / 16;
                    }
                }
            }

            setPictureLoaded(processData);
            setDotArt(processData);
        }

        private void setPictureLoaded(double[,] pixelData)
        {
            Bitmap pictureChange = (Bitmap)pictureLoaded.Image;

            for (int i = 0; i < pixelData.GetLength(0); i++)
            {
                for (int j = 0; j < pixelData.GetLength(1); j++)
                {
                    int newGray = (int)(pixelData[i, j] * 255);
                    Color pixelColor = Color.FromArgb(newGray, newGray, newGray);
                    pictureChange.SetPixel(i, j, pixelColor);
                }
            }

            pictureLoaded.Image = pictureChange;
        }

        private void setDotArt(double[,] pixelData) // first Rk: width, second Rk: height
        {
            transformedTextBox.Text = "";
            for (int i = 0; i < pixelData.GetLength(1); i += 4)
            {
                int blankCount = 0;
                for (int j = 0; j < pixelData.GetLength(0); j += 2)
                {
                    int pixelUnicode = 10240;
                    for (int k = 0; k < 8; k++)
                    {
                        if (i + k / 2 < pixelData.GetLength(1) && j + k % 2 < pixelData.GetLength(0) && pixelData[j + k % 2, i + k / 2] == 0)
                        {
                            pixelUnicode += Convert.ToInt32(Math.Pow(2, k));
                        }
                    }
                    if (pixelUnicode == 10240)
                    {
                        blankCount++;
                    }
                    else
                    {
                        for (int k = 0; k < blankCount; k++)
                        {
                            transformedTextBox.Text += "⠀";
                        }
                        blankCount = 0;
                        /*byte[] uniBytes = new byte[2];
                        string convertStr = Convert.ToString(pixelUnicode, 16);
                        uniBytes[1] = Convert.ToByte(convertStr.Substring(0, 2), 16);
                        uniBytes[0] = Convert.ToByte(convertStr.Substring(2, 2), 16);
                        transformedTextBox.Text += Encoding.Unicode.GetString(uniBytes);*/
                    }
                }
                transformedTextBox.Text += "\n";
            }
        }
    }
}
