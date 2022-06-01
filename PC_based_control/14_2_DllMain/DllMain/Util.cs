using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllMain
{
    static class Util
    {
        //=================================================================
        //  시간 측정
        //=================================================================
        public static double TimeInSeconds(DateTime stime)      // 시간 측정 ♣
        {
            TimeSpan dtime = DateTime.Now - stime;
            double dsec = (double)(dtime.Ticks / 10000000.0);
            return dsec;
        }
    }
}
