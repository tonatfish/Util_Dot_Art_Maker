using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gif.Components;


// for someone refact the project: if possible, we can simply classify logic part to another cs
// I'm no going to do so to improve the code at thist time. _2021/07/24
// First Made By: David Shih (Tuna)
namespace Util_Dot_Art_Maker
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        // Variable

        string[] pictureImgTypes = new string[] { ".jpg", ".png", ".gif" };
        int imgType = 0;
        double threshold = 0.5;

        List<Image> performedImgs = new List<Image>();
        List<string> performedTexts = new List<String>();
        int performedCount = 0;
        int performedId = 0;



        // Form

        private void pictureAddBtn_Click(object sender, EventArgs e)
        {
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
                    gifTimer.Stop();
                    performedTexts.Clear();
                    performedImgs.Clear();
                    pictureLoaded.Load(pictureLoadDialog.FileName);
                    if (imgType == 2)
                    {
                        setGifOnScreen(pictureLoadDialog.FileName);
                    }
                    else
                    {
                        setImgOnScreen();
                    }
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
                gifTimer.Stop();
                performedTexts.Clear();
                performedImgs.Clear();
                pictureLoaded.Load(file);
                if (imgType == 2)
                {
                    setGifOnScreen(file);
                }
                else
                {
                    setImgOnScreen();
                }
            }
            else
            {
                MessageBox.Show("需要圖片文件!");
                return;
            }
        }

        private void thresholdBar_Scroll(object sender, EventArgs e)
        {
            ThresholdLabel.Text = "Threshold: " + ((int)((double)thresholdBar.Value / 255 * 100)).ToString() + "%";
        }

        private void thresholdBar_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void resizeWidthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void resizeHeightInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void imageSaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog pictureSaveDialog = new SaveFileDialog();
            string imgFilterText = "any of pictures|*.*";
            for (int i = 0; i < pictureImgTypes.Length; i++)
            {
                imgFilterText += "|" + pictureImgTypes[i] + " files(*" + pictureImgTypes[i] + ")|*" + pictureImgTypes[i];
            }
            pictureSaveDialog.Filter = imgFilterText;
            pictureSaveDialog.FileName = "art_image";
            pictureSaveDialog.DefaultExt = pictureImgTypes[imgType];
            pictureSaveDialog.AddExtension = true;
            if (pictureSaveDialog.ShowDialog() == DialogResult.OK)
            {
                if (performedCount == 0)
                {
                    MessageBox.Show("還沒載入圖片!");
                    return;
                }
                if (imgType == 2)
                {
                    AnimatedGifEncoder animate = new AnimatedGifEncoder();
                    animate.Start(pictureSaveDialog.FileName);
                    animate.SetDelay(gifTimer.Interval);
                    animate.SetRepeat(0);
                    foreach (Image item in performedImgs)
                    {
                        animate.AddFrame(item);
                    }
                    animate.Finish();
                }
                else
                {
                    pictureLoaded.Image.Save(pictureSaveDialog.FileName);
                }
            }
        }

        private void txtSaveBtn_Click(object sender, EventArgs e)
        {
            if (imgType == 2)
            {
                SaveFileDialog dotGifSaveDialog = new SaveFileDialog();
                dotGifSaveDialog.Filter = "gif|*.gif";
                dotGifSaveDialog.FileName = "dot_art";
                dotGifSaveDialog.DefaultExt = pictureImgTypes[imgType];
                dotGifSaveDialog.AddExtension = true;
                if (dotGifSaveDialog.ShowDialog() == DialogResult.OK)
                {
                    if (performedCount == 0)
                    {
                        MessageBox.Show("還沒載入圖片!");
                        return;
                    }
                    List<Image> tempImgs = new List<Image>();
                    for (int i = 0; i < performedCount; i++)
                    {
                        Bitmap bitmap = new Bitmap(pictureLoaded.Width, pictureLoaded.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
                        Graphics graphics = Graphics.FromImage(bitmap);
                        graphics.Clear(Color.White);
                        graphics.DrawString(performedTexts[i], new Font("新細明體", 6, FontStyle.Regular), new SolidBrush(Color.FromArgb(0, 0, 0)), new PointF(0F, 0F));
                        tempImgs.Add(bitmap);
                    }

                    AnimatedGifEncoder animate = new AnimatedGifEncoder();
                    animate.Start(dotGifSaveDialog.FileName);
                    animate.SetDelay(gifTimer.Interval);
                    animate.SetRepeat(0);
                    foreach (Image item in tempImgs)
                    {
                        animate.AddFrame(item);
                    }
                    animate.Finish();
                }
            }
            else
            {
                SaveFileDialog dotTxtSaveDialog = new SaveFileDialog();
                dotTxtSaveDialog.Filter = "txt files|*.txt|all kinds of file|*.*";
                dotTxtSaveDialog.FileName = "dot_art";
                dotTxtSaveDialog.DefaultExt = "txt";
                dotTxtSaveDialog.AddExtension = true;
                if (dotTxtSaveDialog.ShowDialog() == DialogResult.OK)
                {
                    if (performedCount == 0)
                    {
                        MessageBox.Show("還沒載入圖片!");
                        return;
                    }
                    using (StreamWriter sw = new StreamWriter(dotTxtSaveDialog.FileName))
                    {
                        sw.WriteLine(performedTexts[0]);
                    }
                }
            }
        }

        private void gifTimer_Tick(object sender, EventArgs e)
        {
            if (++performedId >= performedCount)
            {
                performedId = 0;
            }
            pictureLoaded.Image = performedImgs[performedId];
            transformedTextBox.Text = performedTexts[performedId];
        }



        // Logic

        private void setImgOnScreen()
        {
            performedCount = 1;
            imgProcessToDot(pictureLoaded.Image);
            pictureLoaded.Image = performedImgs[0];
            transformedTextBox.Text = performedTexts[0];
        }

        private void setGifOnScreen(string imgPath)
        {
            performedId = 0;

            GifDecoder decoder = new GifDecoder();
            decoder.Read(imgPath);
            performedCount = decoder.GetFrameCount();
            gifTimer.Interval = decoder.GetDelay(0);
            for (int i = 0; i < performedCount; i++)
            {
                imgProcessToDot(decoder.GetFrame(i));
            }
            gifTimer.Start();
        }

        private void imgProcessToDot(Image pictureToProcess)
        {
            int pictureWidth = pictureToProcess.Width;
            int pictureHeight = pictureToProcess.Height;
            if (resizeHeightInput.Text != "")
            {
                int resizeHeight = Convert.ToInt32(resizeHeightInput.Text);
                if (resizeHeight < pictureHeight)
                {
                    pictureWidth = (int)((double)pictureWidth / pictureHeight * resizeHeight);
                    pictureHeight = resizeHeight;
                }
            }
            if (resizeWidthInput.Text != "")
            {
                int resizeWidth = Convert.ToInt32(resizeWidthInput.Text);
                if (resizeWidth < pictureWidth)
                {
                    pictureHeight = (int)((double)pictureHeight / pictureWidth * resizeWidth);
                    pictureWidth = resizeWidth;
                }
            }

            Bitmap pictureChange = new Bitmap(pictureToProcess, new Size(pictureWidth, pictureHeight));
            double[,] processData = new double[pictureWidth, pictureHeight];

            threshold = thresholdBar.Value / 255.0;

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

            if (processMethodRadio_thresh.Checked)
            {
                processData = ditherThresh(processData);
            }
            else if (processMethodRadio_fs.Checked)
            {
                processData = ditherFS(processData);
            }

            setPictureLoaded(processData);
            setDotArt(processData);
        }

        private void setPictureLoaded(double[,] pixelData)
        {
            Bitmap resizedPicture = new Bitmap(pixelData.GetLength(0), pixelData.GetLength(1));
            for (int i = 0; i < pixelData.GetLength(0); i++)
            {
                for (int j = 0; j < pixelData.GetLength(1); j++)
                {
                    int newGray = (int)(pixelData[i, j] * 255);
                    Color pixelColor = Color.FromArgb(newGray, newGray, newGray);
                    resizedPicture.SetPixel(i, j, pixelColor);
                }
            }
            performedImgs.Add(resizedPicture);
        }

        private void setDotArt(double[,] pixelData) // in pixelDate, first Rk: width & second Rk: height
        {
            int pictureWidth = pixelData.GetLength(0);
            int pictureHeight = pixelData.GetLength(1);
            int[,] pictureUnicode = new int[(int)Math.Ceiling((double)pictureHeight / 4), (int)Math.Ceiling((double)pictureWidth / 2)];
            int uniStarter = 10240;
            
            for (int i = 0; i < pictureHeight; i++)
            {
                for (int j = 0; j < pictureWidth; j ++)
                {
                    if (i % 4 == 0 && j % 2 == 0)
                    {
                        pictureUnicode[i / 4, j / 2] = 1 - (int)pixelData[j, i];
                    }
                    else if (pixelData[j, i] == 0)
                    {
                        pictureUnicode[i / 4, j / 2] += Convert.ToInt32(Math.Pow(2, i % 4 * 2 + j % 2));
                    }
                }
            }

            int uniHeight = pictureUnicode.GetLength(0);
            int uniWidth = pictureUnicode.GetLength(1);
            string transformedText = "";

            byte[] BlankBytes = new byte[2];
            string BlankStr = Convert.ToString(uniStarter, 16);
            BlankBytes[1] = Convert.ToByte(BlankStr.Substring(0, 2), 16);
            BlankBytes[0] = Convert.ToByte(BlankStr.Substring(2, 2), 16);
            BlankStr = Encoding.Unicode.GetString(BlankBytes);

            for (int i = 0; i < uniHeight; i++)
            {
                int blankCount = 0;
                for (int j = 0; j < uniWidth; j++)
                {
                    if (pictureUnicode[i, j] == 0)
                    {
                        blankCount++;
                    }
                    else
                    {
                        for (int k = 0; k < blankCount; k++)
                        {
                            transformedText += BlankStr;
                        }
                        blankCount = 0;
                        byte[] uniBytes = new byte[2];
                        string convertStr = Convert.ToString(pictureUnicode[i, j] + uniStarter, 16);
                        uniBytes[1] = Convert.ToByte(convertStr.Substring(0, 2), 16);
                        uniBytes[0] = Convert.ToByte(convertStr.Substring(2, 2), 16);
                        transformedText += Encoding.Unicode.GetString(uniBytes);
                    }
                }
                transformedText += "\r\n";
            }
            performedTexts.Add(transformedText);
        }

        private double[,] ditherFS(double[,] processData)
        {
            int pictureHeight = processData.GetLength(1);
            int pictureWidth = processData.GetLength(0);

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

            return processData;
        }

        private double[,] ditherThresh(double[,] processData)
        {
            int pictureHeight = processData.GetLength(1);
            int pictureWidth = processData.GetLength(0);

            // process Thresh dithering
            for (int i = 0; i < pictureHeight; i++)
            {
                for (int j = 0; j < pictureWidth; j++)
                {
                    processData[j, i] = (processData[j, i] >= threshold) ? 1 : 0;
                }
            }

            return processData;
        }
    }
}
