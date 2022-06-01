using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DllMain
{
    static class dllPrime       // dll의 함수 import ♣
    {
        [DllImport("PrimeDLL.dll",
                             CallingConvention = CallingConvention.Cdecl)]
        public static extern void dllFindNumberOfPrimeNumber(int nMax, ref int nprime); // cpp에서 포인터 사용하므로 ref 인수 사용 ♣
    }
}
