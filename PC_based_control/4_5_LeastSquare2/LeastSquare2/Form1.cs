using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeastSquare2
{
    public partial class Form1 : Form
    {
        double xmin = -5, xmax = 20;
        double ymin = -5, ymax = 20;

        private float xpixel(double xw)
        {
            return (float)(picDraw.ClientSize.Width * (xw - xmin) / (xmax - xmin));
        }

        private float ypixel(double yw)
        {
            return (float)(picDraw.ClientSize.Height * (1 - (yw - ymin) / (ymax - ymin)));
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            // 데이터 세팅
            const int ndat = 10;
            double[] xw = new double[ndat] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] yw = new double[ndat] { 1.3, 3.5, 4.2, 5.0, 7.0, 8.8, 10.1, 12.5, 13.0, 15.6 };

            // 좌표계그리기
            Graphics grp = picDraw.CreateGraphics();
            //
            //

            // 데이터 점 그리기
            for (int i = 0; i < ndat; i++)
            {
                grp.DrawEllipse(new Pen(Color.Red), xpixel(xw[i]), ypixel(yw[i]), 2, 2);
            }

            // Least-Square 풀이
            double sumXY = 0, sumX = 0, sumY = 0, sumXX = 0;
            //
            //

            double a = //
            double b = //

            // 구해진 직선 그리기
            //
        }
    }
}
