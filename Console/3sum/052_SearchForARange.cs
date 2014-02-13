using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _052_SearchForARange
    {
        /// <summary>
        /// Given a sorted array of integers, find the starting and ending position of a given target value.
        /// Your algorithm's runtime complexity must be in the order of O(log n).
        /// If the target is not found in the array, return [-1, -1].
        /// For example,
        /// Given [5, 7, 7, 8, 8, 10] and target value 8,
        /// return [3, 4].
        /// </summary>
        /// <param name="input"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<int> SearchForARange(int[] input, int value)
        {
            int start = 0;
            int end = input.Length - 1;
            int mid = -1;
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (value == input[mid])
                {
                    break;
                }
                else if (value < input[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            if (mid == -1) return null; // no found;
            // Following part is not O(lg n). So comments them out.
            //int left = mid;
            //while (left-1 >= 0 && input[left-1] == value)
            //{
            //    left--;
            //}

            //int right = mid;
            //while (right+1 < input.Length && input[right+1] == value)
            //{
            //    right++;
            //}

            //return new List<int>(){left, right};

            int leftStart = start;
            int leftEnd = mid;
            int leftMid = mid;
            while (leftStart <= leftEnd)
            {
                leftMid = (leftStart + leftEnd) / 2;
                if (value > input[leftMid])
                {
                    leftStart = leftMid + 1;
                }
                else
                {
                    leftEnd = leftMid-1;
                }
            }
            if (input[leftMid] < value) leftMid++;

            int rightStart = mid;
            int rightEnd = end;
            int rightMid = mid;
            while (rightStart <= rightEnd)
            {
                rightMid = (rightStart + rightEnd) / 2;
                if (value < input[rightMid])
                {
                    rightEnd = rightMid - 1;
                }
                else
                {
                    rightStart = rightMid+1;
                }
            }
            if (input[rightMid] > value) rightMid--;

            return new List<int>() { leftMid, rightMid };
        }
    }
}
