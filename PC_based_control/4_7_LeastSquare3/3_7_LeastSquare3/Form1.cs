using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_7_LeastSquare3
{
    public partial class Form1 : Form
    {
        double xmin = -2, xmax = 7;
        double ymin = -5, ymax = 70;

        private float xpixel(double xw)
        {
            return (float)(picDraw.ClientSize.Width * (xw - xmin) / (xmax - xmin));
        }

        private float ypixel(double yw)
        {
            return (float)(picDraw.ClientSize.Height * (1-(yw - ymin)) / (ymax - ymin));
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 데이터 세팅
            const int ndat = 6;
            double[] xw = new double[ndat] = { 1, 2, 3, 4, 5, 6};
            double[] yw = new double[ndat] = { 2.1, 7.7, 13.6, 27.2, 40.9, 61.1};

            // 좌표계 그리기
            Graphics grp = picDraw.CreateGraphics();
            grp.DrawLine(new Pen(Color.Black), xpixel(xmin), ypixel(0), xpixel(xmax), ypixel(0));
            grp.DrawLine(new Pen(Color.Black), xpixel(0), ypixel(ymin), xpixel(0), ypixel(ymax));

            // 데이터 점 그리기
            for (int i = 0; i < ndat; i++)
            {
                grp.DrawEllipse(new Pen(Color.Red), xpixel(xw[i]), ypixel(yw[i]), 2, 2);
            }
        }
    }
}
