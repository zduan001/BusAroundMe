using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_001_To_025
{
    public class _023_JumpGame
    {
        /*
        Given an array of non-negative integers, you are initially positioned at the first index of the array.
        Each element in the array represents your maximum jump length at that position.
        Determine if you are able to reach the last index.
        For example:
        A = [2,3,1,1,4], return true.
        A = [3,2,1,0,4], return false.
        */
        // Should I look for all the "0" in the array, and back track to see if can jump over the "0"
        public bool JumpGame(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 0)
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (input[j] < i - j) break;
                        if (j == 0) return false;
                    }
                }
            }
            return true;
        }

        /*
        Given an array of non-negative integers, you are initially positioned at the first index of the array.
        Each element in the array represents your maximum jump length at that position.
        Your goal is to reach the last index in the minimum number of jumps.
 
        For example:
        Given array A = [2,3,1,1,4]
 
        The minimum number of jumps to reach the last index is 2. (Jump 1 step from index 0 to 1, then 3 steps to the last index.)

        */
        /// <summary>
        /// DP?
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int JumpGame2(int[] input)
        {
            int[] dp = new int[input.Length];
            for (int i = 1; i < input.Length; i++)
            {
                int minStep = int.MaxValue;
                int k = i - 1;
                while (k >= 0)
                {
                    if (input[k] >= i - k)
                    {
                        minStep = minStep < dp[k] + 1 ? minStep : dp[k] + 1;
                    }
                    k--;
                }
                dp[i] = minStep;
            }
            return dp[dp.Length - 1];
        }
    }
}
