using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _053_Search2DMatrix
    {
        /// <summary>
        /// Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:
        /// Integers in each row are sorted from left to right.
        /// The first integer of each row is greater than the last integer of the previous row.
        /// For example,
        /// Consider the following matrix:
        /// [ 
        /// [1, 3, 5, 7], 
        /// [10, 11, 16, 20], 
        /// [23, 30, 34, 50]
        /// ]
        /// Given target = 3, return true.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Search2DMatrix(List<List<int>> input, int value)
        {
            int start = 0;
            int end = input.Count - 1;
            int mid = -1;
            while (start < end)
            {
                mid = (start + end) / 2;
                if (value == input[mid][0])
                {
                    return true;
                }
                else if (value > input[mid][input[mid].Count-1])
                {
                    start = mid+1;
                }
                else if (value < input[mid][0])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid;
                    end = mid;
                }

                if (start == end)
                {
                    int startIndex = 0; int endIndex = input[start].Count - 1;
                    while (startIndex <= endIndex)
                    {
                        int midIndex = (startIndex + endIndex) / 2;
                        if (value == input[start][midIndex])
                        {
                            return true;
                        }
                        else if (value < input[start][midIndex])
                        {
                            endIndex = midIndex - 1;
                        }
                        else
                        {
                            startIndex = midIndex + 1;
                        }
                    }
                }
            }
            return false;
        }
    }
}
