using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookQuestions
{
    public class _005_SortAnArray
    {
        /*
         * http://www.mitbbs.com/article_t/JobHunting/32061183.html
         * Given an array A of positive integers. Convert it to a sorted array with minimum
            cost. The only valid operation are:
            1) Decrement with cost = 1
            2) Delete an element completely from the array with cost = value of element
         * the following code is copied from online, but I still not quite get it yet.
         */
        public int GetMin(int[] input)
        {
            if (input.Length <= 1) return 0;
            int max = 0;
            for (int i = 0; i < input.Length; i++)
            {
                max = Math.Max(max, input[i]);
            }
            int[,] dp = new int[input.Length, max + 1];

            for (int j = 0; j <= max; j++)
            {
                dp[0, j] = Math.Max(0, input[0] - j);
            }
            for (int i = 1; i < dp.Length; i++)
            {
                for (int j = 0; j <= max; j++)
                {
                    if (input[i] >= j)
                    {
                        dp[i, j] = input[i] - j + dp[i - 1, j];
                    }
                    else
                    {
                        dp[i, j] = Math.Min(input[i] + dp[i - 1, j], dp[i - 1, input[i]]);
                    }
                }
            }
            return dp[input.Length - 1, max];
        }
    }
}
