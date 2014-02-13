using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_001_To_025
{
    public class _004_ClimbStairs_Round2
    {
        /// <summary>
        /// u are climbing a stair case. It takes n steps to reach to the top. 
        /// Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
        /// this is the recursive way. exponential, can discuss it with the interviewer to show you know it is 
        /// expoential.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FindNumOfWayClimbStairs(int n)
        {
            if (n <= 2) return n;
            return FindNumOfWayClimbStairs(n - 1) + FindNumOfWayClimbStairs(n - 2);
        }

        /// <summary>
        /// DP, but used O(n) space.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FindNumOfWayClimbStairDP(int n)
        {
            int[] res = new int[n];

            res[0] = 1;
            res[1] = 2;

            for (int i = 2; i < n; i++)
            {
                res[i] = res[i - 1] + res[i - 2];
            }
            return res[n - 1];
        }

        /// <summary>
        /// Still DP but only use O(1) space.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FindNumOfWayClimbStairDP_O1_Space(int n)
        {
            int[] res = new int[3];
            res[0] = 1;
            res[1] = 2;

            for (int i = 2; i < n; i++)
            {
                res[i % 3] = res[(i - 1) % 3] + res[(i - 2) % 3];
            }
            return res[(n - 1) % 3];
        }
    }
}
