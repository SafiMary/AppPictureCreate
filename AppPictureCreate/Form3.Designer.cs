namespace AppPictureCreate
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.trackBarUPDown = new System.Windows.Forms.TrackBar();
            this.trackBarHorizont = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUPDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHorizont)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 55);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(250, 250);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(150, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // trackBarSize
            // 
            this.trackBarSize.Location = new System.Drawing.Point(53, 338);
            this.trackBarSize.MinimumSize = new System.Drawing.Size(100, 100);
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(144, 100);
            this.trackBarSize.TabIndex = 1;
            this.trackBarSize.Scroll += new System.EventHandler(this.trackBarSize_Scroll);
            // 
            // trackBarUPDown
            // 
            this.trackBarUPDown.Location = new System.Drawing.Point(281, 338);
            this.trackBarUPDown.Name = "trackBarUPDown";
            this.trackBarUPDown.Size = new System.Drawing.Size(144, 56);
            this.trackBarUPDown.TabIndex = 2;
            this.trackBarUPDown.Scroll += new System.EventHandler(this.trackBarUPDown_Scroll);
            // 
            // trackBarHorizont
            // 
            this.trackBarHorizont.Location = new System.Drawing.Point(537, 338);
            this.trackBarHorizont.Name = "trackBarHorizont";
            this.trackBarHorizont.Size = new System.Drawing.Size(144, 56);
            this.trackBarHorizont.TabIndex = 3;
            this.trackBarHorizont.Scroll += new System.EventHandler(this.trackBarHorizont_Scroll);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBarHorizont);
            this.Controls.Add(this.trackBarUPDown);
            this.Controls.Add(this.trackBarSize);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUPDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHorizont)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.TrackBar trackBarUPDown;
        private System.Windows.Forms.TrackBar trackBarHorizont;
    }
}