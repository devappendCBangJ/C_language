using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_1_DayOfWeek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 입력 읽기
            int year = Convert.ToInt32(txtYear.Text);
            int month = Convert.ToInt32(txtMonth.Text);
            int day = Convert.ToInt32(txtDay.Text);

            // 예외 입력 읽기
            if (month == 1 || month == 2)
            {
                month = month + 12;
                year--;
            }

            // 요일 계산
            int idx = year + (year / 4) - (year / 100) + (year / 400) + (int)(2.6 * month + 1.6) + day; // int 변환 or / : 가우스 기호 구현
            int remainder = idx % 7;

            // 요일 출력 1way
            // if (remainder == 0) lblout.text = "월요일입니다";
            // else if (remainder == 1) lblout.text = "화요일입니다";
            // else  if (remainder == 2) lblout.text = "수요일입니다";
            // else if (remainder == 3) lblout.text = "목요일입니다";
            // else if (remainder == 4) lblout.text = "금요일입니다";
            // else if (remainder == 5) lblout.text = "토요일입니다";
            // else if (remainder == 6) lblout.text = "일요일입니다";

            // 요일 출력 2way
            string[] sday = new string[] { "일", "월", "화", "수", "목", "금", "토" };
            lblOut.Text = sday[remainder] + "요일 입니다";
        }

        private void btnLeapYear_Click(object sender, EventArgs e)
        {
            // 입력 읽기
            int year = Convert.ToInt32(txtYear.Text);

            // 윤년 계산
            bool isLeapYear = ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);

            // 윤년 출력 1way
            // if (isLeapYear)
            // {
            //    lblOut.Text = "윤년입니다.";
            // }
            // else
            // {
            //    lblOut.Text = "윤년이 아닙니다.";
            // }

            // 윤년 출력 2way
            lblOut.Text = isLeapYear ? "윤년입니다." : "윤년이 아닙니다."; // ♣
        }
    }
}
