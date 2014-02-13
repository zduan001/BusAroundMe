using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _004_ClimbStairs
    {
        /// <summary>
        /// You are climbing a stair case. It takes n steps to reach to the top.
        /// each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
        /// </summary>
        /// <param name="n">number of steps</param>
        public int ClimbStairs(int n)
        {
            int[] array = new int[n];
            array[0] = 1;
            array[1] = 1;
            for (int i = 2; i < n; i++)
            {
                array[i] = array[i - 2] + array[i - 1];
            }
            return array[n - 1];
        }

        /// <summary>
        /// Same as last method, only use O(1) space. 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int ClimbStarisWithO1(int n)
        {
            int[] array = new int[3] { 1, 1, 2 };

            for (int i = 3; i < n; i++)
            {
                array[(i)%3] = array[(i-1)%3] + array[(i-2)%3];
            }
            return array[(n-1) % 3];
        }
    }
}
