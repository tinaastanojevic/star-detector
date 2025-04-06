using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point = OpenCvSharp.Point;

namespace StarDetector
{
    public class StarFinder
    {
        private List<Star> stars;
        private Mat originalImage;
        private Mat grayImage;
        private Mat binaryImage;
        private Mat imageWithCircles;
        private bool[,] processed;
        public StarFinder(Mat originalImage)
        {
            this.originalImage = originalImage;
            binaryImage = new Mat();
            grayImage = new Mat();
            imageWithCircles = new Mat();
            processed = new bool[originalImage.Rows, originalImage.Cols];
            inicializationOfProcessedArray();
            stars = new List<Star>();
        }
        public void inicializationOfProcessedArray()
        {
            for (int y = 0; y < originalImage.Rows; y++)
            {
                for (int x = 0; x < originalImage.Cols; x++)
                {
                    processed[y, x] = false;
                }
            }
        }

        public Mat getOriginalImage()
        {
            return originalImage;
        }
        public Mat getBinaryImage()
        {
            return binaryImage;
        }
        public Mat getImageWithCircles()
        {
            return imageWithCircles;
        }

        public int getNumberOfStars()
        {
            return stars.Count;
        }

        public List<Star> getStars()
        {
            return stars;
        }

        public bool processImage(string thresholdType, int blockSize, float C, int thickness)
        {
            switch (thresholdType)
            {
                case "Otsu thresholding":
                    otsuThreshold();
                    break;
                case "Adaptive Gaussian thresholding":
                    adaptiveThreshold(blockSize, C, AdaptiveThresholdTypes.GaussianC);
                    break;
                case "Adaptive Mean thresholding":
                    adaptiveThreshold(blockSize, C, AdaptiveThresholdTypes.MeanC);
                    break;
            }
            findStarsIteratively();
            findRadiusAndCenter();
            drawCircles(thickness);
            return true;
        }
        public Mat otsuThreshold()
        {
            Cv2.CvtColor(originalImage, grayImage, ColorConversionCodes.BGR2GRAY);
            Cv2.Threshold(grayImage, binaryImage, 0, 255, ThresholdTypes.Binary | ThresholdTypes.Otsu);

            return binaryImage;
        }
        public Mat adaptiveThreshold(int blockSize, float C, AdaptiveThresholdTypes type)
        {
            Cv2.CvtColor(originalImage, grayImage, ColorConversionCodes.BGR2GRAY);
            Cv2.AdaptiveThreshold(grayImage, binaryImage, 255, type, ThresholdTypes.Binary, blockSize, C);
            imageWithCircles = new Mat();
            return binaryImage;
        }
        
        public void findStarsIteratively()
        {
            stars.Clear();
            Star.ResetCounter();
            inicializationOfProcessedArray();

            for (int y = 0; y < binaryImage.Rows; y++)
            {
                for (int x = 0; x < binaryImage.Cols; x++)
                {
                    if (!processed[y, x] && isStarPixel(y, x))
                    {
                        stars.Add(new Star());
                        findStarPixelsIteratively(y, x);
                    }
                }
            }
        }

        public void findStarPixelsIteratively(int starY, int starX)
        {
            Stack<Point> stack = new Stack<Point>();
            stack.Push(new Point(starX, starY));

            while (stack.Count > 0)
            {
                Point currentStar = stack.Pop();
                int x = currentStar.X;
                int y = currentStar.Y;

                if (y < 0 || y >= binaryImage.Rows || x < 0 || x >= binaryImage.Cols) continue;

                if (!isStarPixel(y, x) || processed[y, x]) continue;

                processed[y, x] = true;
                stars.Last().addPixels(new Point(x, y));

                stack.Push(new Point(x, y - 1));
                stack.Push(new Point(x, y + 1));
                stack.Push(new Point(x - 1, y));
                stack.Push(new Point(x + 1, y));
            }
        }
        private bool isStarPixel(int y, int x)
        {
            return binaryImage.At<byte>(y, x) == 255;
        }

        public void findRadiusAndCenter()
        {
            int minRadius = 1;
            foreach (Star star in stars)
            {
                int pixelCount = star.Pixels.Count;
                if (pixelCount == 1)
                {
                    star.Center = star.Pixels[0];
                    star.Radius = minRadius;
                }
                else
                {
                    int sumX = 0, sumY = 0;
                    int avgX, avgY;
                    foreach (Point pixel in star.Pixels)
                    {
                        sumX += pixel.X;
                        sumY += pixel.Y;
                    }
                    avgX = sumX / pixelCount;
                    avgY = sumY / pixelCount;
                    star.Center = new Point(avgX, avgY);

                    double maxRadius = 0;
                    foreach (Point pixel in star.Pixels)
                    {
                        double distance = Math.Sqrt(Math.Pow(pixel.X - star.Center.X, 2) + Math.Pow(star.Center.Y - avgY, 2));
                        if (distance > maxRadius)
                            maxRadius = distance;
                    }
                    if ((int)maxRadius == 0) star.Radius = minRadius;
                    else
                        star.Radius = (int)Math.Round(maxRadius);
                }
                star.identifyStarCategory();
            }

        }

        public void drawCircles(int thickness)
        {
            Mat colorImage = new Mat();
            Mat binaryImageCopy = binaryImage.Clone();
            Cv2.CvtColor(binaryImageCopy, colorImage, ColorConversionCodes.GRAY2BGR);
            int radius, minValueForRadius = 3;

            foreach (Star star in stars)
            {
                if (star.Radius < minValueForRadius)
                {
                    radius = minValueForRadius;
                }
                else
                {
                    radius = star.Radius + 1;
                }

                Cv2.Circle(colorImage, star.Center.X, star.Center.Y, radius, new Scalar(0, 0, 255), thickness, LineTypes.AntiAlias);
            }

            imageWithCircles = colorImage;
        }
        public void ShowStarTooltip(PictureBox pictureBox, MouseEventArgs e, ToolTip toolTip)
        {
            if (pictureBox.Image != null)
            {

                if (stars != null && stars.Count != 0)
                {
                    Image image = pictureBox.Image;
                    float scaleX = (float)image.Width / pictureBox.ClientSize.Width;
                    float scaleY = (float)image.Height / pictureBox.ClientSize.Height;

                    int x = (int)(e.X * scaleX);
                    int y = (int)(e.Y * scaleY);

                    if (x < 0 || x >= image.Width || y < 0 || y >= image.Height)
                    {
                        toolTip.Hide(pictureBox);
                        return;
                    }

                    Color pixelColor = ((Bitmap)image).GetPixel(x, y);

                    if (pixelColor.R == 0 && pixelColor.G == 0 && pixelColor.B == 0)
                    {
                        toolTip.Hide(pictureBox);
                        return;
                    }

                    foreach (Star star in stars)
                    {
                        if (star.Pixels.Contains(new Point(x, y)))
                        {
                            string tooltipText = $"Star ID: {star.StarID}\nCenter: ({ star.Center.X}, {star.Center.Y})\nRadius: {star.Radius}";
                            toolTip.Show(tooltipText, pictureBox, e.Location, 2000);
                            return;

                        }
                    }
                }
            }
        }
    }
}
