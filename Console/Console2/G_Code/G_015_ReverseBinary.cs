using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Console2.G_Code
{
    public class G_015_ReverseBinary
    {
        /*
         * 
        Reverse一个字节的所有二进制位，例如01110001->10001110 
        这是一个经典题目。之前准备过，直接写那个最优最经典的

         */
        /// <summary>
        /// Slow O(n).
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int ReverseBinarySlow(int input)
        {
            int res = 0;
            for (int i = 0; i < 32; i++)
            {
                int tmp = input & 1;
                res = res << 1;
                res += tmp;
                input = input >> 1;
            }
            return res;
        }


        public uint ReverseBitsFast(uint input)
        {
            //int i = sizeof(uint);
            //Debug.Assert(sizeof(uint)==4, "sizeof wrong");
            input = ((input & 0x55555555) << 1) | ((input & 0xAAAAAAAA) >> 1); 
            input = ((input & 0x33333333) << 2) | ((input & 0xCCCCCCCC) >> 2); 
            input = ((input & 0x0F0F0F0F) << 4) | ((input & 0xF0F0F0F0) >> 4); 
            input = ((input & 0x00FF00FF) << 8) | ((input & 0xFF00FF00) >> 8); 
            input = ((input & 0x0000FFFF) << 16) | ((input & 0xFFFF0000) >> 16);

            return input;
        }
    }
}
