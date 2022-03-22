﻿using System;
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

        int x0, y0;
        Graphics Layer;
        Pen pen;
        Bitmap Painter;

        public Form1()
        {
            InitializeComponent();
            setup();
        }



        public void setup()
        {
            Painter = new Bitmap(775, 450);
            //創建一個可編輯的圖層
            Layer = Graphics.FromImage(Painter);
            pen = new Pen(Color.Black, 1);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            getPoint(e.X,e.Y);                                //抓取當前座標
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                K.DrawLine(pen, x0, y0, e.X, e.Y);            //
                getPoint(e.X, e.Y);                           //抓取當前座標
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
