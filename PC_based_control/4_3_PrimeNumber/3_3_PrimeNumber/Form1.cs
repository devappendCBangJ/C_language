using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_3_PrimeNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 소수 판별
        private bool isPrime(int num)
        {
            bool isprime = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isprime = false;
                    break;
                }
            }
            return isprime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 소수 판단 & 출력
            int num = Convert.ToInt32(textBox1.Text);
            bool isprime = isPrime(num);
            label1.Text = isprime ? "소수입니다" : "소수가 아닙니다"; // 3항 연산자
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 10000까지의 소수 출력
            int cnt = 0;
            for(int i = 2; i<=10000; i++)
            {
                if (isPrime(i) == true) cnt++;
            }
            label1.Text = Convert.ToString(cnt) + "개 입니다.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 10000번째 소수 출력
            int cnt2 = 0;
            int i = 2;
            while (true)
            {
                if (isPrime(i++) == true) cnt2++; // ♣♣
                if (cnt2 == 10000)
                {
                    break;
                }
            }
            label1.Text = Convert.ToString(i-1) + "입니다.";
        }
    }
}
