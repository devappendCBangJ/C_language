using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_2_AnalogClock
{
    public partial class Form1 : Form
    {
        private TCanvas canvas; // ♣

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int hour = now.Hour; // ♣♣♣
            int minute = now.Minute; // ♣♣♣
            int second = now.Second; // ♣♣♣

            lblTime.Text = hour.ToString() + ":" + minute.ToString() + ":" + second.ToString(); // ♣

            DrawClock(hour, minute, second);
        }

        private void DrawClock(int hour, int minute, int second)
        {
            if (canvas == null) canvas = new TCanvas(picClock, -100, 100, -100, 100); // ♣

            // 화면지우기
            canvas.ClearDrawing(Color.White); // ♣

            // 눈금그리기
            double deg, rad;
            double xp1, yp1, xp2, yp2;
            for (int i = 0; i < 60; i++)
            {
                deg = 90.0 - 360 / 60 * i; // ♣♣♣
                rad = deg * Math.PI / 180; // ♣

                xp1 = ((i % 5 == 0) ? 85 : 90) * Math.Cos(rad);
                yp1 = ((i % 5 == 0) ? 85 : 90) * Math.Sin(rad);
                xp2 = 95 * Math.Cos(rad);
                yp2 = 95 * Math.Sin(rad);
                canvas.DrawLine(Color.Blue, xp1, yp1, xp2, yp2);
            }

            // 시침그리기
            deg = 90.0 - 360.0 / (12 * 60 * 60) * (hour * 60 * 60 + minute * 60 + second);
            //           > 1초당 회전각도         > 0시 이후 경과된 초
            rad = deg * Math.PI / 180;
            xp2 = 50 * Math.Cos(rad);
            yp2 = 50 * Math.Sin(rad);
            canvas.DrawLine(Color.Black, 5, 0, 0, xp2, yp2);

            // 분침그리기
            deg = 90.0 - 360.0 / (60 * 60) * (minute * 60 + second);
            rad = deg * Math.PI / 180;
            xp2 = 80 * Math.Cos(rad);
            yp2 = 80 * Math.Sin(rad);
            canvas.DrawLine(Color.Silver, 3, 0, 0, xp2, yp2);

            // 초침그리기
            deg = 90.0 - 360.0 / (60) * (second);
            rad = deg * Math.PI / 180;
            xp2 = 83 * Math.Cos(rad);
            yp2 = 83 * Math.Sin(rad);
            canvas.DrawLine(Color.Gold, 2, 0, 0, xp2, yp2);
        }
    }
}
