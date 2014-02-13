using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _031_AllCombinationCoins
    {

        public List<string> res = new List<string>();
        /// <summary>
        /// Given a change amount, print all possible combinations using different sets of coins
        /// </summary>
        /// <param name="coins"></param>
        /// <param name="total"></param>
        public List<string> FindAllCombinationCoins(int[] coins, int total)
        {
            res.Clear();
            int[] counts = new int[coins.Length];
            FindAllCombinationCoins(coins, counts, 0, total);
            return res;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="coins"></param>
        /// <param name="counts"></param>
        /// <param name="startIndex"></param>
        /// <param name="remain"></param>
        public void FindAllCombinationCoins(int[] coins, int[] counts, int startIndex, int remain)
        {
            if (startIndex >= coins.Length && remain == 0)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < coins.Length; i++)
                {
                    sb.Append(coins[i].ToString() + " * " + counts[i].ToString());
                    sb.Append(" + ");
                }
                res.Add(sb.ToString());
                return;
            }


            if (startIndex == coins.Length - 1)
            {
                if (remain % coins[startIndex] == 0)
                {
                    counts[startIndex] = remain / coins[startIndex];
                    remain = remain - counts[startIndex] * coins[startIndex];
                    FindAllCombinationCoins(coins, counts, startIndex + 1, remain);
                }
            }
            else
            {
                for (int i = 0; i <= remain / coins[startIndex]; i++)
                {
                    counts[startIndex] = i;
                    FindAllCombinationCoins(coins, counts, startIndex + 1, remain - coins[startIndex] * i);
                }
            }
        }
    }
}
