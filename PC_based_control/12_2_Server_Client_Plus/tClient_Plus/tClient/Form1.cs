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

namespace tClient
{
    public partial class Form1 : Form
    {
        private TClient clientChat;     //채팅용 소켓
        private TClient clientCopy;     //원위치복사용 소켓
        private TClient clientComm;     //비트통신용 소켓
        private TClient clientCopy2;    //원위치복사용2 소켓    // ● 추가된 부분

        private string rbuffcir = "";   // 원위치송신메시지 저장버퍼
        private string rbuffbit = "";   // 비트정보 asking 메시지 저장버퍼
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;    // Thread 규칙 위반 선언(다른 thread에 있는 UI 수정 가능)
        }

        // 폼 로드 시, HostName과 HostAddress 받기 + 출력
        private void Form1_Load(object sender, EventArgs e)
        {
            string hostname = TSocket.HostName();
            IPAddress[] addrs = TSocket.HostAddresses();

            string st = hostname + "\r\n";
            for (int i = 0; i < addrs.Length; i++)
            {
                st = st + addrs[i].ToString() + "\r\n";
            }

            lblComInfo.Text = st;
        }

        // 타이머 간격마다, 소켓 열려있으면 클라이언트 연결 상태 받기 + 출력
        private void timConnStatus_Tick(object sender, EventArgs e)             // 각 소켓별 상태
        {
            if (clientChat == null) { lblConnChat.Text = "Chat : " + "NULL"; }
            else
            {
                csConnStatus conn = clientChat.ClientStatus();
                lblConnChat.Text = "Chat : " + conn.ToString();
            }

            if (clientCopy == null) { lblConnCopy.Text = "Copy : " + "NULL"; }
            else
            {
                csConnStatus conn = clientCopy.ClientStatus();
                lblConnCopy.Text = "Copy : " + conn.ToString();
            }

            if (clientComm == null) { lblConnComm.Text = "Comm : " + "NULL"; }
            else
            {
                csConnStatus conn = clientComm.ClientStatus();
                lblConnComm.Text = "Comm : " + conn.ToString();
            }

            if (clientCopy2 == null) { lblConnCopy2.Text = "Comm : " + "NULL"; }    // ● 추가된 부분
            else
            {
                csConnStatus conn = clientCopy2.ClientStatus();
                lblConnCopy2.Text = "Comm : " + conn.ToString();
            }

            if ((clientChat != null && clientCopy != null && clientComm != null && clientCopy2 != null)    // ● 추가된 부분
                && (clientChat.ClientStatus().ToString() == "Closed" || clientCopy.ClientStatus().ToString() == "Closed"
                || clientComm.ClientStatus().ToString() == "Closed" || clientCopy2.ClientStatus().ToString() == "Closed") )
            {
                string serverIP = txtServerIP.Text;
                string clientIP = TSocket.HostAddresses()[1].ToString();    //XP는 [0]

                if (clientChat == null) clientChat = new TClient();         // 서버 열기 + 타이머 방식 connection 요청
                clientChat.ClientBeginConnect(serverIP, 5000, clientIP);    // 1024~65535 추천

                if (clientCopy == null) clientCopy = new TClient();         // 서버 열기 + 이벤트 방식 connection 요청(보내기만하므로 이벤트 핸들링 함수 선언x. CirclePosDataArrived 표시x)
                clientCopy.ClientBeginConnect(serverIP, 5001, clientIP);    // 1024~65535 추천

                if (clientComm == null) clientComm = new TClient();         // 서버 열기 + 폴링 방식 connection 요청(보내기만하므로 이벤트 핸들링 함수 선언x. AskingBitsDataArrived 표시x)
                clientComm.ClientBeginConnect(serverIP, 5002, clientIP);    // 1024~65535 추천

                if (clientCopy2 == null) clientCopy2 = new TClient(CirclePosDataArrived);         // 서버 열기 + 폴링 방식 connection 요청(보내기만하므로 이벤트 핸들링 함수 선언x. AskingBitsDataArrived 표시x)
                clientCopy2.ClientBeginConnect(serverIP, 5003, clientIP);    // 1024~65535 추천
            }
        }

        // 버튼 클릭시, HostAddress 받기 + 출력
        private void btnServerMe_Click(object sender, EventArgs e)
        {
            txtServerIP.Text = TSocket.HostAddresses()[1].ToString();//XP는 [0]
        }

        // 버튼 클릭시, 소켓 열음 + connect 시작
        private void btnConnect_Click(object sender, EventArgs e)
        {
            string serverIP = txtServerIP.Text;
            string clientIP = TSocket.HostAddresses()[1].ToString();    //XP는 [0]

            if (clientChat == null) clientChat = new TClient();         // 서버 열기 + 타이머 방식 connection 요청
            clientChat.ClientBeginConnect(serverIP, 5000, clientIP);    // 1024~65535 추천

            if (clientCopy == null) clientCopy = new TClient();         // 서버 열기 + 이벤트 방식 connection 요청(보내기만하므로 이벤트 핸들링 함수 선언x. CirclePosDataArrived 표시x)
            clientCopy.ClientBeginConnect(serverIP, 5001, clientIP);    // 1024~65535 추천

            if (clientComm == null) clientComm = new TClient();         // 서버 열기 + 폴링 방식 connection 요청(보내기만하므로 이벤트 핸들링 함수 선언x. AskingBitsDataArrived 표시x)
            clientComm.ClientBeginConnect(serverIP, 5002, clientIP);    // 1024~65535 추천

            if (clientCopy2 == null) clientCopy2 = new TClient(CirclePosDataArrived);         // 서버 열기 + 폴링 방식 connection 요청(보내기만하므로 이벤트 핸들링 함수 선언x. AskingBitsDataArrived 표시x)
            clientCopy2.ClientBeginConnect(serverIP, 5003, clientIP);    // 1024~65535 추천
        }

