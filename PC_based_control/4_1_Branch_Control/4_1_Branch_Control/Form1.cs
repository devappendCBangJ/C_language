using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_1_Branch_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // score에 따른 grade 출력
            double score = Convert.ToDouble(textBox1.Text);
            string grade = "";
            if (score >= 90) { grade = "A"; }
            else if (score >= 80) { grade = "B"; }
            else if (score >= 70) { grade = "C"; }
            else grade = "D";
            label1.Text = grade + " 입니다.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 출력
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
