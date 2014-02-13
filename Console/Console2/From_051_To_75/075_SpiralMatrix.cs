using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_051_To_75
{
    public class _075_SpiralMatrix
    {
        /*
        Given a matrix of m x n elements (m rows, n columns), return all elements of the matrix in spiral order.
        For example,
         Given the following matrix: 
        [
         [ 1, 2, 3 ],
         [ 4, 5, 6 ],
         [ 7, 8, 9 ]
        ]
        You should return [1,2,3,6,9,8,7,4,5]. 
         */
        public List<int> PrintOutMatrixSpiral(int[,] input)
        {
            int top = 0;
            int bottom = input.GetLength(1)-1;
            int left = 0;
            int right = input.GetLength(0) - 1;
            List<int> res = new List<int>();
            while (top <= bottom && left <= right)
            {
                for (int j = left; j <= right; j++)
                {
                    res.Add(input[top, j]);
                }
                top ++;
                for ( int i = top; i<= bottom; i++)
                {
                    res.Add(input[i, right]);
                }
                right --;
                for (int j = right; j>=left; j--)
                {
                    res.Add(input[bottom, j]);
                }
                bottom--;
                for(int i = bottom ;i>=top;i--)
                {
                    res.Add(input[i, left]);
                }
                left ++;
            }

            return res;
        }

        /*
         * Given an integer n, generate a square matrix filled with elements from 1 to n2 in spiral order.

         For example,
         Given n = 3, 
        You should return the following matrix: [
         [ 1, 2, 3 ],
         [ 8, 9, 4 ],
         [ 7, 6, 5 ]
        ]

         */
        public int[,] GenerateSpiralMatrix(int n)
        {
            int[,] res = new int[n, n];
            int counter = 1;
            int left = 0;
            int right = n - 1;
            int top = 0;
            int bottom = n - 1;
            while (left <= right && top <= bottom)
            {
                for (int j = left; j <= right; j++)
                {
                    res[top, j] = counter++;
                }
                top++;
                for (int i = top; i <= bottom; i++)
                {
                    res[i, right] = counter++;
                }
                right--;
                for (int j = right; j >= left; j--)
                {
                    res[bottom, j] = counter++;
                }
                bottom--;
                for (int i = bottom; i >= top; i--)
                {
                    res[i, left] = counter++;
                }
                left++;
            }

            return res;
        }
    }
}
