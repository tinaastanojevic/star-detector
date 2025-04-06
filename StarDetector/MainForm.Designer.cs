
namespace StarDetector
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxEdited = new System.Windows.Forms.PictureBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonDetectStars = new System.Windows.Forms.Button();
            this.labelNumberOfStarsValue = new System.Windows.Forms.Label();
            this.numericTickness = new System.Windows.Forms.NumericUpDown();
            this.numericBlockSize = new System.Windows.Forms.NumericUpDown();
            this.checkBoxShowCircles = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericConstantC = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxThresholdType = new System.Windows.Forms.ComboBox();
            this.buttonOpenStarsTable = new System.Windows.Forms.Button();
            this.labelNumberOfStars = new System.Windows.Forms.Label();
            this.buttonSaveReport = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTipStarDetails = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdited)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlockSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConstantC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(364, 598);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // pictureBoxEdited
            // 
            this.pictureBoxEdited.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxEdited.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxEdited.Location = new System.Drawing.Point(0, 10);
            this.pictureBoxEdited.Name = "pictureBoxEdited";
            this.pictureBoxEdited.Size = new System.Drawing.Size(372, 598);
            this.pictureBoxEdited.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEdited.TabIndex = 1;
            this.pictureBoxEdited.TabStop = false;
            this.pictureBoxEdited.Click += new System.EventHandler(this.pictureBoxEdited_Click);
            this.pictureBoxEdited.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxEdited_MouseMove);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoad.AutoSize = true;
            this.buttonLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(3, 8);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Padding = new System.Windows.Forms.Padding(10);
            this.buttonLoad.Size = new System.Drawing.Size(144, 47);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load image";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonDetectStars
            // 
            this.buttonDetectStars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDetectStars.AutoSize = true;
            this.buttonDetectStars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDetectStars.Enabled = false;
            this.buttonDetectStars.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetectStars.Location = new System.Drawing.Point(3, 72);
            this.buttonDetectStars.Name = "buttonDetectStars";
            this.buttonDetectStars.Padding = new System.Windows.Forms.Padding(10);
            this.buttonDetectStars.Size = new System.Drawing.Size(144, 47);
            this.buttonDetectStars.TabIndex = 3;
            this.buttonDetectStars.Text = "Detect stars";
            this.buttonDetectStars.UseVisualStyleBackColor = true;
            this.buttonDetectStars.Click += new System.EventHandler(this.buttonDetectStars_Click);
            // 
            // labelNumberOfStarsValue
            // 
            this.labelNumberOfStarsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNumberOfStarsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfStarsValue.Location = new System.Drawing.Point(153, 376);
            this.labelNumberOfStarsValue.Name = "labelNumberOfStarsValue";
            this.labelNumberOfStarsValue.Size = new System.Drawing.Size(145, 44);
            this.labelNumberOfStarsValue.TabIndex = 6;
            this.labelNumberOfStarsValue.Visible = false;
            // 
            // numericTickness
            // 
            this.numericTickness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericTickness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericTickness.Enabled = false;
            this.numericTickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTickness.Location = new System.Drawing.Point(153, 335);
            this.numericTickness.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericTickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTickness.Name = "numericTickness";
            this.numericTickness.ReadOnly = true;
            this.numericTickness.Size = new System.Drawing.Size(145, 22);
            this.numericTickness.TabIndex = 13;
            this.numericTickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTickness.ValueChanged += new System.EventHandler(this.numericTickness_ValueChanged);
            // 
            // numericBlockSize
            // 
            this.numericBlockSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericBlockSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericBlockSize.Enabled = false;
            this.numericBlockSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericBlockSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericBlockSize.Location = new System.Drawing.Point(153, 203);
            this.numericBlockSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericBlockSize.Name = "numericBlockSize";
            this.numericBlockSize.ReadOnly = true;
            this.numericBlockSize.Size = new System.Drawing.Size(145, 22);
            this.numericBlockSize.TabIndex = 9;
            this.numericBlockSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericBlockSize.ValueChanged += new System.EventHandler(this.numericBlockSize_ValueChanged);
            // 
            // checkBoxShowCircles
            // 
            this.checkBoxShowCircles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxShowCircles.Checked = true;
            this.checkBoxShowCircles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowCircles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowCircles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowCircles.Location = new System.Drawing.Point(13, 294);
            this.checkBoxShowCircles.Name = "checkBoxShowCircles";
            this.checkBoxShowCircles.Size = new System.Drawing.Size(124, 31);
            this.checkBoxShowCircles.TabIndex = 4;
            this.checkBoxShowCircles.Text = "Show circles";
            this.checkBoxShowCircles.UseVisualStyleBackColor = true;
            this.checkBoxShowCircles.CheckedChanged += new System.EventHandler(this.checkBoxShowCircles_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 44);
            this.label2.TabIndex = 8;
            this.label2.Text = "Block size:";
            // 
            // numericConstantC
            // 
            this.numericConstantC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericConstantC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericConstantC.Enabled = false;
            this.numericConstantC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericConstantC.Location = new System.Drawing.Point(153, 247);
            this.numericConstantC.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericConstantC.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.numericConstantC.Name = "numericConstantC";
            this.numericConstantC.ReadOnly = true;
            this.numericConstantC.Size = new System.Drawing.Size(145, 22);
            this.numericConstantC.TabIndex = 10;
            this.numericConstantC.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericConstantC.ValueChanged += new System.EventHandler(this.numericConstantC_ValueChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 44);
            this.label3.TabIndex = 11;
            this.label3.Text = "Constant C: ";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 128);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(144, 72);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose threshold type:";
            // 
            // comboBoxThresholdType
            // 
            this.comboBoxThresholdType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxThresholdType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxThresholdType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThresholdType.Enabled = false;
            this.comboBoxThresholdType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxThresholdType.FormattingEnabled = true;
            this.comboBoxThresholdType.Location = new System.Drawing.Point(153, 131);
            this.comboBoxThresholdType.Name = "comboBoxThresholdType";
            this.comboBoxThresholdType.Size = new System.Drawing.Size(145, 24);
            this.comboBoxThresholdType.TabIndex = 12;
            this.comboBoxThresholdType.SelectedIndexChanged += new System.EventHandler(this.comboBoxThresholdType_SelectedIndexChanged);
            // 
            // buttonOpenStarsTable
            // 
            this.buttonOpenStarsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenStarsTable.AutoSize = true;
            this.buttonOpenStarsTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenStarsTable.Enabled = false;
            this.buttonOpenStarsTable.Location = new System.Drawing.Point(3, 428);
            this.buttonOpenStarsTable.Name = "buttonOpenStarsTable";
            this.buttonOpenStarsTable.Size = new System.Drawing.Size(144, 47);
            this.buttonOpenStarsTable.TabIndex = 14;
            this.buttonOpenStarsTable.Text = "Open stars table";
            this.buttonOpenStarsTable.UseVisualStyleBackColor = true;
            this.buttonOpenStarsTable.Click += new System.EventHandler(this.buttonOpenStarsTable_Click);
            // 
            // labelNumberOfStars
            // 
            this.labelNumberOfStars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNumberOfStars.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfStars.Location = new System.Drawing.Point(3, 376);
            this.labelNumberOfStars.Name = "labelNumberOfStars";
            this.labelNumberOfStars.Size = new System.Drawing.Size(144, 44);
            this.labelNumberOfStars.TabIndex = 5;
            this.labelNumberOfStars.Text = "Number of detected stars:";
            this.labelNumberOfStars.Visible = false;
            // 
            // buttonSaveReport
            // 
            this.buttonSaveReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveReport.AutoSize = true;
            this.buttonSaveReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveReport.Enabled = false;
            this.buttonSaveReport.Location = new System.Drawing.Point(3, 492);
            this.buttonSaveReport.Name = "buttonSaveReport";
            this.buttonSaveReport.Size = new System.Drawing.Size(144, 47);
            this.buttonSaveReport.TabIndex = 13;
            this.buttonSaveReport.Text = "Save report";
            this.buttonSaveReport.UseVisualStyleBackColor = true;
            this.buttonSaveReport.Click += new System.EventHandler(this.buttonSaveReport_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxOriginal);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxEdited);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.splitContainer1.Size = new System.Drawing.Size(759, 618);
            this.splitContainer1.SplitterDistance = 374;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(13);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel);
            this.splitContainer2.Size = new System.Drawing.Size(1066, 620);
            this.splitContainer2.SplitterDistance = 761;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 6;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.buttonSaveImage, 0, 10);
            this.tableLayoutPanel.Controls.Add(this.buttonDetectStars, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonSaveReport, 0, 9);
            this.tableLayoutPanel.Controls.Add(this.buttonLoad, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonOpenStarsTable, 0, 8);
            this.tableLayoutPanel.Controls.Add(this.labelNumberOfStars, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.labelNumberOfStarsValue, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.numericTickness, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.checkBoxShowCircles, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.numericConstantC, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.numericBlockSize, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.comboBoxThresholdType, 1, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 11;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.37698F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.37698F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.79203F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.263885F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.263885F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.263885F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.263885F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.263885F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.37698F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.37698F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.38061F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(301, 618);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveImage.Enabled = false;
            this.buttonSaveImage.Location = new System.Drawing.Point(3, 559);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(144, 47);
            this.buttonSaveImage.TabIndex = 2;
            this.buttonSaveImage.Text = "Save image";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 44);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thickness: ";
            // 
            // toolTipStarDetails
            // 
            this.toolTipStarDetails.BackColor = System.Drawing.SystemColors.Desktop;
            this.toolTipStarDetails.ForeColor = System.Drawing.SystemColors.HotTrack;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1066, 620);
            this.Controls.Add(this.splitContainer2);
            this.Name = "MainForm";
            this.Text = "Star Detector";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdited)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlockSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConstantC)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxEdited;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonDetectStars;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox checkBoxShowCircles;
        private System.Windows.Forms.Label labelNumberOfStars;
        private System.Windows.Forms.Label labelNumberOfStarsValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericBlockSize;
        private System.Windows.Forms.NumericUpDown numericConstantC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxThresholdType;
        private System.Windows.Forms.NumericUpDown numericTickness;
        private System.Windows.Forms.Button buttonSaveReport;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button buttonOpenStarsTable;
        private System.Windows.Forms.ToolTip toolTipStarDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button buttonSaveImage;
    }
}

