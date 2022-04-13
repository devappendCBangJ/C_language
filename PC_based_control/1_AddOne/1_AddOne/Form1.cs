using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_AddOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(lblNum.Text);
            n++;
            lblNum.Text = Convert.ToString(n);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            lblNum.Text = "0";
        }
    }
}
