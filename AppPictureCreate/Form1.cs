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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            ShowToolTip();
        }
        public void ShowToolTip()
        {
            System.Windows.Forms.ToolTip myToolTip = new System.Windows.Forms.ToolTip();
            myToolTip.ShowAlways = /*false */true; // Показывать подсказки когда
                                                   // родительское окно не активно
                                                   //myToolTip.ShowAlways = false /*true*/;

           

            myToolTip.SetToolTip(pictureBox1, "Нажмите на картинку");
            myToolTip.SetToolTip(pictureBox2, "Нажмите на картинку");
        
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {//создали событие, при клике на изображение на 1 форме, переходим в меню на 2 форме
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Show();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //создали событие, при клике на изображение на 1 форме, переходим в меню на 3 форме
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
            this.Show();
        }
    }
}
