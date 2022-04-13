using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_CatchMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sec = Convert.ToInt32(lblMsg.Text);
            sec--;
            if (sec < 5)
            {
                lblMsg.ForeColor = Color.Red;
            }
            if (sec == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("장난");
                Application.Exit();
            }
            lblMsg.Text = Convert.ToString(sec);
        }

        private void cancel_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            BtnCancel.Left = rnd.Next(this.ClientSize.Width - BtnCancel.Width);
            BtnCancel.Top = rnd.Next(this.ClientSize.Height - BtnCancel.Height);
        }
    }
}
