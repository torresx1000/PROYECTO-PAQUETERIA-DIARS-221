namespace PROYECTO_PAQUETERIA_DIARS
{
    partial class Fondos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fondos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "7-76329_display-wallpapers-full-hd-wallpaper-search-2560-x.jpg");
            this.imageList1.Images.SetKeyName(1, "129-1293412_shrubs-sunlight-wyoming-landscape-clouds-mountain-road-wallpaper.jpg");
            this.imageList1.Images.SetKeyName(2, "862f2aa82a5b22e5c42d553a189200df.jpg");
            this.imageList1.Images.SetKeyName(3, "1366_2000.jpg");
            this.imageList1.Images.SetKeyName(4, "0944340dda7f9f3c27e1ba773e30648b.jpg");
            this.imageList1.Images.SetKeyName(5, "a5d068b1a4b6add23378bd789864e874.jpg");
            this.imageList1.Images.SetKeyName(6, "full-hd-nature-backgrounds-1920x1200-wallpaper-preview.jpg");
            this.imageList1.Images.SetKeyName(7, "images.jpg");
            this.imageList1.Images.SetKeyName(8, "j9vm3H.jpg");
            this.imageList1.Images.SetKeyName(9, "mountain-3840x2160-lake-nature-4k-14996-wallpaper-preview.jpg");
            this.imageList1.Images.SetKeyName(10, "nature-4k-pc-full-hd-wallpaper-preview.jpg");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Fondos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 171);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fondos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
    }
}