using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppPictureCreate
{
    public partial class Form3 : Form
    {
        Size StartSize;
        public Form3()
        {
            InitializeComponent();
            StartSize = pictureBox1.Size;
            ShowToolTip();
        }
        public void ShowToolTip()
        {
            System.Windows.Forms.ToolTip myToolTip = new System.Windows.Forms.ToolTip();
            myToolTip.ShowAlways = /*false */true; // Показывать подсказки когда
                                                   // родительское окно не активно
                                                   //myToolTip.ShowAlways = false /*true*/;

            myToolTip.SetToolTip(trackBarSize, "Увеличение размера картинки");
            myToolTip.SetToolTip(trackBarHorizont, "Перемещение картинки по горизонтали");
            myToolTip.SetToolTip(trackBarUPDown, "Перемещение объекта вверх-вниз");
        }
       
        private void trackBarSize_Scroll(object sender, EventArgs e)
        {pictureBox1.Width = StartSize.Width * trackBarSize.Value;
            pictureBox1.Height = StartSize.Height * trackBarSize.Value;

        }

        private void trackBarUPDown_Scroll(object sender, EventArgs e)
        {  int Y = 30 + trackBarUPDown.Value * 10;
            pictureBox1.Location = new Point(pictureBox1.Location.X, Y);

        }

        private void trackBarHorizont_Scroll(object sender, EventArgs e)
        { var X = 100 + (int)trackBarHorizont.Value;
            pictureBox1.Location = new Point(X, pictureBox1.Location.Y);

        }
    }
}
