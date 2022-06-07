using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

enum csConnStatus
{
    Closed,
    Listening,
    Connecting,
    Connected
};

static class TSocket
{
    public static char sSTX() { return Convert.ToChar(0x02); }
    public static char sETX() { return Convert.ToChar(0x03); }
    public static char sEOT() { return Convert.ToChar(0x04); }
    public static char sENQ() { return Convert.ToChar(0x05); }
    public static char sACK() { return Convert.ToChar(0x06); }
    public static char sNAK() { return Convert.ToChar(0x15); }
    public static char sCR() { return Convert.ToChar(13); }
    public static char sLF() { return Convert.ToChar(10); }
    public static string sCRLF() { return "\r\n"; }

    public static string HostName()
    {
        return Dns.GetHostName();               // 컴퓨터명 파악 ♣
    }

    public static IPAddress[] HostAddresses()   // 컴퓨터 IP주소 파악 ♣
    {
        string hostname = HostName();
        IPAddress[] ips = Dns.GetHostAddresses(hostname);
        return ips;
    }
}

// 데이터 수신 이벤트핸들링 함수 delegate 원형
public delegate void ServerDataArrivalHandler();

class TServer
{
    private const int buffersize = 1024;

    // Server용 Socket 객체
    private TcpListener listener = null;        // Listening중에만존재, 연결되면null
    private TcpClient clientForServer = null;
    private NetworkStream streamServer = null;

    // 현재의 상태
    private csConnStatus serverStatus = csConnStatus.Closed;

    // Server용 수신 thread
    private Thread threadServerRcv = null;
    private Thread threadChkPartnerDeath = null;

    // Server 수신 데이터
    private string serverRcvMessage = "";

    // 수신이벤트를 위한 델리게이트
    private ServerDataArrivalHandler DataArrivalCallback;

    //===============================================================
    //  생성자 1 : 수신데이터 이벤트핸들링 없은 경우.
    //  생성자 2 : 수신데이터 이벤트핸들링 함수를 지정하는 경우
    //===============================================================
    public TServer()                                                    // 수신버퍼의 통신값 확인하는 생성자
    {
        DataArrivalCallback = null;
    }
    public TServer(ServerDataArrivalHandler callback)
    {
        DataArrivalCallback = new ServerDataArrivalHandler(callback);   // 수신버퍼에 통신값 들어오면 콜백함수로 호출하는 생성자
    }

    //===============================================================
    //  Server : Start
    //===============================================================
    public void ServerStartListen(string serverIP, int serverPort)
    {
        // listening, connected : return
        if (serverStatus == csConnStatus.Listening) return;
        if (serverStatus == csConnStatus.Connected) return;

        // 1단계 : Start
        try
        {
            // server측 접속 IP 객체 얻기
            IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse(serverIP), serverPort);

            // server 객체 얻기
            listener = new TcpListener(serverAddress);

            // Start
            listener.Start();
        }
        catch (SocketException e)
        {
            Console.WriteLine(e);
            return;
        }

        // 2단계 : Listen 시작
        bool success = ServerBeginListen();

