using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_1_Class_Basic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cat kitty = new Cat(); // 프로그래머가 class에 생성자를 생성하지 않으면, 매개변수를 아무것도 받지 않는 default 생성자를 만들어줌 ♣
            kitty.Name = "키티";
            kitty.Color = "하얀색";

            Cat nabi = new Cat("나비", "갈색"); // 프로그래머가 class에 생성자를 하나라도 생성하면, default 생성자를 만들어주지 않음 ♣
            // Cat nero = new Cat("나비"); // 오버로딩이 없으므로 이건 안된다 ♣
        }
    }
}
