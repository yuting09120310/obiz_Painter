using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alex_Component;

namespace obiz_Painter
{

    public partial class Form1 : Form
    {

        int X0, Y0;
        Graphics Layer;
        Pen Pen;
        Bitmap Painter;
        string Figure;
        string AppName = "";
        Msg_log msg_Log = new Msg_log();

        public Form1()
        {
            InitializeComponent();
            setup();
        }

        public void setup()
        {
            try
            {
                Figure = "line";
                Painter = new Bitmap(775, 450);
                //創建一個可編輯的圖層
                Layer = Graphics.FromImage(Painter);
                Pen = new Pen(Color.Black, 1);
                txtWide.Text = "1";
            }catch(Exception ex)
            {
                msg_Log.save_log(AppName, ex);
            }
        }

        private void picImg_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                Rectangle rect = new Rectangle(e.X, e.Y, 40, 40);
                if (Figure == "line")
                {
                    getPoint(e.X, e.Y);                                //抓取當前座標
                }
                else if (Figure == "Ellipse")
                {
                    Layer.DrawEllipse(Pen, rect);
                }
                else
                {
                    Layer.DrawRectangle(Pen, rect);
                }

                output();
            }
            catch(Exception ex)
            {
                msg_Log.save_log(AppName, ex);
            }
        }

        private void picImg_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (Figure == "line")
                    {
                        Layer.DrawLine(Pen, X0, Y0, e.X, e.Y);            //
                        getPoint(e.X, e.Y);                           //抓取當前座標
                        output();
                    }
                }
            }catch(Exception ex)
            {
                msg_Log.save_log(AppName, ex);
            }
        }

        private void output()
        {
            picImg.Image = Painter;
        }


        //變更顏色
        private void btnColor_Click(object sender, EventArgs e)
        {
            try
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    Pen = new Pen(colorDialog1.Color, float.Parse(txtWide.Text));
                    btnColor.BackColor = colorDialog1.Color;
                }
            }catch(Exception ex)
            {
                msg_Log.save_log(AppName, ex);
            }
        }


        

        //使用線條
        private void btnLine_Click(object sender, EventArgs e)
        {
            Figure = "line";
        }

        //使用圓形
        private void btnEllipse_Click(object sender, EventArgs e)
        {
            Figure = "Ellipse";
        }

        //使用方形
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Figure = "Rectangle";
        }

        //筆刷粗度變更
        private void txtWide_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txtWide.Text.Length != 0)
                {
                    Pen = new Pen(colorDialog1.Color, float.Parse(txtWide.Text));
                }
            }
        }


        //抓取座標
        public void getPoint(int x , int y)
        {
            X0 = x;
            Y0 = y;
        }
    }


}
