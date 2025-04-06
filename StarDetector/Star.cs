using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point = OpenCvSharp.Point;

namespace StarDetector
{
    public class Star
    {
        public int StarID { get; set; }
        public static int counter = 0;

        public List<Point> Pixels { get; set; }
        public int Radius { get; set; }
        public Point Center { get; set; }
        public string Category { get; set; }
        public Star(int radius, Point center)
        {
            Pixels = new List<Point>();
            Radius = radius;
            Center = center;
            counter++;
            StarID = counter;
        }
        public Star()
        {
            Pixels = new List<Point>();
            Radius = 0;
            Category = "";
            Center = new Point(-1, -1);
            counter++;
            StarID = counter;
        }
        public void addPixels(Point pixel)
        {
            Pixels.Add(pixel);
        }
        public void identifyStarCategory()
        {
            if (Radius < 5)
            {
                Category = "Small";
            }
            else if (Radius <= 10)
            {
                Category = "Medium";
            }
            else
            {
                Category = "Big";
            }
        }
        public static void ResetCounter()
        {
            counter = 0;
        }

    }
}
