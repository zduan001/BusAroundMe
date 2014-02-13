using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_026_To_050
{
    /*
    Say you have an array for which the ith element is the price of a given stock on day i.

    If you were only permitted to complete at most one transaction (ie, buy one and sell one share of the stock), design an algorithm to find the maximum profit.

     */
    public class _045_BuyStocks
    {
        /// <summary>
        /// Brutal force. O(n^2)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int MaxProfit(int[] input)
        {
            int maxProfit = int.MinValue;
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    int tmp = input[j] - input[i];
                    maxProfit = maxProfit > tmp ? maxProfit : tmp;
                }
            }
            return maxProfit;
        }

    }

    /*
    Say you have an array for which the ith element is the price of a given stock on day i.

    Design an algorithm to find the maximum profit. You may complete as many transactions as you 
    like (ie, buy one and sell one share of the stock multiple times). However, you may not engage 
    in multiple transactions at the same time (ie, you must sell the stock before you buy again).

     */
    public class _45_BuyStocksII
    {
        /// <summary>
        /// Gready algorithm -- if price go up next day, I buy. If price go down next day
        /// I sell.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int MaxProfitII(int[] input)
        {
            int profit = 0;
            int buyPrice = -1;
            int sellPrice = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i + 1] > input[i] && buyPrice == -1)
                {
                    buyPrice = input[i];
                }
                if (input[i + 1] < input[i] && buyPrice != -1)
                {
                    sellPrice = input[i];
                    profit += (sellPrice - buyPrice);
                    buyPrice = -1;
                    sellPrice = -1;
                }
            }
            if (buyPrice != -1)
            {
                profit += input[input.Length - 1] - buyPrice;
                buyPrice = -1;
                sellPrice = -1;
            }
            return profit;
        }
    }
}
