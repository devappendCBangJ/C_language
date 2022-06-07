using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadFile_Click(object sender, EventArgs e)      // Org에 그림 파일 불러오기
        {
            DialogResult res = openFileDialog1.ShowDialog();    // openFileDialog1.ShowDialog() ♣♣♣
            if (res == DialogResult.OK)
            {
                string fname = openFileDialog1.FileName;
                picOrg.Load(fname); // 하드디스크에 있는 파일 읽은 후, 넣음 ♣♣♣
            }
        }

        private void picOrg_MouseMove(object sender, MouseEventArgs e)  // Org 마우스 위치의 그림 색 정보 추출
        {
            Bitmap bitmap = (Bitmap)picOrg.Image; // ♣♣♣
            Color col = bitmap.GetPixel(e.X, e.Y);
            picColor.BackColor = col;
            lblRed.Text = "Red : " + Convert.ToString(col.R); // ♣♣♣
            lblGreen.Text = "Green : " + Convert.ToString(col.G);
            lblBlue.Text = "Blue : " + Convert.ToString(col.B);
        }

        private void btnCopy_Click(object sender, EventArgs e)          // Org -> Trg 그림 파일 픽셀 복사 + 붙여넣기
        {
            Bitmap bmapOrg = (Bitmap)picOrg.Image; // picOrg.Image as Bitmap 과 같다
            Bitmap bmapTrg = new Bitmap(bmapOrg.Width, bmapOrg.Height); // ♣♣♣

            Color col;
            int red, green, blue;
            for (int i = 0; i < bmapOrg.Width; i++)
            {
                for (int j = 0; j < bmapOrg.Height; j++)
                {
                    col = bmapOrg.GetPixel(i, j);
                    red = col.R;
                    green = col.G;
                    blue = col.B;
                    bmapTrg.SetPixel(i, j, Color.FromArgb(red, green, blue)); // ♣♣♣
                }
            }
            picTrg.Image = bmapTrg;
        }

        private void btnClear_Click(object sender, EventArgs e)         // Trg 그림 clear
        {
            picTrg.Image = null;
        }

        private void btnReverse_Click(object sender, EventArgs e)       // Org -> Trg 그림 색 반전
        {
            Bitmap bmapOrg = (Bitmap)picOrg.Image;
            Bitmap bmapTrg = new Bitmap(bmapOrg.Width, bmapOrg.Height);

            Color col;
            int red, green, blue;
            for (int i = 0; i < bmapOrg.Width; i++)
            {
                for (int j = 0; j < bmapOrg.Height; j++)
                {
                    col = bmapOrg.GetPixel(i, j);
                    red = 255- col.R;
                    green = 255 - col.G;
                    blue = 255 - col.B;
                    bmapTrg.SetPixel(i, j, Color.FromArgb(red, green, blue));
                }
            }
            picTrg.Image = bmapTrg;
        }

        private void btnMirrorLR_Click(object sender, EventArgs e)      // Org -> Trg 그림 좌우 반전
        {
            Bitmap bmapOrg = (Bitmap)picOrg.Image;
            Bitmap bmapTrg = new Bitmap(bmapOrg.Width, bmapOrg.Height);

            Color col;
            int red, green, blue;
            for (int i = 0; i < bmapOrg.Width; i++)
            {
                for (int j = 0; j < bmapOrg.Height; j++)
                {
                    col = bmapOrg.GetPixel(i, j);
                    red = col.R;
                    green = col.G;
                    blue = col.B;
                    bmapTrg.SetPixel(bmapOrg.Width - i - 1, j, Color.FromArgb(red, green, blue));
                }
            }
            picTrg.Image = bmapTrg;
        }

        private void btnMirrorUD_Click(object sender, EventArgs e)      // Org -> Trg 그림 상하 반전
        {
            Bitmap bmapOrg = (Bitmap)picOrg.Image;
            Bitmap bmapTrg = new Bitmap(bmapOrg.Width, bmapOrg.Height);

            Color col;
            int red, green, blue;
            for (int i = 0; i < bmapOrg.Width; i++)
            {
                for (int j = 0; j < bmapOrg.Height; j++)
                {
                    col = bmapOrg.GetPixel(i, j);
                    red = col.R;
                    green = col.G;
                    blue = col.B;
                    bmapTrg.SetPixel(i, bmapOrg.Height - j - 1, Color.FromArgb(red, green, blue));
                }
            }
            picTrg.Image = bmapTrg;
        }

        private void btnGray_Click(object sender, EventArgs e)          // Org -> Trg 그림 GrayScale 변환(red, green, blue를 모두 같은 색으로)
        {
            Bitmap bmapOrg = (Bitmap)picOrg.Image;
            Bitmap bmapTrg = new Bitmap(bmapOrg.Width, bmapOrg.Height);

            Color col;
            int red, green, blue;
            for (int i = 0; i < bmapOrg.Width; i++)
            {
                for (int j = 0; j < bmapOrg.Height; j++)
                {
                    col = bmapOrg.GetPixel(i, j);
                    red = col.R;
                    green = col.G;
                    blue = col.B;
                    int avr = (int)(0.299 * red + 0.587 * green + 0.114 * blue);  // 1way : NTSC 방법
                    avr = (red + green + blue) / 3;     // 2way : 쉬운 방법
                    bmapTrg.SetPixel(i, j, Color.FromArgb(avr, avr, avr));
                }
            }
            picTrg.Image = bmapTrg;
        }

        private void btnBin_Click(object sender, EventArgs e)           // Trg -> Bin 그림 ScrollBar에 따른 이진화
        {
            if (picTrg.Image == null) return;

            int threshold = hScrollBar1.Value;

            Bitmap bmapTrg = (Bitmap)picTrg.Image;
            Bitmap bmapBin = new Bitmap(bmapTrg.Width, bmapTrg.Height);

            Color col;
            int red, green, blue;
            for (int i = 0; i < bmapTrg.Width; i++)
            {
                for (int j = 0; j < bmapTrg.Height; j++)
                {
                    col = bmapTrg.GetPixel(i, j);
                    red = col.R;
                    green = col.G;
                    blue = col.B;
                    int avr = (red + green + blue) / 3;

                    if (avr >= threshold)
                        col = Color.White; // 큰 값이 흰색 ♣♣♣
                    else
                        col = Color.Black; // 작은 값이 검은색 ♣♣♣
                    col = (avr >= threshold) ? Color.White : Color.Black;
                    bmapBin.SetPixel(i, j, col);
                }
            }
            picBin.Image = bmapBin;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)   // ScrollBar값 label에 출력 + btnBin 자동 실행 ♣
        {
            lblScroll.Text = Convert.ToString(hScrollBar1.Value);
            btnBin.PerformClick(); // ♣
        }

        private void btnSave_Click(object sender, EventArgs e)              // Bin 그림 저장
        {
            if (picBin.Image != null)
            {
                DialogResult res = saveFileDialog1.ShowDialog();    // saveFileDialog1.ShowDialog() ♣♣♣
                if (res == DialogResult.OK)
                {
                    picBin.Image.Save(saveFileDialog1.FileName);    // 파일 저장 ♣♣♣
                }
            }
        }
    }

}
