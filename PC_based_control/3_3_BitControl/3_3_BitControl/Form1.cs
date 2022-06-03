using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_3_BitControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetCheckBox(int num)
        {
            chk0.Checked = (num & 0x01 << 0) != 0; // mask 씌움 ♣
            chk1.Checked = (num & 0x01 << 1) != 0;
            chk2.Checked = (num & 0x01 << 2) != 0;
            chk3.Checked = (num & 0x01 << 3) != 0;
            chk4.Checked = (num & 0x01 << 4) != 0;
            chk5.Checked = (num & 0x01 << 5) != 0;
            chk6.Checked = (num & 0x01 << 6) != 0;
            chk7.Checked = (num & 0x01 << 7) != 0;
        }

        private int GetCheckBox()
        {
            int num = 0;

            if (chk0.Checked) num = num | 0x01; // mask 씌움 ♣
            if (chk1.Checked) num = num | 0x02;
            if (chk2.Checked) num = num | 0x04;
            if (chk3.Checked) num = num | 0x08;
            if (chk4.Checked) num = num | 0x10;
            if (chk5.Checked) num = num | 0x20;
            if (chk6.Checked) num = num | 0x40;
            if (chk7.Checked) num = num | 0x80;

            return num;
        }

        private int ShiftUpCheckBox(int num)
        {
            num = num & ~(0x80);
            if (chk6.Checked)
            {
                num = num | 0x80; // 2^7만 true로 ♣
                num = num & ~(0x40); // 2^6만 false로 ♣
            }
            if (chk5.Checked)
            {
                num = num | 0x40;
                num = num & ~(0x20);
            }
            if (chk4.Checked)
            {
                num = num | 0x20;
                num = num & ~(0x10);
            }
            if (chk3.Checked)
            {
                num = num | 0x10;
                num = num & ~(0x08);
            }
            if (chk2.Checked)
            {
                num = num | 0x08;
                num = num & ~(0x04);
            }
            if (chk1.Checked)
            {
                num = num | 0x04;
                num = num & ~(0x02);
            }
            if (chk0.Checked)
            {
                num = num | 0x02;
                num = num & ~(0x01);
            }

            return num;
        }

        private int ShiftDownCheckBox(int num)
        {
            num = num & ~(0x01);
            if (chk1.Checked)
            {
                num = num | 0x01; // 2^0만 true로 ♣
                num = num & ~(0x02); // 2^1만 false로 ♣
            }
            if (chk2.Checked)
            {
                num = num | 0x02;
                num = num & ~(0x04);
            }
            if (chk3.Checked)
            {
                num = num | 0x04;
                num = num & ~(0x08);
            }
            if (chk4.Checked)
            {
                num = num | 0x08;
                num = num & ~(0x10);
            }
            if (chk5.Checked)
            {
                num = num | 0x10;
                num = num & ~(0x20);
            }
            if (chk6.Checked)
            {
                num = num | 0x20;
                num = num & ~(0x40);
            }
            if (chk7.Checked)
            {
                num = num | 0x40;
                num = num & ~(0x80);
            }

            return num;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnToBit_Click(object sender, EventArgs e)
        {
            // 입력
            int num = Convert.ToInt32(txtNum.Text);

            // 연산 + 출력 1way
            // if ((num & 0x01) != 0) // mask 씌움 ♣
            //    chk0.Checked = true;
            // else
            //    chk0.Checked = false;

            // 연산 + 출력 2way
            // chk0.Checked = (num & 0x01) != 0; // mask 씌움 ♣♣
            // chk1.Checked = (num & 0x02) != 0;
            // chk2.Checked = (num & 0x04) != 0;
            // chk3.Checked = (num & 0x08) != 0;
            // chk4.Checked = (num & 0x10) != 0;
            // chk5.Checked = (num & 0x20) != 0;
            // chk6.Checked = (num & 0x40) != 0;
            // chk6.Checked = (num & 0x80) != 0;

            // 연산 + 출력 3way
            // chk0.Checked = (num & 0x01 << 0) != 0; // mask 씌움 ♣
            // chk1.Checked = (num & 0x01 << 1) != 0;
            // chk2.Checked = (num & 0x01 << 2) != 0;
            // chk3.Checked = (num & 0x01 << 3) != 0;
            // chk4.Checked = (num & 0x01 << 4) != 0;
            // chk5.Checked = (num & 0x01 << 5) != 0;
            // chk6.Checked = (num & 0x01 << 6) != 0;
            // chk7.Checked = (num & 0x01 << 7) != 0;

            // 연산 + 출력 4way
            SetCheckBox(num);
        }

        private void BtnFromBit_Click(object sender, EventArgs e)
        {
            //// 입력 + 입력 1way
            //int num = 0;

            //if (chk0.Checked) num = num | 0x01; // mask 씌움. 한바퀴만 도는데, else if 쓰면 제일 위에꺼 하나만 하고 끝내버리니까 안됨
            //if (chk1.Checked) num = num | 0x02;
            //if (chk2.Checked) num = num | 0x04;
            //if (chk3.Checked) num = num | 0x08;
            //if (chk4.Checked) num = num | 0x10;
            //if (chk5.Checked) num = num | 0x20;
            //if (chk6.Checked) num = num | 0x40;
            //if (chk7.Checked) num = num | 0x80;

            // 입력 + 연산 2way
            int num = GetCheckBox();

            // 출력
            txtNum.Text = Convert.ToString(num);
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            // 입력
            int num = Convert.ToInt32(txtNum.Text);
            int idx = Convert.ToInt32(txtIdx.Text);

            // 연산
            num = num | 0x01 << idx; // ♣♣

            // 값 업데이트
            SetCheckBox(num);
            txtNum.Text = Convert.ToString(num);
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            // 입력
            int num = Convert.ToInt32(txtNum.Text);
            int idx = Convert.ToInt32(txtIdx.Text);

            // 연산
            num = num & ~(0x01 << idx); // ♣♣

            // 값 업데이트
            SetCheckBox(num);
            txtNum.Text = Convert.ToString(num);
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            // 입력
            int num = Convert.ToInt32(txtNum.Text);
            int idx = Convert.ToInt32(txtIdx.Text);

            // 연산
            num = num ^(0x01 << idx); // ♣♣

            // 값 업데이트
            SetCheckBox(num);
            txtNum.Text = Convert.ToString(num);
        }

        private void btnShiftUp_Click(object sender, EventArgs e)
        {
            // 입력
            int num = Convert.ToInt32(txtNum.Text);

            // 연산
            num = ShiftUpCheckBox(num);

            // 값 업데이트
            SetCheckBox(num);
            txtNum.Text = Convert.ToString(num);
        }

        private void btnShiftDown_Click(object sender, EventArgs e)
        {
            // 입력
            int num = Convert.ToInt32(txtNum.Text);

            // 연산
            num = ShiftDownCheckBox(num);

            // 값 업데이트
            SetCheckBox(num);
            txtNum.Text = Convert.ToString(num);
        }
    }
}
