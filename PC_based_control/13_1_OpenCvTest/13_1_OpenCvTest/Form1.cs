using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace _13_1_OpenCvTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mat matOrg = new Mat("Lake.JPG"); // ♣
            pictureBox1.Image = matOrg.ToBitmap(); // ♣
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mat matOrg = new Mat("Lake.JPG");   // OpenCv에서 이미지 한장의 자료형 : Mat ♣
            Mat matGray = matOrg.CvtColor(ColorConversionCodes.BGR2GRAY); // ♣♣♣
            pictureBox1.Image = matGray.ToBitmap(); // ♣♣♣
        }
    }
}
