using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitWise
{
    public class BitWise
    {
        /*http://www.mitbbs.com/article_t/JobHunting/32369933.html
         * 	1. 数组只有1-10000，然后size是10001，怎么找到重复的那个
         */
        public int FindDup(int[] input)
        {
            int res = 0;
            for (int i = 0; i < input.Length; i++)
            {
                res ^= i;
                res ^= input[i];
            }
            return res;
        }

        /// <summary>
        /*
         * we can observe that we basically need to right shift (>>) all even bits (In the above example, even bits of 23 are highlighted) by 1 so that they become odd bits (highlighted in 43), and left shift (<<) all odd bits by 1 so that they become even bits. The following solution is based on this observation. The solution assumes that input number is stored using 32 bits.

            Let the input number be x
             1) Get all even bits of x by doing bitwise and of x with 0xAAAAAAAA. The number 0xAAAAAAAA is a 32 bit number with all even bits set as 1 and all odd bits as 0.
             2) Get all odd bits of x by doing bitwise and of x with 0x55555555. The number 0x55555555 is a 32 bit number with all odd bits set as 1 and all even bits as 0.
             3) Right shift all even bits.
             4) Left shift all odd bits.
             5) Combine new even and odd bits and return.

         */
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public uint SwapOddEven(uint input)
        {
            uint even = input & 0XAAAAAAAA;
            uint odd = input & 0X55555555;

            even = even >> 1;
            odd = odd << 1;

            return even | odd;
        }
    }
}
