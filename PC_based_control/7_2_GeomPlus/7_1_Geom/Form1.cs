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
        List<Geom> geoms = new List<Geom>();    // 컨테이너 클래스 List !! (.NET 제공 동적 리스트). ()를 붙여서 생성자로 만듦 ♣♣♣♣♣
        Random rnd = new Random();

        //=======================================
        // 화면 지우고 다시 그리기
        //=======================================
        private void RedrawAll()
        {
            // 화면 초기화
            Graphics grp = picDraw.CreateGraphics();
            grp.Clear(Color.White);

            // geoms 배열 개수에 맞게 도형 그리기
            for (int i = 0; i < geoms.Count; i++)   // geoms의 개수
            {
                geoms[i].Draw(picDraw);  // 다형적 호출
            }

            // 라벨에 도형 정보 표시
            this.lblNCir.Text = Circle.num.ToString();  // static 멤버의 access
            this.lblNDia.Text = Diamond.num.ToString();
            this.lblNRec.Text = Rectangle.num.ToString();
            this.lblNTri.Text = Triangle.num.ToString();
            this.lblNTotal.Text = geoms.Count.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw3_Click(object sender, EventArgs e)
        {
            Geom geom;
            Color col;
            
            // 도형 위치, 종류 결정
            col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
            geom = new Circle(150, 220, 10, col);
            geoms.Add(geom); // 배열에 추가

            col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
            geom = new Diamond(200, 300, 20, 20, col);
            geoms.Add(geom);

            col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
            geom = new Rectangle(100, 100, 200, 200, col);
            geoms.Add(geom);

            col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
            geom = new Triangle(100, 100, 30, 30, col);
            geoms.Add(geom);

            // 도형 그리기
            RedrawAll();
        }

        private void btnDraw100_Click(object sender, EventArgs e)
        {
            Color col;
            int ngeom = 100;
            // n개 도형 생성
            for (int i = 0; i < ngeom; i++)
            {
                // 랜덤으로 도형 위치, 종류 결정
                int rndFig = rnd.Next(4); // ♣
                if (rndFig == 0)
                {
                    col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
                    Circle cir = new Circle(rnd.Next(500), rnd.Next(500), rnd.Next(30), col);
                    geoms.Add(cir);
                }
                else if(rndFig == 1)
                {
                    col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
                    Diamond dia = new Diamond(rnd.Next(500), rnd.Next(500), rnd.Next(30), rnd.Next(30), col);
                    geoms.Add(dia);
                }
                else if (rndFig == 2)
                {
                    col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
                    Rectangle rec = new Rectangle(rnd.Next(500), rnd.Next(500), rnd.Next(30), rnd.Next(30), col);
                    geoms.Add(rec);
                }
                else if (rndFig == 3)
                {
                    col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
                    Triangle tri = new Triangle(rnd.Next(500), rnd.Next(500), rnd.Next(30), rnd.Next(30), col);
                    geoms.Add(tri);
                }
            }

            // 도형 그리기
            RedrawAll();
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            // 배열 초기화, 도형 정보 초기화
            geoms.Clear();  // 배열 깨끗하게 만들자 ♣♣♣
            Circle.num = 0;
            Diamond.num = 0;
            Rectangle.num = 0;
            Triangle.num = 0;

            // 도형 그리기
            RedrawAll();
        }
    }
}
