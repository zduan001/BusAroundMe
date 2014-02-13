using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_051_To_75
{
    public class _069_Search2DArray
    {
        /*
        Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:
        Integers in each row are sorted from left to right.
        The first integer of each row is greater than the last integer of the previous row.
        For example,
        Consider the following matrix:
 
        [
         [1, 3, 5, 7],
         [10, 11, 16, 20],
         [23, 30, 34, 50]
        ]
        Given target = 3, return true.
         */
        public bool Search(int[,] input, int value, int n)
        {
            int top = 0;
            int bottom = n - 1;
            int row = -1;
            while (top <= bottom)
            {
                int mid = (top + bottom) / 2;
                if(value >= input[mid,0] && value<= input[mid,n-1])
                {
                    row = mid;
                    break;
                }
                else if (value < input[mid, 0])
                {
                    bottom = mid - 1;
                }
                else
                {
                    top = mid + 1;
                }
            }
            if (row == -1) return false;

            top = 0;
            bottom = n - 1;
            while (top < bottom)
            {
                int mid = (top + bottom) / 2;
                if (value == input[row, mid]) return true;
                else if (value < input[row, mid]) bottom = mid - 1;
                else top = mid + 1;
            }
            return false;
        }
    }
}
