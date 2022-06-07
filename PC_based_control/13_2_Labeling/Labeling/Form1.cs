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
using OpenCvSharp.Blob;

namespace Labeling
{
    public partial class Form1 : Form
    {
        VideoCapture gCap; // ♣♣♣

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)  // 파일읽기
            {
                string fname = openFileDialog.FileName;
                Mat mat = new Mat(fname); // ♣♣♣
                picSrc.Image = mat.ToBitmap(); // ♣♣♣
            }
        }

        private void btnWebCam_Click(object sender, EventArgs e)
        {
            if (timCam.Enabled == false)
            {
                int idxcam = 0;
                gCap = new VideoCapture(CaptureDevice.DShow, idxcam); // ♣

                // 필요하면 해상도 설정
                gCap.FrameWidth = 1280; // ♣
                gCap.FrameHeight = 1024;

                if (gCap.IsOpened() == false) return; // ♣

                timCam.Interval = 33;   //초당 30프레임 설정 ♣
                timCam.Enabled = true;
            }
            else
            {
                // 비활성
                timCam.Enabled = false;
                chkCam.Checked = false;
                if (gCap != null) gCap.Dispose();
            }
        }

        private void timCam_Tick(object sender, EventArgs e)
        {
            //gCap.Grab();  <- 내부 메모리에 먼저 저장할 필요가 있을 때 사용
            Mat mat = gCap.RetrieveMat();   // VideoCapture를 mat로 변환 ♣
            picSrc.Image = mat.ToBitmap(); // ♣

            // 깜박거림 표시
            chkCam.Checked = !chkCam.Checked;

            // Garbage Collector
            //GC.Collect(); // 수행하면 메모리 쌓이지 않음. CPU는 UP
        }

        private void btnToGray_Click(object sender, EventArgs e)
        {
            if (picSrc.Image == null) return; // ♣

            // picSrc의 Image를 추출하여 matSrc에 저장
            Bitmap bmp = picSrc.Image as Bitmap;        // Bitmap class가 파생클래스이므로 변환 가능 ♣
            Mat matSrc = BitmapConverter.ToMat(bmp); // ♣♣♣

            // (OpenCV 함수를 이용하여) matSrc를 Gray로 변환
            Mat matGray = matSrc.CvtColor(ColorConversionCodes.BGR2GRAY); // ♣♣♣
            picGray.Image = matGray.ToBitmap(); // ♣
        }

        private void btnToBin_Click(object sender, EventArgs e)
        {
            if (picGray.Image == null) return;

            // picGray의 Image를 추출하여 matGray에 저장
            Bitmap bmp = picGray.Image as Bitmap;
            Mat matGray = BitmapConverter.ToMat(bmp);

            // (OpenCV 함수를 이용하여) matGray를 Binary로 변환
            if (radOtus.Checked)        // Otus의 알고리즘
            {
                Mat matBin = matGray.Threshold(0, 255, ThresholdTypes.Otsu); // ♣♣♣
                picBin.Image = matBin.ToBitmap();
            }
            else if (radBin.Checked)    // threshold 직접 지정 알고리즘 : 스크롤바 활용해서 threshold 지정
            {
                double thresh = hscThreshold.Value; // ♣
                Mat matBin = matGray.Threshold(thresh, 255, ThresholdTypes.Binary); // ♣
                picBin.Image = matBin.ToBitmap();
            }
        }

        private void hscThreshold_Scroll(object sender, ScrollEventArgs e)
        {
            lblThreshold.Text = Convert.ToString(hscThreshold.Value);
            btnToBin.PerformClick(); // ♣
        }

        private void radOtus_CheckedChanged(object sender, EventArgs e)
        {
            btnToBin.PerformClick(); // ♣
        }

        private void radBin_CheckedChanged(object sender, EventArgs e)
        {
            btnToBin.PerformClick(); // ♣
        }
        

        private void btnEdge_Click(object sender, EventArgs e)
        {
            if (picGray.Image == null) return;

            // picGray의 Image를 추출하여 matGray에 저장
            Bitmap bmp = picGray.Image as Bitmap;
            Mat matGray = BitmapConverter.ToMat(bmp);

            // (OpenCV 함수를 이용하여) Canny Edge 영상 얻기
            int threshold = hscThreshold.Value;
            Mat matEdge = matGray.Canny(threshold, 255); // ♣♣♣
            picResult.Image = matEdge.ToBitmap();
        }

        private void btnLabelingCV_Click(object sender, EventArgs e)
        {
            if (picBin.Image == null) return;

            // picBin의 Image를 추출하여 matBin에 저장
            Bitmap bmp = picBin.Image as Bitmap;
            Mat matBin = BitmapConverter.ToMat(bmp);

            // (kLabeling 을 이용하여) matBin을 Labeling
            DateTime stime = DateTime.Now;

            Mat matResult;
            CvBlob[] blobArr = LabelingCV.FindBlobs(matBin, out matResult); // ♣♣♣
            int nblob = blobArr.Length; // ♣♣♣

            double dtime = Util.TimeInSeconds(stime);

            // 결과 그림 표시
            picResult.Image = matResult.ToBitmap();

            // 결과 텍스트창에 표시
            int area;
            double xcen, ycen;
            txtLabelingResult.Text = "라벨링시간(초)= " + string.Format("{0:##0.000}", dtime) + "\r\n";
            txtLabelingResult.Text = "라벨 개수= " + Convert.ToString(nblob) + "\r\n";
            for (int i = 0; i < nblob; i++)
            {
                LabelingCV.getAreaCenter(blobArr[i], out area, out xcen, out ycen);
                txtLabelingResult.Text += "동전번호= " + Convert.ToString(i + 1).PadLeft(2) + "  " +
                                        "면적= " + Convert.ToString(area).PadLeft(5) + "  " +
                                        "중심= " + string.Format("{0:##0.00}", xcen) + ", " +
                                        string.Format("{0:##0.00}", ycen) + "\r\n";
            }
        }

        private void btnLabelingK_Click(object sender, EventArgs e)
        {
            if (picBin.Image == null) return;

            // picBin의 Image를 추출하여 matBin에 저장
            Bitmap bmp = picBin.Image as Bitmap;
            Mat matBin = BitmapConverter.ToMat(bmp);

            // (kLabeling 을 이용하여) matBin을 Labeling
            DateTime stime = DateTime.Now;

            bool isObjWhite = true;
            Mat[] matLabels = LabelingK.getLabels(matBin, 0, isObjWhite);
            int nlabel = matLabels.Length;

            double dtime = Util.TimeInSeconds(stime);

            // 결과 그림 표시
            picResult.Image = picBin.Image;
            Application.DoEvents();     // 윈도그림 나타나게하기 위해

            // 결과 텍스트창에 표시
            int area;
            double xcen, ycen;
            txtLabelingResult.Text = "라벨링시간(초)= " + string.Format("{0:##0.000}", dtime) + "\r\n";

            for (int i = 0; i < nlabel; i++)
            {
                LabelingK.getAreaCenter(matLabels[i], isObjWhite, out area, out xcen, out ycen);
                txtLabelingResult.Text += "라벨번호= " + Convert.ToString(i + 1).PadLeft(2) + "  " +
                                        "면적= " + Convert.ToString(area).PadLeft(5) + "  " +
                                        "중심= " + string.Format("{0:##0.00}", xcen) + ", " +
                                        String.Format("{0:##0.00}", ycen) + "\r\n";

                Graphics grp = picResult.CreateGraphics();
                grp.DrawLine(new Pen(Color.Yellow), (float)xcen - 5, (float)ycen, (float)xcen + 5, (float)ycen);
                grp.DrawLine(new Pen(Color.Yellow), (float)xcen, (float)ycen - 5, (float)xcen, (float)ycen + 5);
            }
        }
    }
}
