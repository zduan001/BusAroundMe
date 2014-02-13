using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_051_To_75
{
    public class _071_SearchInRotateArray
    {
        /*
         * Suppose a sorted array is rotated at some pivot unknown to you beforehand.
            (i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).
            You are given a target value to search. If found in the array return its index, otherwise return -1.
            You may assume no duplicate exists in the array.
         */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int SearchRotateArray(int[] input, int value)
        {
            int left = 0;
            int right = input.Length - 1;
            int mid = -1;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (value == input[mid]) return mid;
                if (input[left] <= input[mid])
                {
                    // the break point on the right half
                    if (value < input[mid] && value > input[left])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else
                {
                    // the break on the left half
                    if (value > input[mid] && value < input[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }

            return -1;
        }

        /*
         * Follow up for "Search in Rotated Sorted Array":
         What if duplicates are allowed?
        Would this affect the run-time complexity? How and why?
        Write a function to determine if a given target is in the array.
         */
        /// <summary>
        /// It does affect my first method. the dup element can fill half of the array. e.g [4, 2, 4, 4, 4, 4, 4 ] if I search for 2  it is total covered by
        /// 4s, there is no way I can fingure our which half I should search, because left, mid, and right are all equal.
        /// the actual search has to be done in worst case is O(n). 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int SearchRotateArrayII(int[] input, int value)
        {
            return -1;
        }

    }
}
