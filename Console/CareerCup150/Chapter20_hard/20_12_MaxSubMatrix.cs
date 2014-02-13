using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150
{
    public class Question20_12
    {
        /*
         * Given an NxN matrix of positive and negative integers, write code to find the sub-matrix with the largest possible sum.
         * following is a O(n^4) solution.
         */
        public int FindMax(int[,] input, int n)
        {
            int[,] tracker = new int[n, n];
            tracker[0,0] = input[0,0];
            for (int j = 1; j < n; j++)
            {
                tracker[0, j] = tracker[0, j - 1] + input[0, j];
                tracker[j, 0] = tracker[j - 1, 0] + input[j, 0];
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    tracker[i, j] = tracker[i - 1, j] + tracker[i, j - 1] - tracker[i - 1, j - 1] + input[i, j];
                }
            }

            int res = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int l = i -2; l >=0 ; l--)
                    {
                        for (int m = j -2 ; m >= 0; m--)
                        {
                            int tmp = tracker[i, j] - tracker[l, j] - tracker[i, m] + tracker[l, m];
                            res = res > tmp ? res : tmp;
                        }
                    }

                }
            }
            return res;
        }
    }
}
