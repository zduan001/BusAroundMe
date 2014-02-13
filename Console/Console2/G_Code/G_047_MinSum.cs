using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_047_MinSum
    {
        /*
         * N by N integer矩阵。每一行取一个数, 且取出的每一个数必须不同列。取出N个数使得其sum最小. 求取法。
         */
        /// <summary>
        /// this is like 8 queen problem...
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private int MinSum(int[,] input)
        {
            int[] board = new int[input.GetLength(0)];
            int maxSum = int.MinValue;
            MinSumWorker(input, board, 0, ref maxSum);
            return maxSum;
        }

        private void MinSumWorker(int[,] input, int[] board, int k, ref int maxSum)
        {
            if (k == input.GetLength(0))
            {
                int tmp = 1;
                for (int i = 0; i < board.Length; i++)
                {
                    tmp *= input[i, board[i]];
                }
                maxSum = maxSum > tmp ? maxSum : tmp;
            }
            else
            {
                for (int i = k; i < input.GetLength(0); i++)
                {
                    for (int j = 0; j < input.GetLength(1); j++)
                    {
                        MinSumWorker(input, board, k + 1, ref maxSum);
                    }
                }
            }
        }

        private bool Valide(int[] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    if (board[i] == board[j]) 
                        return false;
                    if(Math.Abs(j-i) == Math.Abs(board[j] - board[i]))
                        return false;
                }
            }
            return true;
        }
    }
}
