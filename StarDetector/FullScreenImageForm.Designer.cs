
namespace StarDetector
{
    partial class FullScreenImageForm
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
            this.pictureBoxFullScreenImage = new System.Windows.Forms.PictureBox();
            this.toolTipForFullScreen = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFullScreenImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFullScreenImage
            // 
            this.pictureBoxFullScreenImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFullScreenImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFullScreenImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFullScreenImage.Name = "pictureBoxFullScreenImage";
            this.pictureBoxFullScreenImage.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxFullScreenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFullScreenImage.TabIndex = 0;
            this.pictureBoxFullScreenImage.TabStop = false;
            this.pictureBoxFullScreenImage.Click += new System.EventHandler(this.pictureBoxFullScreenImage_Click);
            this.pictureBoxFullScreenImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxFullScreenImage_MouseMove);
            // 
            // FullScreenImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxFullScreenImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FullScreenImage";
            this.Text = "FullScreenImage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FullScreenImage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFullScreenImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFullScreenImage;
        private System.Windows.Forms.ToolTip toolTipForFullScreen;
    }
}