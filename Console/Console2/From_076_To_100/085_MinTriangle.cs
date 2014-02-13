using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_076_To_100
{
    public class _085_MinTriangle
    {
        /*
         * Given a triangle, find the minimum path sum from top to bottom. Each step you may move to adjacent numbers on the row below.
             For example, given the following triangle
            [
                 [2],
                [3,4],
               [6,5,7],
              [4,1,8,3]
            ]
            The minimum path sum from top to bottom is 11 (i.e., 2 + 3 + 5 + 1 = 11). 
         */
        // from bottom up... that can be the first try,
        // I can see there are a lot repeat calculation and them move to DP or memorization.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int FindMinTriangle(List<List<int>> input)
        {
            List<List<int>> res = new List<List<int>>();
            res.Add(new List<int>(input[0]));
            for (int i = 1; i < input.Count; i++)
            {
                List<int> tmp = new List<int>();
                for (int j = 0; j < input[i].Count; j++)
                {
                    if (j == 0)
                    {
                        int sum = input[i][j] + res[i - 1][0];
                        tmp.Add(sum);
                    }

                    if (j>0 && j < input[i].Count-1)
                    {
                        int left = input[i][j] + res[i - 1][j - 1];
                        int right = input[i][j] + res[i - 1][j];
                        int min = left > right ? right : left;
                        tmp.Add(min);
                    }

                    if (j == input[i].Count - 1)
                    {
                        int sum = input[i][j] + res[i - 1][j - 1];
                        tmp.Add(sum);
                    }
                }
                res.Add(tmp);
            }

            int minSum = int.MaxValue;
            int length = res[res.Count-1].Count;
            for (int i = 0; i < length; i++)
            {
                minSum = minSum > res[res.Count - 1][i] ? res[res.Count - 1][i] : minSum;
            }
            return minSum;

        }
    }
}
