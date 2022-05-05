using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatArduino
{
    class SPort // 교수님이 만든 클래스
    {
        private static List<byte> rcvbytes = new List<byte>(); // 동적 배열 ♣

        public static char sSTX() { return Convert.ToChar(0x02); }
        public static char sETX() { return Convert.ToChar(0x03); }
        public static char sEOT() { return Convert.ToChar(0x04); }
        public static char sENQ() { return Convert.ToChar(0x05); }
        public static char sACK() { return Convert.ToChar(0x06); }
        public static char sNAK() { return Convert.ToChar(0x15); }
        public static char sCR() { return Convert.ToChar(13); } // 캐리지리턴 아스키코드 ♣
        public static char sLF() { return Convert.ToChar(10); } // 라인피드 아스키코드 ♣
        public static string sCRLF() { return "\r\n"; } // 캐리지리턴 + 라인피드 아스키코드 ♣

        //========================================================
        //  컴퓨터에 존재하는 Port 알아보기 ♣
        //========================================================
        public static string[] GetPortsList()
        {
            List<string> serialportlist = new List<string>();
            serialportlist.Clear(); // 배열 초기화 ♣
            foreach (string comport in SerialPort.GetPortNames()) // foreach문 ♣
            {
                serialportlist.Add(comport); // string에 원소 추가 ♣
            }
            return serialportlist.ToArray(); // string -> 배열 변환 ♣
        }

        //========================================================
        //  Port 열기 ♣
        //========================================================
        public static bool OpenPorts(SerialPort sport, int portnum)
        {
            if (sport.IsOpen) sport.Close();

            //SerialPort 초기설정 - 상대방 기기와 동일화
            sport.PortName = "COM" + portnum.ToString(); // string 형태로 지정 ♣
            sport.BaudRate = 9600;
            sport.DataBits = 8;
            sport.Parity = Parity.None;
            sport.StopBits = StopBits.One;

            // 읽기 설정
            sport.ReceivedBytesThreshold = 1; // 1바이트라도 도착하면 이벤트핸들링함수 구동 ♣

            bool rtn;
            try
            {
                sport.Open();
                rtn = true;
            }
            catch { rtn = false; }

            return rtn;
        }

        //========================================================
        //  Port 닫기 ♣
        //========================================================
        public static void ClosePorts(SerialPort sport)
        {
            if (sport.IsOpen) sport.Close();
        }

        //========================================================
        //  데이터보내기 ♣
        //========================================================
        public static void Send(SerialPort sport, string text)
        {
            sport.Write(text); // string 쓰기
        }
        public static void SendUnicode(SerialPort sport, string text)
        {
            byte[] tmp = Encoding.UTF8.GetBytes(text); // string -> byte array(동적 할당 불가능) -> byte 쓰기
            sport.Write(tmp, 0, tmp.Length);
        }

        //========================================================
        //  데이터읽기 ♣
        //========================================================
        public static string Read(SerialPort sport)
        {
            return sport.ReadExisting(); // string 읽기
        }
        public static string ReadUnicode(SerialPort sport, byte endByte)
        {
            while (true)
            {
                byte inbyte = (byte)sport.ReadByte(); // byte 읽기 -> byte list(동적 할당 가능)
                rcvbytes.Add(inbyte);
                if (inbyte == endByte) break;
            }

            byte[] bytes = rcvbytes.ToArray(); // byte list(동적 할당 가능) -> byte array(동적 할당 불가능)
            rcvbytes.Clear();

            string st = Encoding.UTF8.GetString(bytes); // byte array(동적 할당 불가능) -> string
            return st;
        }
    }
}