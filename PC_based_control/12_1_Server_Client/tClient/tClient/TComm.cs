using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tClient
{
    static class TComm  // static이므로 객체 생성이 불가능한 class
    {
        //===========================================================
        //  통신에 성공하면 true 리턴
        //===========================================================
        public static bool AskDigitalInput(TClient clientComm, bool[] bits)
        {
            // 수신버퍼 청소 ♣
            string dum = clientComm.GetRcvMsg();

            // 명령 송신
            string st = TSocket.sSTX() + "RI" + TSocket.sETX();
            clientComm.ClientSend(st);

            // 송신시간 기록
            DateTime stime = DateTime.Now;

            // 수신 대기
            int idx1, idx2, indata;
            bool success = false;
            string rbuff = "";
            while (true)
            {
                // timeout 검사
                double dtime = Util.TimeInSeconds(stime);
                if (dtime > 0.5) return false;

                // 수신 버퍼 검사 ♣
                rbuff += clientComm.GetRcvMsg();

                idx1 = rbuff.IndexOf(TSocket.sACK());
                if (idx1 >= 0) // sACK 존재?
                {
                    idx2 = rbuff.IndexOf(TSocket.sETX(), idx1);

                    if (idx1 >= 0 && idx2 - idx1 == 5)              // 다음 통신값 존재?
                    {
                        if (rbuff.Substring(idx1 + 1, 2) == "RI")   // 다음 통신값 처음이 RI?
                        {
                            // 한개의 block 찾음 ♣
                            string dd = rbuff.Substring(idx1 + 3, 2);
                            indata = Convert.ToInt32(dd, 16);       // 16진수를 10진수로 변환 ♣♣♣
                            success = true;
                            break;
                        }
                    }
                }
            }

            // 통신값 제대로 받은 경우 : 배열에 값 저장 + 리턴
            if (success)
            {
                bits[0] = ((indata & 0x1) > 0) ? true : false;
                bits[1] = ((indata & 0x2) > 0) ? true : false;
                bits[2] = ((indata & 0x4) > 0) ? true : false;
                bits[3] = ((indata & 0x8) > 0) ? true : false;
                bits[4] = ((indata & 0x10) > 0) ? true : false;
                bits[5] = ((indata & 0x20) > 0) ? true : false;
                bits[6] = ((indata & 0x40) > 0) ? true : false;
                bits[7] = ((indata & 0x80) > 0) ? true : false;
            }

            return success;
        }
    }
}
