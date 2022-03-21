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
        Bitmap Bee;

        public void setup()
        {
            Bee = new Bitmap(400, 400);
            K = Graphics.FromImage(Bee);
            pen = new Pen(Color.Black, 1);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = e.X;
            y0 = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                K.DrawLine(pen, x0, y0, e.X, e.Y);
                x0 = e.X;
                y0 = e.Y;
                pictureBox1.Image = Bee;
            }
        }

    }


}
