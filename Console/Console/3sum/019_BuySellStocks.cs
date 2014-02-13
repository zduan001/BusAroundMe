

namespace console
{
    public class _019_BuySellStocks
    {
        /// <summary>
        /// Say you have an array for which the ith element is the price of a given stock on day i.
        /// If you were only permitted to complete at most one transaction (ie, buy one and sell one share of the stock), design an algorithm to find the maximum profit.
        /// this is a O(n) speed and O(n) space method.
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfileOneTransaction(int[] prices)
        {
            int[] least = new int[prices.Length];
            int[] max = new int[prices.Length];

            int min = int.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    least[i] = i;
                    min = prices[i];
                }
                else
                {
                    least[i] = least[i - 1];
                }
            }

            int maxValue = int.MinValue;
            for (int i = prices.Length - 1; i >= 0; i--)
            {
                if (prices[i] > maxValue)
                {
                    max[i] = i;
                    maxValue = prices[i];
                }
                else
                {
                    max[i] = max[i + 1];
                }
            }

            int maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if ((prices[max[i]] - prices[least[i]]) > maxProfit)
                {
                    maxProfit = prices[max[i]] - prices[least[i]];
                }
            }
            return maxProfit;
        }

        /// <summary>
        /// Same as last method this use O(n^2) time, but O(1) space.
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfitOneTransactionN2(int[] prices)
        {
            int maxProfit = int.MinValue;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if ((prices[j] - prices[i]) > maxProfit)
                    {
                        maxProfit = prices[j] - prices[i];
                    }
                }
            }

            return maxProfit < 0 ? 0 : maxProfit;
        }

        /// <summary>
        /// Say you have an array for which the ith element is the price of a given stock on day i.
        /// Design an algorithm to find the maximum profit. You may complete as many transactions as 
        /// you like (ie, buy one and sell one share of the stock multiple times). However, you may not 
        /// engage in multiple transactions at the same time (ie, you must sell the stock before you buy again).
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfitUnlimitedTransaction(int[] prices)
        {
            int maxProfit = 0;
            bool inTransaction = false;
            int buyIndex = -1;

            for (int i = 0; i < prices.Length - 1; i++)
            {

                if (prices[i + 1] > prices[i] && !inTransaction)
                {
                    buyIndex = i;
                    inTransaction = true;
                }
                if (prices[i + 1] < prices[i] && inTransaction)
                {
                    maxProfit += prices[i] - prices[buyIndex];
                    buyIndex = -1;
                    inTransaction = false;
                }
            }

            if (inTransaction)
            {
                maxProfit += prices[prices.Length - 1] - prices[buyIndex];
                inTransaction = false;
                buyIndex = -1;
            }

            return maxProfit;
        }
    }
}
