using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_1_Method_Basic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 초기화
            int a = 20;
            int b = 3;
            int c = 0; // ref 사용시 초기화 필수 ♣♣♣
            int d = 0; // ref 사용시 초기화 필수 ♣♣♣

            // 참조 매개변수이용 메소드
            // Divide_out(a, b, out c, out d);
            Divide_ref(a, b, ref c, ref d);
            Console.WriteLine("Quotient : {0}, Remainder : {1}", c, d); // 오버로딩 여러개 되어있다.
        }

        void Divide_out(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
        void Divide_ref(int a, int b, ref int quotient, ref int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
    }
}
