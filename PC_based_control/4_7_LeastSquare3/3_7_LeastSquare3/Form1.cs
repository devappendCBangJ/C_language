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
        // x, y 최소 최대 좌표
        double xmin = -2, xmax = 7;
        double ymin = -5, ymax = 70;

        // 데이터 개수 지정
        const int ndat = 6;

        // Sum 변수 초기화
        double sumX, sumY, sumX2, sumX3, sumX4, sumXY, sumX2Y = 0;
        // Matrix 초기화
        double[,] CramMat = new double[3, 3];

        // 좌표 mapping 변환
        private float xpixel(double xw)
        {
            return (float)(picDraw.ClientSize.Width * (xw - xmin) / (xmax - xmin));
        }

        private float ypixel(double yw)
        {
            return (float)(picDraw.ClientSize.Height * (1-(yw - ymin) / (ymax - ymin)));
        }

        // Sum 변수 세팅
        private void SumSet()
        {
            sumX = 0;
            sumY = 0;
            sumX2 = 0;
            sumX3 = 0;
            sumX4 = 0;
            sumXY = 0;
            sumX2Y = 0;
        }

        // Matrix 세팅
        private void MatSet()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i + j == 0)
                        CramMat[i, j] = ndat;
                    else if (i + j == 1)
                        CramMat[i, j] = sumX;
                    else if (i + j == 2)
                        CramMat[i, j] = sumX2;
                    else if (i + j == 3)
                        CramMat[i, j] = sumX3;
                    else
                        CramMat[i, j] = sumX4;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 데이터 세팅
            //const int ndat = 6;
            double[] xw = new double[ndat] { 1, 2, 3, 4, 5, 6 };
            double[] yw = new double[ndat] { 2.1, 7.7, 13.6, 27.2, 40.9, 61.1 };

            // 좌표계 그리기
            Graphics grp = picDraw.CreateGraphics();
            grp.DrawLine(new Pen(Color.Black), xpixel(xmin), ypixel(0), xpixel(xmax), ypixel(0));
            grp.DrawLine(new Pen(Color.Black), xpixel(0), ypixel(ymin), xpixel(0), ypixel(ymax));

            // 데이터 점 그리기
            for (int i = 0; i < ndat; i++)
            {
                grp.DrawEllipse(new Pen(Color.Red), xpixel(xw[i]), ypixel(yw[i]), 2, 2);
            }

            // Cramer's rule 풀이

            // Sum 변수 세팅 - 1way
            SumSet();

            // Sum 변수 세팅 - 2way
            //double sumx = 0;
            //double sumy = 0;
            //double sumx2 = 0;
            //double sumx3 = 0;
            //double sumx4 = 0;
            //double sumxy = 0;
            //double sumx2y = 0;

            // Sum 변수 세팅2 ♣
            for (int i = 0; i<ndat; i++)
            {
                sumX += xw[i];
                sumY += yw[i];
                sumX2 += xw[i] * xw[i];
                sumX3 += xw[i] * xw[i] * xw[i];
                sumX4 += xw[i] * xw[i] * xw[i] * xw[i];
                sumXY += xw[i] * yw[i];
                sumX2Y += xw[i] * xw[i] * yw[i];
            }

            // Matrix 세팅 - 1way
            MatSet();

            // Matrix 세팅 - 2way
            // double[,] CramMat = new double[3, 3];
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        if (i + j == 0)
            //            CramMat[i, j] = ndat;
            //        else if (i + j == 1)
            //            CramMat[i, j] = sumX;
            //        else if (i + j == 2)
            //            CramMat[i, j] = sumX2;
            //        else if (i + j == 3)
            //            CramMat[i, j] = sumX3;
            //        else
            //            CramMat[i, j] = sumX4;
            //    }
            //}

            // Determinant 연산 ♣
            double[] DMat = new double[4];
            for (int i = 0; i<4; i++) {
                if (0 <= i && i < 3)
                {
                    CramMat[0, i] = sumY;
                    CramMat[1, i] = sumXY;
                    CramMat[2, i] = sumX2Y;
                }

                DMat[i] = CramMat[0, 0] * (CramMat[1, 1] * CramMat[2, 2] - CramMat[2, 1] * CramMat[1, 2])
                    - CramMat[0, 1] * (CramMat[1, 0] * CramMat[2, 2] - CramMat[1, 2] * CramMat[2, 0])
                    + CramMat[0, 2] * (CramMat[1, 0] * CramMat[2, 1] - CramMat[1, 1] * CramMat[2, 0]);

                MatSet();
            }

            // a 연산 ♣
            double[] aMat = new double[3];
            for (int i = 0; i<3; i++)
            {
                aMat[i] = DMat[i] / DMat[3];
            }

            // 구해진 직선 그리기 ♣
            double x = xmin;
            double interv = 100;
            for (int i = 0; i < interv; i++)
            {
                grp.DrawLine(new Pen(Color.Blue), xpixel(x), ypixel(aMat[0] + aMat[1] * x + aMat[2] * x * x), xpixel(x + (xmax - xmin) / interv), ypixel(aMat[0] + aMat[1] * (x + (xmax - xmin) / interv) + aMat[2] * (x + (xmax - xmin) / interv) * (x + (xmax - xmin) / interv)));
                x += (xmax - xmin) / interv;
            }
        }
    }
}
