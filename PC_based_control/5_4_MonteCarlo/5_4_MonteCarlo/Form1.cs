using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_4_MonteCarlo
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Real Ratio
            int wd = picArea.ClientSize.Width;
            int ht = picArea.ClientSize.Height;
            int area = wd * ht;
            double ratio_real = 100.0 * 100.0 / (double)area; // double형으로 형변환 하지 않으면 / 사용시 int 나누기 int가 되서 몫만 추출 ♣

            // lblRatioReal.Text = Convert.ToString(ratio_real);
            lblRatioReal.Text = string.Format("{0:0.000000}", ratio_real); // ♣

            // Graphics 객체
            Graphics grp = picArea.CreateGraphics();
            grp.Clear(Color.White); // ♣

            // Monte Carlo Simulation
            int nPoint = 2000;
            int nIn = 0, nOut = 0;

            // 좌표 난수 발생, 그리기 n번 반복
            for (int i = 0; i < nPoint; i++)
            {
                int xp = rnd.Next(wd);
                int yp = rnd.Next(ht);

                bool isIn = xp >= 100 && xp < 200 && yp >= 100 && yp < 200; // 요렇게 해도 되네? ♣
                Color col;
                if (isIn)
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
