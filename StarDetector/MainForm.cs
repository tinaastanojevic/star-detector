using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarDetector
{
    public partial class MainForm : Form
    {

        private OpenFileDialog openFileDialog;

        private Mat originalImage;
        private Bitmap bitmapImage;
        private StarFinder starFinder;
        private int maxBlockSize;
        bool isProcessed;
        public MainForm()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            originalImage = new Mat();
            KeyPreview = true;
            isProcessed = false;
            comboBoxThresholdType.Items.Add("Otsu thresholding");
            comboBoxThresholdType.Items.Add("Adaptive Gaussian thresholding");
            comboBoxThresholdType.Items.Add("Adaptive Mean thresholding");
            comboBoxThresholdType.SelectedIndex = 0;
            disableOrEnableCirclesOptions(false);

            tableLayoutPanel.SetColumnSpan(checkBoxShowCircles, 2);
            tableLayoutPanel.SetColumnSpan(buttonLoad, 2);
            tableLayoutPanel.SetColumnSpan(buttonDetectStars, 2);
            tableLayoutPanel.SetColumnSpan(buttonSaveReport, 2);
            tableLayoutPanel.SetColumnSpan(buttonOpenStarsTable, 2);
            tableLayoutPanel.SetColumnSpan(buttonSaveImage, 2);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (openFileExplorer())
            {
                bitmapImage = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(originalImage);
                pictureBoxOriginal.Image = bitmapImage;
                pictureBoxEdited.Image = bitmapImage;
                isProcessed = false;
                starFinder = new StarFinder(originalImage);

                disableOrEnableCirclesOptions(false);
                showOrHideNumberOfStars(false);
                comboBoxThresholdType.Enabled = true;
                buttonOpenStarsTable.Enabled = false;
                buttonSaveImage.Enabled = false;
                buttonSaveReport.Enabled = false;
                buttonDetectStars.Enabled = true;
                pictureBoxEdited.Cursor = Cursors.Hand;
            }

        }
        private bool openFileExplorer()
        {
            string CombinedPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Resources");
            openFileDialog.InitialDirectory = Path.GetFullPath(CombinedPath);

            openFileDialog.Filter = "Photos (*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.jfif,*.webp)|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.jfif;*.webp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = Cv2.ImRead(openFileDialog.FileName);

                return true;
            }
            else
            {
                MessageBox.Show("Unable to open an image!");
                return false;
            }

        }

        private void buttonDetectStars_Click(object sender, EventArgs e)
        {

            if (originalImage == null || originalImage.Empty())
            {
                MessageBox.Show("No image found for detection.");
                return;
            }

            isProcessed = starFinder.processImage(comboBoxThresholdType.SelectedItem as string, (int)numericBlockSize.Value, (float)numericConstantC.Value, (int)numericTickness.Value);

            disableOrEnableCirclesOptions(true);
            chagePictureBoxImage(hideOrShowCircles());
            showOrHideNumberOfStars(true);
            buttonSaveReport.Enabled = true;
            buttonOpenStarsTable.Enabled = true;
            buttonSaveImage.Enabled = true;
        }

        private void showOrHideNumberOfStars(bool show)
        {
            labelNumberOfStarsValue.Visible = show;
            labelNumberOfStars.Visible = show;
            if (show)
                labelNumberOfStarsValue.Text = starFinder.getNumberOfStars().ToString();
            else labelNumberOfStarsValue.Text = "";
        }

        private void checkBoxShowCircles_CheckedChanged(object sender, EventArgs e)
        {
            chagePictureBoxImage(hideOrShowCircles());
        }

        private Mat hideOrShowCircles()
        {
            if (starFinder.getBinaryImage() == null || starFinder.getBinaryImage().Empty()) return null;
            return checkBoxShowCircles.Checked ? starFinder.getImageWithCircles() : starFinder.getBinaryImage();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (checkBoxShowCircles.Enabled)
            {
                if (e.KeyCode == Keys.Space)
                {
                    checkBoxShowCircles.Checked = !checkBoxShowCircles.Checked;
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void comboBoxThresholdType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = comboBoxThresholdType.SelectedItem as string;
            if (selectedType == "Adaptive Mean thresholding" || selectedType == "Adaptive Gaussian thresholding")
            {
                numericBlockSize.Enabled = true;
                numericConstantC.Enabled = true;
                maxBlockSize = Math.Min(originalImage.Width, originalImage.Height) / 10;
                numericBlockSize.Maximum = maxBlockSize;
            }
            else
            {
                numericBlockSize.Enabled = false;
                numericConstantC.Enabled = false;
            }
        }

        private void numericBlockSize_ValueChanged(object sender, EventArgs e)
        {
            
            hideAndDisableElements();
            isProcessed = false;
            int blockSize = (int)numericBlockSize.Value;
            if (blockSize % 2 == 0)
            {
                blockSize--;

            }
            if (blockSize > maxBlockSize) blockSize = maxBlockSize;

            numericBlockSize.Value = blockSize;

            getThresholdedImage(blockSize, (float)numericConstantC.Value);
        }

        private void numericConstantC_ValueChanged(object sender, EventArgs e)
        {
            hideAndDisableElements();
            
            isProcessed = false;
            getThresholdedImage((int)numericBlockSize.Value, (float)numericConstantC.Value);
        }
        private void hideAndDisableElements()
        {
            disableOrEnableCirclesOptions(false);
            showOrHideNumberOfStars(false);
            buttonSaveReport.Enabled = false;
            buttonOpenStarsTable.Enabled = false;
            buttonSaveImage.Enabled = false;
        }
        private void getThresholdedImage(int blockSize, float constantC)
        {
            AdaptiveThresholdTypes type;
            if (comboBoxThresholdType.SelectedItem.ToString() == "Adaptive Gaussian thresholding")
                type = AdaptiveThresholdTypes.GaussianC;
            else
                type = AdaptiveThresholdTypes.MeanC;

            chagePictureBoxImage(starFinder.adaptiveThreshold(blockSize, constantC, type));
        }
        private void numericTickness_ValueChanged(object sender, EventArgs e)
        {
            starFinder.drawCircles((int)numericTickness.Value);
            chagePictureBoxImage(hideOrShowCircles());
        }
        private void chagePictureBoxImage(Mat image)
        {
            if (image == null) return;
            pictureBoxEdited.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image);
        }

        private void buttonSaveReport_Click(object sender, EventArgs e)
        {
            List<Star> stars = starFinder.getStars();
            if (stars == null || stars.Count == 0)
            {
                MessageBox.Show("Can't save a file before detecting stars");
                return;
            }

            string text = "Stars report: \n";
            text += $"Total number of detected stars: {stars.Count}\n";

            foreach (Star star in stars)
            {
                text += $"Star ID: {star.StarID}, Center: ({star.Center.X}, {star.Center.Y}), Radius: {star.Radius}\n";
            }

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a location to save the report";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderBrowserDialog.SelectedPath;
                    string fileName = GenerateFileName(comboBoxThresholdType.SelectedItem.ToString(), Path.GetFileNameWithoutExtension(openFileDialog.FileName));
                    fileName += ".txt";
                    string fullPath = Path.Combine(folderPath, fileName);
                    File.WriteAllText(fullPath, text);
                    MessageBox.Show("File is succesfully saved!");
                }
                else
                    MessageBox.Show("No location selected for saving.");
            }
        }
        private string GenerateFileName(string analysisType, string imageName)
        {
            DateTime currentDateTime = DateTime.Now;
            string date = currentDateTime.ToString("dd-MM-yyyy");
            string time = currentDateTime.ToString("HH-mm-ss");
            return $"{imageName}_{analysisType}_{date}_{time}";
        }
        private void disableOrEnableCirclesOptions(bool enable)
        {
            checkBoxShowCircles.Enabled = enable;
            numericTickness.Enabled = enable;
        }

        private void buttonOpenStarsTable_Click(object sender, EventArgs e)
        {
            List<Star> stars = starFinder.getStars();
            if (stars != null && stars.Count != 0)
            {
                StarsOverviewForm starsTableForm = new StarsOverviewForm(stars);
                starsTableForm.Show();
            }
            else
            {
                MessageBox.Show("Can't show table before detecting stars.");
                return;
            }
        }

        private void pictureBoxEdited_Click(object sender, EventArgs e)
        {
            if (pictureBoxEdited.Image != null)
            {
                FullScreenImageForm showFullScreen;
                if (starFinder.getBinaryImage().Empty())
                {
                    showFullScreen = new FullScreenImageForm(false, isProcessed, starFinder);
                }
                else showFullScreen = new FullScreenImageForm(checkBoxShowCircles.Checked, isProcessed, starFinder);

                showFullScreen.ShowDialog();
            }
        }

        private void pictureBoxEdited_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBoxEdited.Image != null && isProcessed)
                starFinder.ShowStarTooltip(pictureBoxEdited, e, toolTipStarDetails);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                splitContainer2.SplitterDistance = (int)(this.ClientSize.Width * 0.85);
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                return;
            }
            else
            {
                splitContainer2.SplitterDistance = (int)(this.ClientSize.Width * 0.75);
            }
        }

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            if (pictureBoxEdited.Image != null)
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    folderBrowserDialog.Description = "Select a location to save the image";

                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string folderPath = folderBrowserDialog.SelectedPath;
                        string imageName = GenerateFileName(comboBoxThresholdType.SelectedItem.ToString(), Path.GetFileNameWithoutExtension(openFileDialog.FileName));
                        imageName += ".png";
                        string fullPath = Path.Combine(folderPath, imageName);
                        if (checkBoxShowCircles.Checked)
                        {
                            Cv2.ImWrite(fullPath, starFinder.getImageWithCircles());
                        }
                        else
                            Cv2.ImWrite(fullPath, starFinder.getBinaryImage());

                        MessageBox.Show("Image is saved!");
                    }
                    else
                        MessageBox.Show("No location selected for saving.");
                }
            }
            else
                MessageBox.Show("No image available for saving.");
        }
    }
}
