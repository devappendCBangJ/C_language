using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_4_BouncingBall
{
    public partial class Form1 : Form
    {
        int dx = 2, dy = 3;
        int speed = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void radSlow_CheckedChanged(object sender, EventArgs e)
        {
            if(speed == 0)
            {
                dx = dx / 3;
                dy = dy / 3;
                speed = 1;
                Console.WriteLine("%d, %d", dx, dy);
            }
        }

        private void radFast_CheckedChanged(object sender, EventArgs e)
        {
            if(speed == 1)
            {
                dx = dx * 3;
                dy = dy * 3;
                speed = 0;
                Console.WriteLine("%d, %d", dx, dy);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picBall.Left = picBall.Left + dx;
            picBall.Top = picBall.Top + dy;
            if (this.ClientSize.Width - picBall.Width <= picBall.Left)
            {
                dx = -dx;
            }
            else if(picBall.Width >= picBall.Right)
            {
                dx = -dx;
            }
            else if(this.ClientSize.Height - picBall.Height <= picBall.Top)
            {
                dy = -dy;
            }
            else if(picBall.Height >= picBall.Bottom)
            {
                dy = -dy;
            }

            if (picBall.Left >= this.ClientSize.Width / 3 && picBall.Left <= this.ClientSize.Width * 2 / 3)
            {
                if(picBall.Top >= this.ClientSize.Height / 3 && picBall.Top <= this.ClientSize.Height * 2 / 3)
                {
                    picBall.BackColor = Color.Red;
                }
                else
                {
                    picBall.BackColor = Color.Blue;
                }
            }
            else
            {
                picBall.BackColor = Color.Blue;
            }
        }
    }
}
