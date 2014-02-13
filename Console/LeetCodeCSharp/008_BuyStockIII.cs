using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _008_BuyStockIII
    {
        /*
         * http://leetcode.com/onlinejudge#question_123
         */
        public int BuyStock(int[] input)
        {
            int maxProfit = 0;
            MaxProfitPoint left = new MaxProfitPoint();
            MaxProfitPoint right = new MaxProfitPoint();
            for (int i = 1; i < input.Length - 1; i++)
            {
                left = FindMaxProfit(input, 0, i);
                right = FindMaxProfit(input, i + 1, input.Length - 1);

                maxProfit = maxProfit > left.profit + right.profit ? maxProfit : left.profit + right.profit;
            }

            return maxProfit;
        }

        public MaxProfitPoint FindMaxProfit(int[] input, int leftIndex, int rightIndex)
        {
            MaxProfitPoint point = new MaxProfitPoint();
            int startIndex = -1;
            int endIndex = -1;

            int i = leftIndex + 1;
            while (i <= rightIndex)
            {
                if (input[i] >= input[i - 1] && startIndex == -1)
                {
                    startIndex = i - 1;
                }
                else if (input[i] < input[i - 1] && startIndex != -1)
                {
                    endIndex = i - 1;
                    if ((input[endIndex] - input[startIndex]) > point.profit)
                    {
                        point.startIndex = startIndex;
                        point.endIndex = endIndex;
                        point.profit = input[endIndex] - input[startIndex];

                    }

                    if (input[i] - input[startIndex] < 0)
                    {
                        startIndex = -1;
                        endIndex = -1;
                    }
                }
                
                i++;
            }

            if (startIndex != -1)
            {
                if (input[rightIndex] - input[startIndex] > point.profit)
                {
                    point.startIndex = startIndex;
                    point.endIndex = rightIndex;
                    point.profit = input[rightIndex] - input[startIndex];
                }
            }

            return point;
        }

        public class MaxProfitPoint
        {
            public int profit = 0;
            public int startIndex =-1;
            public int endIndex = -1;
        }
    }
}
