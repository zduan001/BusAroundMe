using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_001_To_025
{
    public class _013_DivideTwoNumbers
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dividor"></param>
        /// <param name="divident"></param>
        /// <returns></returns>
        public int DivideTwoNumbers(int dividor, int divident)
        {
            int res = 0;
            bool isNegative = false;
            if (dividor < 0 && divident > 0)
            {
                isNegative = true;
            }

            if (dividor > 0 && divident < 0)
            {
                isNegative = true;
            }

            dividor = Math.Abs(dividor);
            divident = Math.Abs(divident);

            while (dividor > divident)
            {
                dividor = dividor - divident;
                res++;
            }

            return isNegative ? -res : res;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dividor"></param>
        /// <param name="divident"></param>
        /// <returns></returns>
        public int DivideTwoNumberII(int dividor, int divident)
        {
            int res = 0;
            bool isNegative = false;
            if (dividor < 0 && divident > 0)
            {
                isNegative = true;
            }

            if (dividor > 0 && divident < 0)
            {
                isNegative = true;
            }
            dividor = Math.Abs(dividor);
            divident = Math.Abs(divident);

            int multi = 1;
            while (dividor > divident && multi >= 1)
            {
                if (dividor > multi * divident)
                {
                    dividor = dividor - multi * divident;
                    res += multi;
                    multi *= 2;
                }
                else
                {
                    multi /= 2;
                }
            }
            return isNegative ? -res : res;
        }
    }
}
