using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_3_PointDraw
{
    public partial class Form1 : Form
    {
        Color col = Color.Red; // new 사용x ♣♣♣
        int xprev, yprev;
        public Form1()
        {
            InitializeComponent();
        }

        private void PicDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // ♣
            {
                Graphics grp = PicDraw.CreateGraphics(); // ♣♣♣
                // grp.DrawEllipse(new Pen(col), e.X, e.Y, 5, 10);
                grp.DrawLine(new Pen(col), xprev, yprev, e.X, e.Y);

                xprev = e.X;
                yprev = e.Y;
            }
        }

        private void picRed_Click(object sender, EventArgs e)
        {
            col = Color.Red;
        }

        private void picBlue_Click(object sender, EventArgs e)
        {
            col = Color.Blue;
        }

        private void PicDraw_MouseDown(object sender, MouseEventArgs e)
        {
            xprev = e.X;
            yprev = e.Y; // 이게 없으면, 이전에 마우스를 뗀 위치부터 다시 선이 그려져서 이상해진다 ♣♣♣
        }

        private void picGreen_Click(object sender, EventArgs e)
        {
            col = Color.Green;
        }
    }
}
