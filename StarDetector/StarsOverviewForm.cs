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
    public partial class StarsOverviewForm : Form
    {
        private List<Star> stars;
        public StarsOverviewForm(List<Star> stars)
        {
            InitializeComponent();
            this.stars = stars;
            fillTheTable();
        }
        private void fillTheTable()
        {
            int[] counts = new int[3];
            string[] categories = { "Small", "Medium", "Big" };

            dataGridViewStarsTable.Rows.Clear();
            if (dataGridViewStarsTable.Columns.Count == 0)
            {
                dataGridViewStarsTable.Columns.Add("Star ID", "Star ID");
                dataGridViewStarsTable.Columns.Add("Radius (px)", "Radius (px)");
                dataGridViewStarsTable.Columns.Add("Category", "Category");
                dataGridViewStarsTable.Columns.Add("X Position", "X Position");
                dataGridViewStarsTable.Columns.Add("Y Position", "Y Position");
            }

            dataGridViewCategoriesTable.Rows.Clear();
            if (dataGridViewCategoriesTable.Columns.Count == 0)
            {
                dataGridViewCategoriesTable.Columns.Add("Category", "Category");
                dataGridViewCategoriesTable.Columns.Add("Count", "Count");
            }

            foreach (Star star in stars)
            {
                dataGridViewStarsTable.Rows.Add(star.StarID, star.Radius, star.Category, star.Center.X, star.Center.Y);

                if (star.Category == "Small")
                    counts[0]++;
                else if (star.Category == "Medium")
                    counts[1]++;
                else
                    counts[2]++;
            }

            for (int i = 0; i < 3; i++)
            {
                dataGridViewCategoriesTable.Rows.Add(categories[i], counts[i]);
            }
        }
    }
}
