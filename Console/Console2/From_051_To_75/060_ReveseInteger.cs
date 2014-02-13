using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_051_To_75
{
    public class _060_ReveseInteger
    {
        /*
         * Reverse digits of an integer.

         Example1: x = 123, return 321
         Example2: x = -123, return -321 
         */
        /// <summary>
        /// here I used a recursive call to the last highest digit of the x and 
        /// move back up, and reconstruct the integer, 
        /// this method is kind of elegent. 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int ReverseInteger(int x)
        {
            bool negative = false;
            if (x < 0) 
            {
                negative = true;
                x = -x;
            }
            int y = 0;
            Worker(x, ref y);
            if (negative)
            {
                y = -y;
            }
            return y;
        }


        public int Worker(int x, ref int y)
        {
            if (x == 0) return 0;
            int i = Worker(x / 10, ref y);
            y = y + (int)((x % 10) * Math.Pow(10, i));
       
            return i + 1;
        }
    }
}
