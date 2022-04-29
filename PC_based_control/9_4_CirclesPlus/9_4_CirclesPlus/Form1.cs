using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_4_CirclesPlus
{
    public partial class frmMain : Form
    {
        // canvas, circle list 초기화
        private TCanvas canvas = null;

        private List<Circle> circles = new List<Circle>(); // list 사용하는 것 잘 봐두기 ♣
        private Random rnd = new Random();

        public frmMain()
        {
            InitializeComponent();

            // canvas 생성
            if (canvas == null) canvas = new TCanvas(picDraw, 0, 100, 0, 100);
        }

        private void picDraw_MouseUp(object sender, MouseEventArgs e)
        {
            // 마우스 위치에 원 추가
            if (radAdd.Checked)
            {
                Circle cir = new Circle(canvas.xposD(e.X), canvas.yposD(e.Y));
                circles.Add(cir);
                DrawCircles();
            }

            // 마우스 위치의 원 삭제
            else if (radDel.Checked)
            {
                List<Circle> cdel = new List<Circle>();
                for (int i = 0; i < circles.Count; i++)
                {
                    if (circles[i].isinside(canvas.xposD(e.X), canvas.yposD(e.Y))) cdel.Add(circles[i]);
                }

                for (int i = 0; i < cdel.Count; i++) circles.Remove(cdel[i]); // circles 배열에 있는 특정 원소 삭제
                DrawCircles();
            }
        }

        // 원 움직임 or 포함되는 원 제거
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chkMove.Checked == false) return;

            for (int i = 0; i < circles.Count; i++)
            {
                circles[i].move(0, 100, 0, 100);
            }

            if(chcDelIncluded.Checked == true)
            {
                for(int i = 0; i < circles.Count; i++)
                {
                    for(int j = i+1; j < circles.Count; j++)
                    {
                        double dx = circles[i].xcen - circles[j].xcen;
                        double dy = circles[i].ycen - circles[j].ycen;
                        double dist = Math.Sqrt(dx * dx + dy * dy);
                        if (dist < circles[i].radius - circles[j].radius) circles.Remove(circles[j]);
                        else if (dist < circles[j].radius - circles[i].radius) circles.Remove(circles[i]);
                    }
                }
            }
            DrawCircles();
        }
        private void DrawCircles()
        {
            // 화면 지움
            canvas.ClearDrawing(Color.White);

            // 모든 원 그림
            for (int i = 0; i < circles.Count; i++)
            {
                circles[i].draw(canvas);
            }

            lblNCir.Text = "원의개수 : " + Convert.ToString(circles.Count);
        }

        private void btnAdd100_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                double xc = rnd.Next(100);
                double yc = rnd.Next(100);
                Circle cir = new Circle(xc, yc);
                circles.Add(cir); // circles 배열에 새로운 circle 넣기
            }

            DrawCircles();
        }
        private void btnDelAll_Click(object sender, EventArgs e)
        {
            circles.Clear();
            DrawCircles();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    // circle class
    class Circle
    {
        private static Random rnd = new Random();
        public double xcen, ycen, radius;
        private int red, green, blue;
        private double xmov, ymov;

        // 생성자 - 주어진 위치에 랜덤 크기, 랜덤 색의 원 생성
        public Circle(double xcen, double ycen)
        {
            this.xcen = xcen;
            this.ycen = ycen;
            this.radius = rnd.Next(10) + 2;
            this.red = rnd.Next(200);
            this.green = rnd.Next(200);
            this.blue = rnd.Next(200);  // 너무밝지않게
            while (true) { this.xmov = rnd.Next(-3, 3); if (xmov != 0) break; }
            while (true) { this.ymov = rnd.Next(-3, 3); if (ymov != 0) break; }
        }

        // 움직임
        public void move(double xmin, double xmax, double ymin, double ymax)
        {
            if (xcen <= xmin + radius) xmov = Math.Abs(xmov); // 무조건 오른쪽으로 보냄
            if (xcen >= xmax - radius) xmov = -Math.Abs(xmov); // 무조건 왼쪽으로 보냄

            if (ycen <= ymin + radius) ymov = Math.Abs(ymov); // 무조건 아래로 보냄
            if (ycen >= ymax - radius) ymov = -Math.Abs(ymov); // 무조건 위로 보냄

            xcen += xmov;
            ycen += ymov;
        }

        // 그리기
        public void draw(TCanvas canvas)
        {
            canvas.DrawEllipse(Color.FromArgb(this.red, this.green, this.blue),
            this.xcen, this.ycen, this.radius * 2, this.radius * 2);
        }

        // 주어진 점이 내부인지 판단
        public bool isinside(double xp, double yp)
        {
            double dx = xp - this.xcen;
            double dy = yp - this.ycen;
            double dist = Math.Sqrt(dx * dx + dy * dy);
            return (dist <= this.radius) ? true : false;
        }
    }
}
