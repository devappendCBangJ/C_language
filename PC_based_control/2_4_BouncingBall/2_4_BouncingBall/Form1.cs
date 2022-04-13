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
        Random rnd = new Random();
        int dx = 2, dy = 3;
        bool speedy = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void radSlow_CheckedChanged(object sender, EventArgs e) // ♣
        {
            if(speedy == false)
            {
                dx = dx / 3;
                dy = dy / 3;
                speedy = true;
                Console.WriteLine("%d, %d", dx, dy);
            }
        }

        private void radFast_CheckedChanged(object sender, EventArgs e)
        {
            if(speedy == true)
            {
                dx = dx * 3;
                dy = dy * 3;
                speedy = false;
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

            if (picBall.Left >= this.ClientSize.Width / 3 && picBall.Right <= this.ClientSize.Width * 2 / 3)
            {
                if(picBall.Top >= this.ClientSize.Height / 3 && picBall.Bottom <= this.ClientSize.Height * 2 / 3)
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
