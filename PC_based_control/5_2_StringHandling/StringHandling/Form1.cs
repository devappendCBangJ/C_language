using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 현재 시간 출력
            DateTime t = DateTime.Now;
            lblTime.Text = t.ToString();
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            // 문자열 길이 출력
            string st = txtIN1.Text;
            int len = st.Trim().Length;
            txtOUT.Text = Convert.ToString(len);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            // 문자열 왼쪽 n개 출력
            string st = txtIN1.Text;
            int n = Convert.ToInt32(txtIN2.Text);
            txtOUT.Text = st.Substring(0, n);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            // 문자열 오른쪽 n개 출력
            string st = txtIN1.Text;
            int n = Convert.ToInt32(txtIN2.Text);
            txtOUT.Text = st.Substring(st.Length - n, n); // ♣♣♣
        }

        private void btnMid_Click(object sender, EventArgs e)
        {
            // 문자열 2~4번째 출력
            string st = txtIN1.Text;
            txtOUT.Text = st.Substring(1, 3); // ♣
        }

        private void btnUpper_Click(object sender, EventArgs e)
        {
            // 대문자 출력
            string st = txtIN1.Text;
            txtOUT.Text = st.ToUpper();
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            // 소문자 출력
            string st = txtIN1.Text;
            txtOUT.Text = st.ToLower();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            // 문자열 비교
            string st1 = txtIN1.Text;
            string st2 = txtIN2.Text;

            // 문자열 비교 - 1way
            //if (st1 == st2)
            //{
            //    txtOUT.Text = "같음";
            //}
            //else
            //    txtOUT.Text = "다름";

            // 문자열 비교 - 2way
            // txtOUT.Text = st1 == st2 ? "같음" : "다름";

                // string은 참조형 변수이므로, st1 == st2는 heap의 주소를 비교한것인데 C#에서 내용을 비교한 것처럼 인식함
                // 이렇게 하는 것을 권장하지 않음

            // 문자열 비교 - 3way
            txtOUT.Text = st1.CompareTo(st2) == 0 ? "같음" : "다름"; // ♣♣♣
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            // st1 문자열에서 st2 문자에 해당되는 인덱스 출력
            string st1 = txtIN1.Text;
            string st2 = txtIN2.Text;
            int idx = st1.IndexOf(st2); // ♣
            txtOUT.Text = Convert.ToString(idx);
        }

        private void btnPadLeft_Click(object sender, EventArgs e)
        {
            // 총 문자 개수가 n개 되도록 문자열 왼쪽에 공백 삽입
            string st = txtIN1.Text;
            int n = Convert.ToInt32(txtIN2.Text);
            txtOUT.Text = st.PadLeft(n); // ♣
        }

        private void btnPadRight_Click(object sender, EventArgs e)
        {
            // 총 문자 개수가 n개 되도록 문자열 오른쪽에 공백 삽입
            string st = txtIN1.Text;
            int n = Convert.ToInt32(txtIN2.Text);
            txtOUT.Text = st.PadRight(n); // ♣
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            // 문자열 슬라이싱
            char [] delim = new char[] { '-', ' ', ':' };
            string st = lblTime.Text;
            string [] word = st.Split(delim);

            txtOUT.Text = word[4] + "시 입니다."; // ♣♣♣
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            // 문자열 대체
            string st = lblTime.Text;
            txtOUT.Text = st.Replace(' ', '/'); // ♣♣♣
        }
    }
}