        serverStatus = csConnStatus.Listening;
    }

    //===============================================================
    //  Server : Listen 시작 [Async 모드]
    //===============================================================
    private bool ServerBeginListen()
    {
        try  // listening중에 다시 같은 포트로 들어오는 경우 대비
        {
            listener.BeginAcceptTcpClient(new AsyncCallback(DoAcceptTcpClientCallback), listener);
        }
        catch { return false; }

        return true;
    }

    //---------------------------------------------------------------
    //  Listen CallBack 함수
    //---------------------------------------------------------------
    private void DoAcceptTcpClientCallback(IAsyncResult ar)
    {
        try  // Listen 대기중 Close 했을때의 exception 처리를 위해
        {
            // Get the listener that handles the client request.
            listener = (TcpListener)ar.AsyncState;

            // End the operation
            clientForServer = listener.EndAcceptTcpClient(ar);

            // stream 객체 얻기
            streamServer = clientForServer.GetStream();

            // 수신 thread 시작
            threadServerRcv = new Thread(ServerReceiveThreadMain);
            threadServerRcv.IsBackground = true;
            threadServerRcv.Start();

            // 상대 돌발죽음 감시 thread 시작
            threadChkPartnerDeath = new Thread(ServerCheckPartnerDeathThread);
            threadChkPartnerDeath.IsBackground = true;
            threadChkPartnerDeath.Start();

            serverStatus = csConnStatus.Connected;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            serverStatus = csConnStatus.Closed;
        }
        finally
        {
            // 연결되건, 최소되건 listener는 필요 없어짐
            listener.Stop();
            listener = null;
        }
    }

    //===============================================================
    //  Server : Close
    //===============================================================
    public void ServerClose()
    {
        if (clientForServer != null) clientForServer.Close();
        if (listener != null) listener.Stop();

        while (true)
        {   // listening중에 close되면 
            // DoAcceptTcpClientCallback()에서 listener처리할때까지 대기
            if (listener == null) break;
        }

        // 순서 바뀌면 안됨
        if (threadServerRcv != null && threadServerRcv.IsAlive)
        {
            threadServerRcv.Abort();
            threadServerRcv.Join();
        }

        if (threadChkPartnerDeath != null && threadChkPartnerDeath.IsAlive)
        {
            threadChkPartnerDeath.Abort();
            threadChkPartnerDeath.Join();
        }

        serverStatus = csConnStatus.Closed;
    }

    //===============================================================
    //  Server Status
    //===============================================================
    public csConnStatus ServerStatus()
    {
        return serverStatus;
    }

    //===============================================================
    //  Server Send
    //===============================================================
    public void ServerSend(string st)
    {
        try
        {
            if (streamServer == null || !streamServer.CanWrite) return;
            byte[] msg = Encoding.UTF8.GetBytes(st);
            streamServer.Write(msg, 0, msg.Length);
        }
        catch { }
    }

    //===============================================================
    //  수신 데이터 꺼내기
    //===============================================================
    public string GetRcvMsg()
    {
        lock (serverRcvMessage)  //<- thread간 동기화
        {
            string tmp = serverRcvMessage;
            serverRcvMessage = "";
            return tmp;
        }
    }

    //===============================================================
    //  Server Receive Thread Main
    //===============================================================
    private void ServerReceiveThreadMain()
    {
        try
        {
            byte[] bytebuff = new byte[buffersize];
            while (true)
            {
                Thread.Sleep(1);

                if (streamServer == null) continue;
                if (!streamServer.CanRead) continue;

                StringBuilder strbuff = new StringBuilder();
                int nbyteRead = 0;

                // 도착 message가 buffer 크기보다 큰 경우를 위해 loop
                do
                {
                    nbyteRead = streamServer.Read(bytebuff, 0, bytebuff.Length);    // blocking
                    if (nbyteRead == 0)
                    {   // 상대방이 close했음을 감지
                        serverStatus = csConnStatus.Closed;
                        ServerClose();              //<- 없으면 안됨!!
                    }
                    strbuff.AppendFormat("{0}", Encoding.UTF8.GetString(bytebuff, 0, nbyteRead));
                }
                while (streamServer.DataAvailable);

                // 수신버퍼에 복사
                lock (serverRcvMessage)  //<- thread간 동기화
                {
                    serverRcvMessage += strbuff;
                }

                // 데이터 수신 callback 함수 호출
                if (DataArrivalCallback != null) { DataArrivalCallback(); }
            }
        }
        catch { }
    }

    //===============================================================
    //  Server Check Partner Death Thread
    //===============================================================
    private void ServerCheckPartnerDeathThread()
    {
        try
        {
            while (true)
            {
                Thread.Sleep(5);

                // 상대방 client가 connected에서 갑자기 꺼져 버리면
                // Closed로 바꾸는 방법이 정기적인 검사밖에 없음. 
                // 상황보다 약간 늦게 알게되지만 상관없음.
                if (serverStatus == csConnStatus.Connected)
                {
                    if (clientForServer != null && clientForServer.Client != null)
                    {
                        if (clientForServer.Client.Connected == false)
                            serverStatus = csConnStatus.Closed;
                    }
                }
                if (serverStatus != csConnStatus.Connected) break;
            }
        }
        catch { }
    }
}