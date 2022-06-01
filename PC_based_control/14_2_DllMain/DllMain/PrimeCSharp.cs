using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllMain
{
    class PrimeCSharp
    {
        private static bool isPrimeNumber(int num)  // num이 소수인가?
        {
            bool isprime = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isprime = false;
                    break;
                }
            }
            return isprime;
        }

        public static void FindNumberOfPrimeNumber(int nMax, out int nprime)    // nMax까지 소수 개수?
        {
            nprime = 0;
            for (int i = 2; i <= nMax; i++)
            {
                bool isprime = isPrimeNumber(i);
                if (isprime) nprime++;
            }
        }
    }
}