        // 버튼 클릭시, 소켓 열려있으면 클라이언트 닫기
        private void btnClose_Click(object sender, EventArgs e)         // 클라이언트 닫기
        {
            if (clientChat != null) clientChat.ClientClose();
            if (clientCopy != null) clientCopy.ClientClose();
            if (clientComm != null) clientComm.ClientClose();
            if (clientCopy2 != null) clientCopy2.ClientClose();  // ● 추가된 부분
        }

        // 버튼 클릭시, 소켓 열려있으면 통신값 보냄 + 출력
        private void btnSend_Click(object sender, EventArgs e)          // 소켓 만들어짐 + 텍스트 존재하는 경우 통신값 보내기
        {
            if (clientChat == null) return;

            string st = txtSend.Text.Trim();
            if (st.Length <= 0) return;

            clientChat.ClientSend(st + "\r\n");
            txtDialog.Text += "[Me] " + st + "\r\n";
            txtSend.Text = "";
        }

        // 마우스 올린 상태에서 엔터키 누를 시, 버튼 클릭
        private void Form1_KeyPress(object sender, KeyPressEventArgs e) // 마우스만 올려져있는 상태로 enter키 누르면, btnSend 누른것과 같은 효과
        {
            if (e.KeyChar == '\r') btnSend.PerformClick();
        }

        // 타이머 간격마다, 소켓 열려있으면 통신값 받음 + 출력
        private void timGetRcvMsg_Tick(object sender, EventArgs e)      // 소켓 만들어진 경우 통신값 받기
        {
            if (clientChat == null) return;
            string st = clientChat.GetRcvMsg();
            if (st.Length > 0) txtDialog.Text += st;
        }

        // 원 좌표 수신 : 통신 형태 맞으면 x, y좌표 슬라이싱 + 원 이동   // ● 추가된 부분
        private void CirclePosDataArrived()
        {
            while (true)
            {
                rbuffcir += clientCopy2.GetRcvMsg();
                int idx1 = rbuffcir.IndexOf(TSocket.sSTX());
                if (idx1 < 0) break;
                int idx2 = rbuffcir.IndexOf(TSocket.sETX(), idx1);

                if (idx1 >= 0 && idx2 > idx1)
                {
                    string xypos = rbuffcir.Substring(idx1 + 1, idx2 - idx1 - 1);
                    char[] sep = new char[] { ',' };
                    string[] xy = xypos.Split(sep);
                    lblO.Left = Convert.ToInt32(xy[0]);
                    lblO.Top = Convert.ToInt32(xy[1]);
                    rbuffcir = rbuffcir.Substring(idx2 + 1);
                }
                else
                    break;
            }
        }

        // picDraw에서 마우스 움직임 시, 원 좌표 송신 : 통신 형태 맞으면 x, y좌표 csv 형태 송신
        private void pnlDraw_MouseMove(object sender, MouseEventArgs e) // 마우스 움직임 : 원 좌표 송신
        {
            if (e.Button != MouseButtons.Left) return;
            lblO.Left = e.X;
            lblO.Top = e.Y;

            string st = TSocket.sSTX() + Convert.ToString(e.X) +
                        "," + Convert.ToString(e.Y) + TSocket.sETX();
            clientCopy.ClientSend(st);
        }

        // picDraw에서 마우스 움직임 시, 원 좌표 송신 : 통신 형태 맞으면 x, y좌표 csv 형태 송신
        private void pnlDraw_MouseDown(object sender, MouseEventArgs e) // 마우스 움직임 : 원 좌표 송신
        {
            if (e.Button != MouseButtons.Left) return;
            lblO.Left = e.X;
            lblO.Top = e.Y;

            string st = TSocket.sSTX() + Convert.ToString(e.X) +
                        "," + Convert.ToString(e.Y) + TSocket.sETX();
            clientCopy.ClientSend(st);
        }

        // 비트 정보 수신 : 소켓 열려있고, 통신 형태 맞으면 비트 수신
        private void btnReadBits_Click(object sender, EventArgs e)  // 소켓 존재 + 통신 연결 시, 체크박스 업데이트
        {
            if (clientComm == null) return;
            if (clientComm.ClientStatus() != csConnStatus.Connected) return;

            bool[] bits = new bool[8];
            bool success = TComm.AskDigitalInput(clientComm, bits);
            if (success)
            {
                chkDI0.Checked = bits[0];
                chkDI1.Checked = bits[1];
                chkDI2.Checked = bits[2];
                chkDI3.Checked = bits[3];
                chkDI4.Checked = bits[4];
                chkDI5.Checked = bits[5];
                chkDI6.Checked = bits[6];
                chkDI7.Checked = bits[7];
                lblCommOK.Text =
                     Convert.ToString(Convert.ToInt32(lblCommOK.Text) + 1);
            }
            else
            {
                lblCommNG.Text =
                     Convert.ToString(Convert.ToInt32(lblCommNG.Text) + 1);
            }
        }

        // 타이머 간격마다, 비트 정보 수신
        private void timAskBits_Tick(object sender, EventArgs e)
        {
            btnReadBits.PerformClick();
        }
    }
}
