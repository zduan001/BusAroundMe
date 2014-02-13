using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console.DP
{
    public class _003_CoinsInaLine
    {
        /*
         * There are n coins in a line. (Assume n is even). Two players take turns to take a coin from one of the 
         * ends of the line until there are no more coins left. The player with the larger amount of money wins.
         * 1.Would you rather go first or second? Does it matter?
         * 2.Assume that you go first, describe an algorithm to compute the maximum amount of money you can win.
         */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="coins"></param>
        /// <returns></returns>
        public int CoinsInaLine(int[] coins)
        {
            int[,] res = new int[coins.Length, coins.Length];
            int[,] track = new int[coins.Length, coins.Length];

            for (int i = 0; i < coins.Length; i++)
            {
                res[i, i] = coins[i];
                track[i, i] = i;
            }
            for (int i = 0; i < coins.Length - 1; i++)
            {
                res[i, i + 1] = coins[i + 1] > coins[i] ? coins[i + 1] : coins[i];
                track[i, i + 1] = coins[i + 1] > coins[i] ? i + 1 : i;
            }

            for (int length = 3; length <= coins.Length; length++)
            {
                for (int i = 0; i < coins.Length - length + 1; i++)
                {
                    int j = i + length - 1;
                    int a = coins[i] + Math.Min(res[i + 2, j], res[i + 1, j - 1]);
                    int b = coins[j] + Math.Min(res[i, j - 2], res[i + 1, j - 1]);
                    res[i, j] = Math.Max(a, b);
                    track[i, j] = a > b ? i : j;
                }
            }
            return res[0, coins.Length - 1];
        }
    }
}
