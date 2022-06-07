using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_5_MonteCarlo_Tri
{
    public partial class Form1 : Form
    {
        // 초기화
        Random rnd = new Random();
        double [] p_x = new double[3];
        double [] p_y = new double[3];
        double tri_area;

        double [] tmp_x_y = new double[2];
        double [] tmp_area = new double[3];

        private void tri_area_func()
        {
            // 삼각형 면적 계산
            tri_area = (double)1.0 / (double)2.0 * ((p_x[0] * p_y[1] + p_x[1] * p_y[2] + p_x[2] * p_y[0]) - (p_x[0] * p_y[2] + p_x[2] * p_y[1] + p_x[1] * p_y[0]));
            tri_area = tri_area >= 0 ? tri_area : -tri_area;
        }

        private bool tri_in_func(double xp, double yp)
        {
            // 삼각형 부호 계산
            for (int i = 0; i < 3; i++)
            {
                tmp_x_y[0] = p_x[i];
                tmp_x_y[1] = p_y[i];
                p_x[i] = xp;
                p_y[i] = yp;

                tmp_area[i] = (double)1.0 / (double)2.0 * ((p_x[0] * p_y[1] + p_x[1] * p_y[2] + p_x[2] * p_y[0]) - (p_x[0] * p_y[2] + p_x[2] * p_y[1] + p_x[1] * p_y[0]));

                Console.WriteLine("{0}, {1}", tmp_area[i], i); // 확인용 코드
                p_x[i] = tmp_x_y[0];
                p_y[i] = tmp_x_y[1];
            }

            // 삼각형 외부, 내부 계산
            if (tmp_area[0] * tmp_area[1] > 0 && tmp_area[0] * tmp_area[2] > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // 좌표 지정
            p_x[0] = 160;
            p_y[0] = 70;
            p_x[1] = 50;
            p_y[1] = 410;
            p_x[2] = 340;
            p_y[2] = 290;

            // Real Ratio
            int wd = picArea.ClientSize.Width;
            int ht = picArea.ClientSize.Height;
            int area = wd * ht;

            // 1way
            //tri_x[0] = 160;
            //tri_y[0] = 70;
            //tri_x[1] = 50;
            //tri_y[1] = 410;
            //tri_x[2] = 340;
            //tri_y[2] = 290;
            //tri_area = (double)1.0 / (double)2.0 * ((tri_x[0] * tri_y[1] + tri_x[1] * tri_y[2] + tri_x[2] * tri_y[0]) - (tri_x[0] * tri_y[2] + tri_x[2] * tri_y[1] + tri_x[1] * tri_y[0]));
            //tri_area = tri_area >= 0 ? tri_area : -tri_area;

            // 2way
            tri_area_func();
            double ratio_real = tri_area / (double)area; // double형으로 형변환 하지 않으면 / 사용시 int 나누기 int가 되서 몫만 추출

            // lblRatioReal.Text = Convert.ToString(ratio_real);
            lblRatioReal.Text = string.Format("{0:0.000000}", ratio_real);

            // Graphics 객체
            Graphics grp = picArea.CreateGraphics();
            grp.Clear(Color.White);

            // Monte Carlo Simulation
            int nPoint = 2000;
            int nIn = 0, nOut = 0;

            // 좌표 난수 발생, 그리기 n번 반복
            for (int i = 0; i < nPoint; i++)
            {
                int xp = rnd.Next(wd);
                int yp = rnd.Next(ht);

                Color col;
                if (tri_in_func(xp, yp))
                {
                    nIn++;
                    col = Color.Black;
                }
                else
                {
                    nOut++;
                    col = Color.Silver;
                }

                grp.DrawEllipse(new Pen(col), xp, yp, 1, 1);

                // 정보 출력
                lblIn.Text = Convert.ToString(nIn);
                lblOut.Text = Convert.ToString(nOut);
                double ratio_monte = (double)nIn / (nIn + nOut);
                lblRatioMonte.Text = string.Format("{0:0.000000}", ratio_monte);
            }
        }
    }
}
