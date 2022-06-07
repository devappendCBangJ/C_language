using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace tServer
{
    public partial class Form1 : Form // ♣
    {
        // 소켓 + 저장버퍼 생성 ♣
        private TServer serverChat;     //채팅용 소켓
        private TServer serverCopy;     //원위치복사용 소켓
        private TServer serverComm;     //비트통신용 소켓

        private string rbuffcir = "";   // 원위치송신메시지 저장버퍼
        private string rbuffbit = "";   // 비트정보 asking 메시지 저장버퍼

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;    // Thread 규칙 위반 선언(다른 thread에 있는 UI 수정 가능) ♣
        }

        // 폼 로드 시, HostName과 HostAddress 받기 + 출력 ♣
        private void Form1_Load(object sender, EventArgs e)     // Hostname, HostAddress 추출 + 출력
        {
            string hostname = TSocket.HostName();
            IPAddress[] addrs = TSocket.HostAddresses();        // 자료형이 IPAddress ♣

            string st = hostname + "\r\n";
            for (int i = 0; i < addrs.Length; i++)
            {
                st = st + addrs[i].ToString() + "\r\n";
            }
            lblComInfo.Text = st;
        }

        // 타이머 간격마다, 소켓 열려있으면 서버 연결 상태 받기 + 출력 ♣
        private void timConnStatus_Tick(object sender, EventArgs e)
        {
            if (serverChat == null) { lblConnChat.Text = "Chat : " + "NULL"; }
            else
            {
                csConnStatus conn = serverChat.ServerStatus();
                lblConnChat.Text = "Chat : " + conn.ToString();
            }

            if (serverCopy == null) { lblConnCopy.Text = "Copy : " + "NULL"; }
            else
            {
                csConnStatus conn = serverCopy.ServerStatus();
                lblConnCopy.Text = "Copy : " + conn.ToString();
            }

            if (serverComm == null) { lblConnComm.Text = "Comm : " + "NULL"; }
            else
            {
                csConnStatus conn = serverComm.ServerStatus();
                lblConnComm.Text = "Comm : " + conn.ToString();
            }

        }

        // 버튼 클릭시, HostAddress 받기 + 출력 ♣
        private void btnServerMe_Click(object sender, EventArgs e)  // HostAddress 출력
        {
            txtMyIP.Text = TSocket.HostAddresses()[1].ToString();   //XP는 [0]
        }

        // 버튼 클릭시, 소켓 열려있으면 서버 닫기 ♣
        private void btnClose_Click(object sender, EventArgs e)     // 서버 닫기
        {
            if (serverChat != null) serverChat.ServerClose();
            if (serverCopy != null) serverCopy.ServerClose();
            if (serverComm != null) serverComm.ServerClose();
        }

        // 버튼 클릭시, 소켓 열음 + listen 시작 ♣
        private void btnListen_Click(object sender, EventArgs e)     
        {
            string myIP = txtMyIP.Text;

            if (serverChat == null) serverChat = new TServer();                         // 서버 열기 + 타이머 방식 listen 시작
            serverChat.ServerStartListen(myIP, 5000);   // 1024~65535 추천

            if (serverCopy == null) serverCopy = new TServer(CirclePosDataArrived);     // 서버 열기 + 이벤트 방식 listen 시작
            serverCopy.ServerStartListen(myIP, 5001);   // 1024~65535 추천

            if (serverComm == null) serverComm = new TServer(AskingBitsDataArrived);    // 서버 열기 + 폴링 방식 listen 시작
            serverComm.ServerStartListen(myIP, 5002);   // 1024~65535 추천
        }

        // 원 좌표 수신 : 통신 형태 맞으면 x, y좌표 슬라이싱 + 원 이동 ♣
        private void CirclePosDataArrived()
        {
            while (true)
            {
                rbuffcir += serverCopy.GetRcvMsg();
                int idx1 = rbuffcir.IndexOf(TSocket.sSTX());
                if (idx1 < 0) break; // ♣♣♣
                int idx2 = rbuffcir.IndexOf(TSocket.sETX(), idx1);

                if (idx1 >= 0 && idx2 > idx1) // ♣♣♣
                {
                    string xypos = rbuffcir.Substring(idx1 + 1, idx2 - idx1 - 1); // ♣
                    char[] sep = new char[] { ',' };
                    string[] xy = xypos.Split(sep);
                    lblO.Left = Convert.ToInt32(xy[0]);
                    lblO.Top = Convert.ToInt32(xy[1]);
                    rbuffcir = rbuffcir.Substring(idx2 + 1); // ♣
                }
                else // ♣♣♣
                    break;
            }

        }

        // 비트 정보 송신 : 통신 형태 맞으면 비트 생성 + 송신 ♣
        private void AskingBitsDataArrived()        // 비트 호출 신호 수신 + 비트 정보 송신
        {
            while (true)
            {
                rbuffbit += serverComm.GetRcvMsg();
                int idx1 = rbuffbit.IndexOf(TSocket.sSTX());
                if (idx1 < 0) break;
                int idx2 = rbuffbit.IndexOf(TSocket.sETX(), idx1);

                if (idx1 >= 0 && idx2 - idx1 == 3) // ♣♣♣
                {
                    string stnet = rbuffbit.Substring(idx1 + 1, 2);
                    if (stnet == "RI")
                    {
                        int ibits = 0; // ♣♣♣
                        if (chkDI0.Checked) ibits += 0x1;
                        if (chkDI1.Checked) ibits += 0x2;
                        if (chkDI2.Checked) ibits += 0x4;
                        if (chkDI3.Checked) ibits += 0x8;
                        if (chkDI4.Checked) ibits += 0x10;
                        if (chkDI5.Checked) ibits += 0x20;
                        if (chkDI6.Checked) ibits += 0x40;
                        if (chkDI7.Checked) ibits += 0x80;

                        string hexnum = Util.Hex(ibits);
                        if (hexnum.Length == 1) hexnum = "0" + hexnum;
                        string st = TSocket.sACK() + "RI" + hexnum + TSocket.sETX();
                        serverComm.ServerSend(st);
                    }
                    // 처리한 곳까지 잘라내기
                    rbuffbit = rbuffbit.Substring(idx2 + 1); // ♣♣♣
                }
            }
        }

        // 버튼 클릭시, 소켓 열려있으면 통신값 보냄 + 출력 ♣
        private void btnSend_Click(object sender, EventArgs e) // 소켓 만들어짐 + 텍스트 존재하는 경우 통신값 보내기
        {
            if (serverChat == null) return;         // 소켓이 null인 경우 : connect이 안된 상태이므로 return

            string st = txtSend.Text.Trim();
            if (st.Length <= 0) return;

            serverChat.ServerSend(st + "\r\n");
            txtDialog.Text += "[Me] " + st + "\r\n";
            txtSend.Text = "";
        }

        // 마우스 올린 상태에서 엔터키 누를 시, 버튼 클릭 ♣
        private void Form1_KeyPress(object sender, KeyPressEventArgs e) // 마우스만 올려져있는 상태로 enter키 누르면, btnSend 누른것과 같은 효과
        {
            if (e.KeyChar == '\r') btnSend.PerformClick(); // ♣
        }

        // 타이머 간격마다, 소켓 열려있으면 통신값 받음 + 출력 ♣
        private void timGetRcvMsg_Tick(object sender, EventArgs e) // 소켓 만들어진 경우 통신값 받기
        {
            if (serverChat == null) return;
            string st = serverChat.GetRcvMsg();
            if (st.Length > 0) txtDialog.Text += st;
        }
    }
}
