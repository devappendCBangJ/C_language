using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatArduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false; // CrossThreadCalls 허용. 원래 이거 장시간 쓰면 에러 발생 ♣
        }

        //========================================================
        //  데이터읽기 ♣
        //========================================================
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (txtDialog.Text.Length > 1200) txtDialog.Text = "";

            string inp = SPort.Read(serialPort);
            txtDialog.Text += "[Arduino] " + inp;
        }

        //========================================================
        //  Port 열기 ♣
        //========================================================
        private void btnOpen_Click(object sender, EventArgs e)
        {
            bool success = false;
            try
            {
                success = SPort.OpenPorts(serialPort, Convert.ToInt32(txtPortNum.Text));
            }
            catch
            { }

            if (success)
            {
                btnOpen.Enabled = false;
                btnSend.Enabled = true;
            }
            else { MessageBox.Show("시리얼포트를 열지 못했습니다", "오류"); }
        }

        //========================================================
        //  컴퓨터에 존재하는 Port 알아보기 ♣
        //========================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SPort.GetPortsList();

            lblCOMs.Text = "";
            for (int i = 0; i < ports.Length; i++)
            {
                lblCOMs.Text = lblCOMs.Text + ports[i] + "\r\n";
            }
        }

        //========================================================
        //  데이터보내기 ♣
        //========================================================
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtDialog.Text.Length > 1200) txtDialog.Text = "";

            string st = txtInput.Text.Trim();
            if (st.Length == 0) return;

            st = st + "\r\n";
            SPort.Send(serialPort, st);

            txtDialog.Text += "[PC] " + st;
            txtInput.Text = "";
        }

        //========================================================
        //  엔터 입력시 버튼 클릭 활성화 ♣
        //========================================================
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && btnSend.Enabled)
                btnSend.PerformClick();
        }
    }
}
