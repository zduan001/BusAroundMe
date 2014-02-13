using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _015_DivideTwoNumber
    {
        /// <summary>
        /// Divide two integers without using multiplication, division and mod operator. 
        /// </summary>
        /// <param name="dividen"></param>
        /// <param name="dividor"></param>
        /// <returns></returns>
        public int Divide(int dividen, int dividor)
        {
            bool isNegative= false;
            if (dividen <= 0)
            {
                isNegative = true;
                dividen = -dividen;
            }
            if (dividor <= 0)
            {
                isNegative = !isNegative;
                dividor = -dividor;
            }
            
            int res = 0;
            while (dividen > dividor)
            {
                dividen -= dividor;
                res++;
            }
            res = isNegative ? -res : res;
            return res;
        }

        /// <summary>
        /// Divide two integers without using multiplication, division and mod operator. 
        /// </summary>
        /// <param name="dividen"></param>
        /// <param name="dividor"></param>
        /// <returns></returns>
        public int DivideFast(int dividen, int dividor)
        {
            bool isNegative = false;
            if (dividen <= 0)
            {
                isNegative = true;
                dividen = -dividen;
            }
            if (dividor <= 0)
            {
                isNegative = !isNegative;
                dividor = -dividor;
            }

            int res = 0;
            int factor = 1;
            int tmpDividor = dividor;

            while (dividen > dividor)
            {
                if (dividen > tmpDividor)
                {
                    dividen -= tmpDividor;
                    res += factor;
                    factor *= 2;
                    tmpDividor *= 2;

                }
                else
                {
                    tmpDividor /= 2;
                    factor /= 2;
                }
            }
            res = isNegative ? -res : res;
            return res;
        }
    }
}
