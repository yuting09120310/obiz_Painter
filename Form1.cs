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

        int X0, Y0;
        Graphics Layer;
        Pen Pen;
        Bitmap Painter;
        string figure;

        public Form1()
        {
            InitializeComponent();
            setup();
        }

        public void setup()
        {
            figure = "line";
            Painter = new Bitmap(775, 450);
            //創建一個可編輯的圖層
            Layer = Graphics.FromImage(Painter);
            Pen = new Pen(Color.Black, 1);
            Tb_Wide.Text = "1";
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(figure == "line")
            {
                getPoint(e.X, e.Y);                                //抓取當前座標
            }
            else if(figure == "Ellipse")
            {
                Rectangle rect = new Rectangle(e.X, e.Y, 40, 40);
                Layer.DrawEllipse(Pen, rect);                                  
            }
            else
            {
                Rectangle rect = new Rectangle(e.X, e.Y, 40, 40);
                Layer.DrawRectangle(Pen, rect);
            }

            pictureBox1.Image = Painter;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if(figure == "line")
                {
                    Layer.DrawLine(Pen, X0, Y0, e.X, e.Y);            //
                    getPoint(e.X, e.Y);                           //抓取當前座標
                    pictureBox1.Image = Painter;
                }
            }
        }


        //變更顏色
        private void Btn_Green_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Pen = new Pen(colorDialog1.Color, float.Parse(Tb_Wide.Text));
                Btn_Green.BackColor = colorDialog1.Color;
            }
        }

        private void Tb_Wide_TextChanged(object sender, EventArgs e)
        {
            Pen = new Pen(colorDialog1.Color, float.Parse(Tb_Wide.Text));
        }





        private void Btn_Line_Click(object sender, EventArgs e)
        {
            figure = "line";
        }

        private void Btn_Ellipse_Click(object sender, EventArgs e)
        {
            figure = "Ellipse";
        }

        private void Btn_Rectangle_Click(object sender, EventArgs e)
        {
            figure = "Rectangle";
        }

        public void getPoint(int x , int y)
        {
            X0 = x;
            Y0 = y;
        }
    }


}
