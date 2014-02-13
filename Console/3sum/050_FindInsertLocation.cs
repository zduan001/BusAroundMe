using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _050_FindInsertLocation
    {
        /// <summary>
        /// Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
        /// You may assume no duplicates in the array.
        /// Here are few examples.
        /// [1,3,5,6], 5 → 2
        /// [1,3,5,6], 2 → 1
        /// [1,3,5,6], 7 → 4
        /// [1,3,5,6], 0 → 0
        /// </summary>
        /// <param name="input"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int FindInsertLocation(int[] input, int value)
        {
            if (value < input[0]) return 0;
            if (value > input[input.Length - 1]) return input.Length;
            
            int start = 0;
            int end = input.Length - 1;
            while (start < end)
            {
                int mid = (start + end) / 2;

                if (input[mid] == value)
                {
                    return mid;
                }
                else if (value < input[mid]) 
                {
                    end = mid-1;
                }else
                {
                    start = mid+1;
                }
            }
            
            return start+1;
        }

        /// <summary>
        /// Recursive. copied from online.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int SearchInsertPosition(int[] A, int target)
        {
            return BSSearchInsertPosision(A, 0, A.Length - 1, target);
        }

        public int BSSearchInsertPosision(int[] A, int start, int end, int target)
        {
            if (start > end)
                return start;

            int mid = start + (end - start) / 2;
            if (A[mid] == target)
                return mid;
            else if (A[mid] < target)
                return BSSearchInsertPosision(A, mid + 1, end, target);
            else
                return BSSearchInsertPosision(A, start, mid - 1, target);
        }
    }
}
