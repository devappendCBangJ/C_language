using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_3_Korea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            // 파일 열기 팝업
            DialogResult rtn = openFileDialog.ShowDialog();
            if (rtn != DialogResult.OK) return;

            // 파일명 출력
            string fname = openFileDialog.FileName;
            label1.Text = fname;

            // 파일 읽기
            int npoint; // try문 안에 선언되면 try문 벗어나면 변수의 수명이 끝나기 때문
            float[] xp;
            float[] yp;
            try
            {
                StreamReader sr = new StreamReader(fname, Encoding.Default);
                string st = sr.ReadLine();
                npoint = Convert.ToInt32(st.Trim());
                xp = new float[npoint];
                yp = new float[npoint];
                for (int i = 0; i < npoint; i++)
                {
                    st = sr.ReadLine();
                    string[] word = st.Split(',');
                    xp[i] = Convert.ToSingle(word[0].Trim());
                    yp[i] = Convert.ToSingle(word[1].Trim());
                }
                sr.Close();
            }
            catch
            {
                MessageBox.Show("파일을 읽을 수 없습니다.", "오류");
                return;
            }

            // 그리기
            Graphics grp = picDraw.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            for (int i = 1; i < npoint; i++)
            {
                grp.DrawLine(pen, xp[i-1], yp[i-1], xp[i], yp[i]);
            }
        }
    }
}
