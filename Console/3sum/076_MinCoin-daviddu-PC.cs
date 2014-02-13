using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _076_MinCoin
    {
        /*
         Min-Coin Change is the problem of using the minimum number of 
         coins to make change for a particular amount of cents, n, using 
         a given set of denominations . This is closely related to the Coin
         Change problem. 
         */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="coins"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int FindMinCoins(List<int> coins, int value)
        {
            int[] counts = new int[value+1];
            for (int i = 0; i < counts.Length; i++)
            {
                counts[i] = -1;
            }
            for (int i = 1; i <= value; i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < coins.Count; j++)
                {
                    if (i- coins[j] >= 0)
                    {
                        if (i == coins[j])
                        {
                            min = int.MaxValue;
                            counts[i] = 1;
                            break;
                        }
                        if (counts[i - coins[j]] < min)
                        {
                            if (counts[i - coins[j]] != -1)
                            {
                                min = counts[i - coins[j]];
                            }
                        }
                    }
                }
                if (min != int.MaxValue)
                {
                    counts[i] = min + 1;
                }
            }
            return counts[value];
        }
    }
}
