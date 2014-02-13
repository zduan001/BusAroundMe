using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _077_MaxSubMatrix
    {
        /*
         * Given a 2D matrix fill with 0's and 1's, find the largest rectangle containing all ones and return its area.
         */
        /// <summary>
        /// this is a O(n^4) method. 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int FindMaxSubMatrix(int[,] input)
        {
            int maxArea = 0;
            int n = input.GetLength(0);
            int m = input.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int lastl = m;
                    for (int k = i; k < n && input[k, j] == 1; k++)
                    {
                        for (int l = j; l < lastl; l++)
                        {
                            if (input[k, l] == 1)
                            {
                                int area = (k - i + 1) * (l - j + 1);
                                maxArea = maxArea > area ? maxArea : area;
                            }
                            else
                            {
                                lastl = l;
                            }
                        }
                    }
                }
            }
            return maxArea;
        }

        /*
         * 代码分析：
　　      利用DP，第一次n^2循环,先预处理。然后再O(n^3)计算最大面积。
　　      例如：
            1 1 0 1
            1 0 1 1
            1 1 1 1
            0 0 1 1
　　      DP处理后生成新的2D- array
            1 2 0 1
            1 0 1 2
            1 2 3 4
            0 0 1 2
　　      每个格子相应的最大面积
            1 2 0 1 
            2 0 1 2   
            3 2 3 4          
            0 0 3 6          
         */
        /// <summary>
        /// this is DP method.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int FindMaxSubMatrixDP(int[,] input)
        {
            int maxArea = 0;
            int n = input.GetLength(0);
            int m = input.GetLength(1);
            int[,] dp = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (input[i, j] == 1)
                    {
                        if (j >= 1)
                        {
                            dp[i, j] = dp[i, j - 1] + 1;
                        }
                        else
                        {
                            input[i, j] = 1;
                        }
                    }
                    else
                    {
                        dp[i, j] = 0;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int k = i;
                    int min = dp[i, j];
                    while (k>-1 && dp[k, j] > 0)
                    {
                        min = min < dp[k, j] ? min : dp[k, j];
                        maxArea = maxArea > min * (i - k + 1) ? maxArea : min * (i - k + 1);
                        k--;
                    }
                }
            }
            return maxArea;
        }
    }
}
