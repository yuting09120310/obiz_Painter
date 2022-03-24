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
            Pen = new Pen(Color.Black, 1);
            Tb_Wide.Text = "1";
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            getPoint(e.X,e.Y);                                //抓取當前座標
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Layer.DrawLine(Pen, X0, Y0, e.X, e.Y);            //
                getPoint(e.X, e.Y);                           //抓取當前座標
                pictureBox1.Image = Painter;
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

        public void getPoint(int x , int y)
        {
            X0 = x;
            Y0 = y;
        }
    }


}
