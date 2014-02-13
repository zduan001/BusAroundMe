using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapter8_Recursion
{
    public class _08_08_EightQueen
    {
        /*
         * Write an algorithm to print all ways of arranging eight queens on a chess board so that none of 
         * them share the same row, column or diagonal.
         */
        public List<int[]> EightQueens(int n)
        {
            int[] inprogress = new int[n];
            List<int[]> res = new List<int[]>();
            Worker(n, 0, inprogress, res);

            return res;
        }

        public void Worker(int n, int k, int[] current, List<int[]> res)
        {
            if (n == k)
            {
                if (Check(current))
                {
                    int[] tmp = new int[n];
                    current.CopyTo(tmp, 0);
                    res.Add(tmp);
                }
                return;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    current[k] = i;
                    Worker(n, k + 1, current, res);
                }
            }
        }

        public bool Check(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int diff = Math.Abs(input[j] - input[i]);
                    if (diff == 0 || diff == (i - j))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
