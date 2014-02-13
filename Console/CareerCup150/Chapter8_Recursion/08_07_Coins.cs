using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapter8_Recursion
{
    public class _08_07_Coins
    {
        /*
         * Given an infinite number of quarters (25 cents), dimes (10 cents), nickels (5 cents) and pennies (1 cent), 
         * write code to calculate the number of ways of representing n cents.
         */
        public List<List<int>> CoinsCombination(int[] coinsValue, int value)
        {
            List<List<int>> res = new List<List<int>>();
            Worker(value, new List<int>(), coinsValue,0, res);
            return res;
        }

        public void Worker(int targetValue, List<int> currentCoins, int[] coinsValue, int k, List<List<int>> res)
        {
            int currentValue = currentCoins.Sum();
            if (currentValue == targetValue)
            {
                res.Add(new List<int>(currentCoins));
            }
            else
            {
                for (int i = k; i < coinsValue.Length; i++)
                {
                    if (coinsValue[i] <= targetValue - currentValue)
                    {
                        List<int> tmp = new List<int>(currentCoins);
                        tmp.Add(coinsValue[i]);
                        Worker(targetValue, tmp, coinsValue, i, res);
                    }
                }
            }
        }
    }
}
