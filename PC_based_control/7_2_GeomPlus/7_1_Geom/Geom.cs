using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace _7_1_Geom
{
    class Geom
    {
        public virtual void Draw(PictureBox pic) { }    // 오버라이딩 ♣♣♣♣♣
        public Color col;
    }

    class Circle : Geom
    {
        private int xcen, ycen, radius;
        public static int num;  // static : class 자체의 특성 ♣♣♣♣♣

        public Circle(int xcen, int ycen, int radius, Color col)    // 생성자 : new 할때 실행 ♣♣♣♣♣
        {
            this.col = col;     // 상속된 속성 ♣♣♣♣♣
            this.xcen = xcen;   // 확장된 속성 ♣♣♣♣♣
            this.ycen = ycen;
            this.radius = radius;
            num++;              // static 멤버
        }

        public override void Draw(PictureBox pic)   // 오버라이딩
        {
            Graphics grp = pic.CreateGraphics();
            grp.DrawEllipse(new Pen(col), xcen, ycen, radius * 2, radius * 2);
        }
    }

    class Diamond : Geom
    {
        private int xcen, ycen, xsize, ysize;
        public static int num;

        public Diamond(int x, int y, int xs, int ys, Color col)
        {
            this.col = col;
            this.xcen = x;
            this.ycen = y;
            this.xsize = xs;
            this.ysize = ys;
            num++;
        }

        public override void Draw(PictureBox pic)
        {
            Graphics grp = pic.CreateGraphics();
            grp.DrawLine(new Pen(col), xcen + xsize / 2, ycen, xcen, ycen + ysize / 2);
            grp.DrawLine(new Pen(col), xcen, ycen + ysize / 2, xcen - xsize / 2, ycen);
            grp.DrawLine(new Pen(col), xcen - xsize / 2, ycen, xcen, ycen - ysize / 2);
            grp.DrawLine(new Pen(col), xcen, ycen - ysize / 2, xcen + xsize / 2, ycen);
        }
    }

    class Rectangle : Geom
    {
        private int xsmall, ysmall, xsize, ysize;
        public static int num;

        public Rectangle(int x, int y, int xs, int ys, Color col)
        {
            this.col = col;
            this.xsmall = x;
            this.ysmall = y;
            this.xsize = xs;
            this.ysize = ys;
            num++;
        }

        public override void Draw(PictureBox pic)
        {
            Graphics grp = pic.CreateGraphics();
            grp.DrawLine(new Pen(col), xsmall, ysmall, xsmall+xsize, ysmall);
            grp.DrawLine(new Pen(col), xsmall + xsize, ysmall, xsmall + xsize, ysmall + ysize);
            grp.DrawLine(new Pen(col), xsmall + xsize, ysmall + ysize, xsmall, ysmall + ysize);
            grp.DrawLine(new Pen(col), xsmall, ysmall + ysize, xsmall, ysmall);
        }
    }

    class Triangle : Geom
    {
        private int xsmall, ysmall, height, width;
        public static int num;

        public Triangle(int xsmall, int ysmall, int height1, int width1, Color col)
        {
            this.col = col;
            this.xsmall = xsmall;
            this.ysmall = ysmall;
            this.height = height1;
            this.width = width1;
            num++;
        }

        public override void Draw(PictureBox pic)
        {
            Graphics grp = pic.CreateGraphics();
            grp.DrawLine(new Pen(col), xsmall, ysmall, xsmall + width, ysmall);
            grp.DrawLine(new Pen(col), xsmall + width, ysmall, xsmall + width, ysmall + height);
            grp.DrawLine(new Pen(col), xsmall + width, ysmall + height, xsmall, ysmall);
        }
    }
}

