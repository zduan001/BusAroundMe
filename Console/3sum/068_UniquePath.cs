using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _068_UniquePath
    {
        /// <summary>
        /// M*N grids from top-left to bottom-right find all the paths.
        /// 
        /// DP, what is selling point of this question?
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int UniquePaths(int m, int n)
        {
            int[,] array = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                array[i, 0] = 1;
            }
            for (int j = 0; j < n; j++)
            {
                array[0, j] = 1;
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    array[i, j] = array[i - 1, j] + array[i, j - 1];
                }
            }
            return array[m-1,n-1];
        }

        /// <summary>
        /// Follow up for "Unique Paths":
        /// Now consider if some obstacles are added to the grids. How many unique paths would there be?
        /// An obstacle and empty space is marked as 1 and 0 respectively in the grid.
        /// For example,
        /// There is one obstacle in the middle of a 3x3 grid as illustrated below.
        /// [
        /// [0,0,0],
        /// [0,1,0],
        /// [0,0,0]
        /// ]
        /// The total number of unique paths is 2.
        /// Note: m and n will be at most 100.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public int UniquePathsII(int m, int n, int k, int l)
        {
            int[,] array = new int[m, n];
            array[k, l] = -1;

            if(array[0,0] != -1)
            {
                array[0,0] =1;
            }

            for (int i = 1; i < m; i++)
            {
                if(array[i,0] == -1) continue;
                if (array[i - 1, 0] != -1)
                {
                    array[i, 0] = array[i - 1, 0];
                }
                else
                {
                    array[i, 0] = 0;
                }
            }
            for (int j = 1; j < n; j++)
            {
                if (array[0, j] == -1) continue;
                if (array[0, j - 1] != -1)
                {
                    array[0, j] = array[0, j - 1];
                }
                else
                {
                    array[0, j] = 0;
                }
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (array[i, j] == -1) continue;
                    int top = array[i - 1, j] == -1 ? 0 : array[i - 1, j];
                    int left = array[i, j - 1] == -1 ? 0 : array[i, j - 1];
                    array[i, j] = top + left;
                }
            }
            return array[m - 1, n - 1];
        }
    }
}
