using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_6_LeastSquare2
{
    public partial class Form : System.Windows.Forms.Form
    {
        // x, y 최소 최대 좌표
        double xmin = -5, xmax = 20;
        double ymin = -5, ymax = 20;

        // 좌표 mapping 변환
        private float xpixel(double xw)
        {
            return (float)(picDraw.ClientSize.Width * (xw-xmin) / (xmax - xmin));
        }
        private float ypixel(double yw)
        {
            return (float)(picDraw.ClientSize.Height * (1 - (yw - ymin) / (ymax - ymin))); // ♣♣
        }
        public Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 데이터 세팅
            const int ndat = 10;
            double[] xw = new double[ndat] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] yw = new double[ndat] { 1.3, 3.5, 4.2, 5.0, 7.0, 8.8, 10.1, 12.5, 13.0, 15.6};

            // 좌표계 그리기
            Graphics grp = picDraw.CreateGraphics();
            grp.DrawLine(new Pen(Color.Black), xpixel(xmin), ypixel(0), xpixel(xmax), ypixel(0));
            grp.DrawLine(new Pen(Color.Black), xpixel(0), ypixel(ymin), xpixel(0), ypixel(ymax));

            // 데이터 점 그리기
            for (int i = 0; i < ndat; i++)
            {
                grp.DrawEllipse(new Pen(Color.Red), xpixel(xw[i]), ypixel(yw[i]), 5, 5);
            }

            // Least-Square 풀이 ♣
            double sumXY = 0, sumX = 0, sumY = 0, sumXX = 0;
            for (int i = 0; i < ndat; i++)
            {
                sumXY += xw[i] * yw[i];
                sumX += xw[i];
                sumY += yw[i];
                sumXX += xw[i] * xw[i];
            }

            double a = (ndat * sumXY - sumX * sumY) / (ndat * sumXX - sumX * sumX);
            double b = (sumY - a * sumX) / ndat;

            // 구해진 직선 그리기
            grp.DrawLine(new Pen(Color.Blue), xpixel(xmin), ypixel(a * xmin + b), xpixel(xmax), ypixel(a * xmax + b));
        }
    }
}
