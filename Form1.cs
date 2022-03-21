using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obiz_Painter
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setup();
        }

        int x0, y0;
        Graphics K;
        Pen pen;
        Bitmap Painter;

        public void setup()
        {
            Painter = new Bitmap(775, 450);
            K = Graphics.FromImage(Painter);
            pen = new Pen(Color.Black, 1);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            getPoint(e.X,e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                K.DrawLine(pen, x0, y0, e.X, e.Y);
                getPoint(e.X, e.Y);
                pictureBox1.Image = Painter;
            }
        }

        public void getPoint(int x , int y)
        {
            x0 = x;
            y0 = y;
        }
    }


}
