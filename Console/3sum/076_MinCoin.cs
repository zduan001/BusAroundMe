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
        public List<int> FindMinCoins(List<int> coins, int value)
        {
            int[] counts = new int[value+1];
            List<int>[] combination = new List<int>[value+1];
            for (int i = 0; i < counts.Length; i++)
            {
                counts[i] = -1;
            }

            for (int i = 1; i <= value; i++)
            {
                int min = int.MaxValue;
                List<int> tmp = null;
                for (int j = 0; j < coins.Count; j++)
                {
                    if (i == coins[j])
                    {
                        min = int.MaxValue;
                        counts[i] = 1;
                        combination[i] = new List<int>() { coins[j] };
                        break;
                    }
                    else
                    {
                        if ((i - coins[j]) >= 0)
                        {
                            if (counts[i - coins[j]] != -1 && counts[i - coins[j]] < min - 1)
                            {
                                min = counts[i - coins[j]] + 1;
                                tmp = new List<int>(combination[i - coins[j]]);
                                tmp.Add(coins[j]);
                            }
                        }
                    }
                }

                if (min != int.MaxValue)
                {
                    counts[i] = min;
                    combination[i] = tmp;
                }
            }
            return combination[value];
        }
    }
}
