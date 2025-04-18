﻿
namespace StarDetector
{
    partial class StarsOverviewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewStarsTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewCategoriesTable = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStarsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoriesTable)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStarsTable
            // 
            this.dataGridViewStarsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStarsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewStarsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStarsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStarsTable.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewStarsTable.Name = "dataGridViewStarsTable";
            this.dataGridViewStarsTable.ReadOnly = true;
            this.dataGridViewStarsTable.RowHeadersWidth = 51;
            this.dataGridViewStarsTable.RowTemplate.Height = 24;
            this.dataGridViewStarsTable.Size = new System.Drawing.Size(593, 604);
            this.dataGridViewStarsTable.TabIndex = 0;
            // 
            // dataGridViewCategoriesTable
            // 
            this.dataGridViewCategoriesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategoriesTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewCategoriesTable.Location = new System.Drawing.Point(602, 3);
            this.dataGridViewCategoriesTable.Name = "dataGridViewCategoriesTable";
            this.dataGridViewCategoriesTable.ReadOnly = true;
            this.dataGridViewCategoriesTable.RowHeadersWidth = 51;
            this.dataGridViewCategoriesTable.RowTemplate.Height = 24;
            this.dataGridViewCategoriesTable.Size = new System.Drawing.Size(315, 150);
            this.dataGridViewCategoriesTable.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.1087F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.8913F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewStarsTable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewCategoriesTable, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(920, 610);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // StarsOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 610);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StarsOverviewForm";
            this.Text = "Stars Overview";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStarsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoriesTable)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStarsTable;
        private System.Windows.Forms.DataGridView dataGridViewCategoriesTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}