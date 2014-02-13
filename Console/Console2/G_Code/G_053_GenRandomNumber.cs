using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_053_GenRandomNumber
    {
        /*
        Given random generator rand(int n) . Now, design a random generator such as
        rand(int n, int[] except)
        example, n = 10, random 1􀀀10, except[3] = [1; 5; 6], then rand(10, except) output [2; 3; 4; 7; 8; 9; 10]
         */
        /// <summary>
        /// Generate a max
        /// </summary>
        /// <param name="max"></param>
        /// <param name="except"></param>
        /// <returns></returns>
        public int GenRandom(int max, int[] except)
        {
            if (except.Length > max) return -1; // exception length should not be large than max.
            Random ran = new Random();
            int tmp = ran.Next(max- except.Length);
            for (int i = 0; i < except.Length; i++)
            {
                if (tmp < except[i])
                {
                    return tmp;
                }
                else
                {
                    tmp++;
                }
            }

            return tmp;
        }
    }
}
