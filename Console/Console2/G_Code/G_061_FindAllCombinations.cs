using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_061_FindAllCombinations
    {
        /*
         * 一个矩阵，比如m  n，从一个点可以访问它的八个相邻点（上、下、左、右、左上、左下、
            右上、右下）
            如果一个方向上的点已经被访问过了，则可以继续访问这个方向上的下一个未被访问的点（比如当前点
            是(5,5)，如果（5,4）已经被访问，则可以访问(5,3)，如果(5,3)也被访问了，则可以访问（5,2）. . . . . .
            对角线方向的也是如此,(5,5)可以访问(4,4)，如果(4,4)已经被访问，可以访问(3,3). . . . . .）
            现在需要遍历这个矩阵上的所有点，则有多少种可能性？（起点和终点不限）
         */

        public int FindAllCombination(int n, int m)
        {
            bool[,] tracker = new bool[n, m];
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    FindAllCombination(tracker, ref res, i, j);
                }
            }
            return res;
        }

        public void FindAllCombination(bool[,] tracker, ref int count, int i, int j)
        {
            int n = tracker.GetLength(0);
            int m = tracker.GetLength(1);

            // if out of boundary return.
            if (i < 0 || i >= n || j < 0 || j >= m)
            {
                return;
            }

            //visisted
            if (tracker[i, j]) return;

            // Visit this node 
            tracker[i, j] = true;

            // check if all node are visited.
            bool allVisiated = true;
            for (int k = 0; k < n; k++)
            {
                for (int l = 0; l < m; l++)
                {
                    if (!tracker[k, l])
                    {
                        allVisiated = false;
                        break;
                    }
                }
                if (!allVisiated)
                {
                    break;
                }
            }
            if (allVisiated)
            {
                count++;
                tracker[i, j] = false;
                return;
            }

            FindAllCombination(tracker, ref count, i - 1, j);
            FindAllCombination(tracker, ref count, i + 1, j);
            FindAllCombination(tracker, ref count, i, j - 1);
            FindAllCombination(tracker, ref count, i, j + 1);
            FindAllCombination(tracker, ref count, i - 1, j - 1);
            FindAllCombination(tracker, ref count, i - 1, j + 1);
            FindAllCombination(tracker, ref count, i + 1, j - 1);
            FindAllCombination(tracker, ref count, i + 1, j + 1);
            tracker[i, j] = false;
        }
    }
}
