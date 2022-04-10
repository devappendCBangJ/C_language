using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_2_TotalSec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTotalSec_Click(object sender, EventArgs e)
        {
            // 입력
            int hour = Convert.ToInt32(txtHour.Text);
            int minute = Convert.ToInt32(txtMin.Text);
            int second = Convert.ToInt32(txtSec.Text);

            // 계산
            int TotalSec = hour * 3600 + minute * 60 + second;

            // 출력
            txtTotalSec.Text = Convert.ToString(TotalSec);
        }

        private void btnHMS_Click(object sender, EventArgs e)
        {
            // 입력
            int TotalSec = Convert.ToInt32(txtTotalSec.Text);

            // 계산
            int hour = TotalSec / 3600;
            int minute = (TotalSec % 3600) / 60;
            int second = (TotalSec % 3600) % 60;

            // 출력
            txtHour.Text = Convert.ToString(hour);
            txtMin.Text = Convert.ToString(minute);
            txtSec.Text = Convert.ToString(second);
        }
    }
}
