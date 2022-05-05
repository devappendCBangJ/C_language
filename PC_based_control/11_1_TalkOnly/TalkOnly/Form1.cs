using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace TalkOnly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false; // thread의 규칙 어김. 어느 순간 프로그램 사망 ♣
        }

        private void chkStart_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStart.Checked)
            {
                bool success = SPort.OpenPorts(serialPort1, Convert.ToInt32(txtPortNum.Text));
                if (!success)
                {
                    MessageBox.Show("시리얼포트를 열지 못했습니다", "오류");
                }
            }
            else
            {
                SPort.ClosePorts(serialPort1);
            }
        }

        private string gRcvbuffer;
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // 수신버퍼에서 데이터 읽어 전역변수에 붙이기
            string tmp = SPort.Read(serialPort1);
            gRcvbuffer += tmp;
            if (gRcvbuffer.Length >= 100)
            {
                // 처리안된 데이터가 너무 쌓이면 무시. 지우고 리턴 ♣
                gRcvbuffer = "";
                return;
            }

            //----  루프 돌면서 의미 있는 데이터 하나씩 뜯어서 처리
            while (true)
            {
                // gRcvbuffer 에서 STX 찾기. STX 앞쪽은 버림
                int ipos = gRcvbuffer.IndexOf(SPort.sSTX());
                if (ipos < 0) break;   // STX 없으면 처리할 데이터 없음. 탈출
                gRcvbuffer = gRcvbuffer.Substring(ipos);

                // CR-LF 찾기. CR-LF포함하여 앞쪽만 취하기
                ipos = gRcvbuffer.IndexOf("\r\n");
                if (ipos < 0) break;   // CRLF 없으면 데이터 완성안됨. 탈출
                string stwork = gRcvbuffer.Substring(0, ipos + 2);

                // Rcv Buffer 나머지만으로 축소
                gRcvbuffer = gRcvbuffer.Substring(ipos + 2); // 이건 왜 있는거지??? ♣

                // 화면에 표시
                lblRcv.Text = "수신 : " + stwork;

                // ETX 찾기. 앞쪽만 취하기
                ipos = stwork.IndexOf(SPort.sETX());
                if (ipos < 0) break;   // ETX 없으면 데이터 오류. 탈출
                stwork = stwork.Substring(0, ipos);

                // 맨 앞의 STX 떼기
                stwork = stwork.Substring(1);

                // 콤마기준으로뜯어내기
                char[] sep = new char[1] { ',' };
                string[] starr = stwork.Split(sep);

                // 버튼 상태 표시
                chkButton0.Checked = starr[1].Substring(0, 1) == "1";
                chkButton1.Checked = starr[1].Substring(1, 1) == "1";
                chkButton2.Checked = starr[1].Substring(2, 1) == "1";
                chkButton3.Checked = starr[1].Substring(3, 1) == "1";

                // 가변저항값 표시
                txtPotentio.Text = Convert.ToString(Convert.ToInt32(starr[2]));
            }
        }
    }
}
