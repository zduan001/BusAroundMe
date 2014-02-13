using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class _006_PainterPartition
    {
        /*http://leetcode.com/2011/04/the-painters-partition-problem.html
         * You have to paint N boards of length {A0, A1, A2 … AN-1}. There are K painters available and you are also 
         * given how much time a painter takes to paint 1 unit of board. You have to get this job done as soon as 
         * possible under the constraints that any painter will only paint continuous sections of board, say board {2, 3, 4} 
         * or only board {1} or nothing but not board {2, 4, 5}.
         */
        public int PaintersProblem(int[] input, int k)
        {
            int[,] tracker = new int[k, input.Length];
            tracker[0, 0] = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                tracker[0, i] = tracker[0, i - 1] + input[i];
            }

            for (int i = 1; i < k; i++)
            {
                tracker[i, 0] = input[0];
            }

            for (int i = 1; i < k; i++)
            {
                for (int j = 1; j < input.Length; j++)
                {
                    int tmp = int.MaxValue;
                    for (int m = 1; m <= j; m++)
                    {
                        int max;
                        int last = CalFromTo(input, m, j);
                        max = tracker[i - 1, m-1] > last ? tracker[i - 1, m-1] : last;
                        tmp = tmp < max ? tmp : max;
                    }

                    tracker[i, j] = tmp;
                }
            }

            return tracker[k - 1, input.Length - 1];
        }

        public int CalFromTo(int[] input, int start, int end)
        {
            int res = 0;
            for (int i = start; i <= end; i++)
            {
                res += input[i];
            }

            return res;
        }
    }
}
