using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarDetector
{
    public partial class FullScreenImageForm : Form
    {
        private StarFinder starFinder;
        private bool isChecked;
        private bool isProcessed;
        public FullScreenImageForm(bool isChecked,bool isProcessed, StarFinder starFinder)
        {
            InitializeComponent();
            this.isChecked = isChecked;
            this.isProcessed = isProcessed;
            this.starFinder = starFinder;
            showPicture();
        }

        private void FullScreenImage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
            {
                Close();
            }
            if (e.KeyCode == Keys.Space && !starFinder.getBinaryImage().Empty())
            {
                isChecked = !isChecked;
                showPicture();
            }
        }
        private void pictureBoxFullScreenImage_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxFullScreenImage_MouseMove(object sender, MouseEventArgs e)
        {
            if(isProcessed)
                starFinder.ShowStarTooltip(pictureBoxFullScreenImage, e, toolTipForFullScreen);
        }
        private void showPicture()
        {
            if (starFinder.getBinaryImage().Empty())
            {
                pictureBoxFullScreenImage.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(starFinder.getOriginalImage());
            }
            else if(starFinder.getImageWithCircles().Empty())
            {
                pictureBoxFullScreenImage.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(starFinder.getBinaryImage());
            }
            else
             pictureBoxFullScreenImage.Image = isChecked ? OpenCvSharp.Extensions.BitmapConverter.ToBitmap(starFinder.getImageWithCircles()) : OpenCvSharp.Extensions.BitmapConverter.ToBitmap(starFinder.getBinaryImage());
        }
    }
}
