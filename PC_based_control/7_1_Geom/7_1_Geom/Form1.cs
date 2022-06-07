using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_1_Geom
{
    public partial class Form1 : Form   // 분할 Class. 다른 파일에도 Form1에 대한 정의가 있다는 뜻
    {
        List<Geom> geoms = new List<Geom>();    // 컨테이너 클래스 List !! (.NET 제공 동적 리스트). ()를 붙여서 생성자로 만듦 ♣♣♣
        Random rnd = new Random();

        //=======================================
        // 화면 지우고 다시 그리기
        //=======================================
        private void RedrawAll()
        {
            Graphics grp = picDraw.CreateGraphics();
            grp.Clear(Color.White);
            for (int i = 0; i < geoms.Count; i++) // ♣♣♣
            {
                geoms[i].Draw(picDraw); // 다형적 호출 ♣♣♣
            }

            lblNCir.Text = Circle.num.ToString(); // static 멤버의 access ♣♣♣
            lblNDia.Text = Diamond.num.ToString();
            lblNTotal.Text = geoms.Count.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw3_Click(object sender, EventArgs e)
        {
            Geom geom; // ♣♣♣
            Color col;

            col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200)); // ♣♣♣
            geom = new Circle(150, 220, 10, col); // ♣
            geoms.Add(geom); // ♣♣♣

            col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
            geom = new Diamond(200, 300, 20, 20, col); // ♣
            geoms.Add(geom);

            col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
            geom = new Diamond(250, 130, 20, 20, col);
            geoms.Add(geom);

            RedrawAll();
        }

        private void btnDraw100_Click(object sender, EventArgs e)
        {
            Color col;
            int ngeom = 100;
            for (int i = 0; i < ngeom; i++)
            {
                if (rnd.Next(2) == 0)
                {
                    col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
                    Geom cir = new Circle(rnd.Next(500), rnd.Next(500), rnd.Next(30), col); // ♣♣♣
                    geoms.Add(cir); // ♣
                }
                else
                {
                    col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
                    Geom dia = new Diamond(rnd.Next(500), rnd.Next(500), rnd.Next(30), rnd.Next(30), col); // ♣♣♣
                    geoms.Add(dia); // ♣
                }
            }

            RedrawAll();
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            geoms.Clear(); // ♣♣♣
            Circle.num = 0;
            Diamond.num = 0;

            RedrawAll();
        }
    }
}
