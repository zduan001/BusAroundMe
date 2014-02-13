using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_026_To_050
{
    /*
    Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right which minimizes the sum of all numbers along its path.
    Note: You can only move either down or right at any point in time.
    */
    // this question must can be done in 1. recursive 2. DP.
    // Additional though, what if can move to 8 directions?
    public class _036_MinSumPath
    {
        /// <summary>
        /// this method use recursive.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int FindMinSumPathRecursive(int[,] input)
        {
            int res = FindMinSumPathWorker(input, input.GetLength(0) - 1, input.GetLength(1) - 1);
            return res;
        }

        public int FindMinSumPathWorker(int[,] input, int i, int j)
        {
            if (i == 0 && j == 0)
            {
                return input[0, 0];
            }

            int value1 = i - 1 >= 0 ? FindMinSumPathWorker(input, i - 1, j) : -1;
            int value2 = j - 1 >= 0 ? FindMinSumPathWorker(input, i, j - 1) : -1;
            if (value1 > 0 && value2 > 0)
            {
                return Math.Min(value1, value2) + input[i, j];
            }
            else if (value1 < 0 && value2 < 0)
            {
                return -1;
            }
            else
            {
                return Math.Max(value1, value2) + input[i, j];
            }
        }


        public int FindMinSumPathDP(int[,] input)
        {
            return 0;
        }
 
    }
}
