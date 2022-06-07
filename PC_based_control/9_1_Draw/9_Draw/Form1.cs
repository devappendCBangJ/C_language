using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_Draw
{
    public partial class Form1 : Form
    {
        //private double xcen, ycen;       // Form 클래스에 멤버 변수로 선언

        private double xcen, ycen;  // Form 클래스에 멤버 변수로 선언
        private Bitmap bitmap;      // Form 클래스에 멤버 변수로 선언 ♣♣♣

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e) // 픽처박스가 다시 불려질 필요가 있을 때 호출되는 함수(창 resize 등등)
        {
            Pen pen = new Pen(Color.Blue, 5); // ♣♣♣
            Brush brush = Brushes.Red; // ♣♣♣
            e.Graphics.DrawEllipse(pen, 10, 10, 100, 100); // ♣♣♣
            e.Graphics.DrawRectangle(pen, 120, 10, 100, 100);
            e.Graphics.FillEllipse(brush, 10, 120, 100, 100);
            e.Graphics.FillRectangle(brush, 120, 120, 100, 100);

            Font F1 = new Font("궁서", 20); // ♣♣♣
            e.Graphics.DrawString("대한민국", F1, Brushes.Black, 10, 10); // ♣♣♣

            Font F2 = new Font("궁서", 20, FontStyle.Italic | FontStyle.Underline); // ♣♣♣
            e.Graphics.DrawString("대한민국", F2, Brushes.Black, 10, 40);

            FontFamily Fm = new FontFamily("궁서");
            Font F3 = new Font(Fm, 20);
            e.Graphics.DrawString("대한민국", F3, Brushes.Black, 10, 70);

            e.Graphics.DrawEllipse(new Pen(Color.Blue), (int)xcen, (int)ycen, 20, 20);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //xcen += 1; ycen += 2;
            //this.pictureBox1.Invalidate();  // pictureBox1 그림을 무효화. 이후 감시 루프가 이를 확인하고, Paint이벤트를 호출시킴(direct 호출 아님)

            if (bitmap == null) // 비트맵 생성 ♣
                bitmap = new Bitmap(picDraw.ClientSize.Width, picDraw.ClientSize.Height);
            Graphics grp = Graphics.FromImage(bitmap); // 비트맵에 도화지 생성(비트맵 = 내부 메모리 공간) ♣♣♣

            xcen += 1; ycen += 2;

            grp.Clear(picDraw.BackColor); // 화면 지우기
            grp.DrawEllipse(new Pen(Color.Blue), (int)xcen, (int)ycen, 20, 20);

            picDraw.Image = bitmap;    // 메모리 덩어리를 한번에 Image 속성에 할당 ♣
        }
    }
}
