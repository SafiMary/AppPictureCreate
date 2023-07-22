namespace AppPictureCreate
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBarUPDown = new System.Windows.Forms.TrackBar();
            this.trackBarHorizont = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUPDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHorizont)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarSize
            // 
            this.trackBarSize.Location = new System.Drawing.Point(39, 364);
            this.trackBarSize.MinimumSize = new System.Drawing.Size(100, 100);
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(144, 56);
            this.trackBarSize.TabIndex = 0;
            this.trackBarSize.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 49);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(220, 220);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(120, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // trackBarUPDown
            // 
            this.trackBarUPDown.Location = new System.Drawing.Point(267, 364);
            this.trackBarUPDown.Name = "trackBarUPDown";
            this.trackBarUPDown.Size = new System.Drawing.Size(144, 56);
            this.trackBarUPDown.TabIndex = 0;
            this.trackBarUPDown.Scroll += new System.EventHandler(this.trackBarUPDown_Scroll);
            // 
            // trackBarHorizont
            // 
            this.trackBarHorizont.Location = new System.Drawing.Point(517, 364);
            this.trackBarHorizont.Name = "trackBarHorizont";
            this.trackBarHorizont.Size = new System.Drawing.Size(144, 56);
            this.trackBarHorizont.TabIndex = 0;
            this.trackBarHorizont.Scroll += new System.EventHandler(this.trackBarHorizont_Scroll);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trackBarHorizont);
            this.Controls.Add(this.trackBarUPDown);
            this.Controls.Add(this.trackBarSize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Картинка белый кот";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUPDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHorizont)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBarUPDown;
        private System.Windows.Forms.TrackBar trackBarHorizont;
    }
}