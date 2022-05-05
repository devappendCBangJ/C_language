using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polling
{
    public static class Util
    {
        //===========================================================
        //  시간측정
        //===========================================================     
        public static double TimeInSeconds(DateTime stime)
        {
            TimeSpan dtime = DateTime.Now - stime;
            double dsec = (double)(dtime.Ticks / 10000000.0); // TimeSpan객체명.Ticks ♣
            return dsec;
        }

        //===========================================================
        //  16진수로
        //===========================================================
        public static string Hex(uint ival)
        {
            return String.Format("{0:X}", ival);
        }
        public static string Hex(int ival)
        {
            return String.Format("{0:X}", ival); // String.Format("{~~}", 변수명) ♣
        }
    }
}
