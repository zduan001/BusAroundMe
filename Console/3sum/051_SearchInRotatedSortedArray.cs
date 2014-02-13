using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _051_SearchInRotatedSortedArray
    {
        /// <summary>
        /// Suppose a sorted array is rotated at some pivot unknown to you beforehand.
        /// (i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).
        /// You are given a target value to search. If found in the array return its index, otherwise return -1.
        /// You may assume no duplicate exists in the array.
        /// 1. first ask if I can assume this was an ascending array. assume so.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int SearchinRotatedSortedArray(int[] input, int value)
        {
            int start = 0; 
            int end = input.Length - 1;
            while (start < end)
            {
                int mid = (start + end) / 2;
                if (value == input[mid])
                {
                    return mid;
                }
                else
                {
                    if (value < input[mid])
                    {
                        if (value == input[start])
                        {
                            return start;
                        }
                        else if (value > input[start])
                        {
                            end = mid - 1;
                        }
                        else
                        {
                            start = mid + 1;
                        }
                    }
                    else
                    {
                        if (value == input[end])
                        {
                            return end;
                        }
                        else if (value < input[end])
                        {
                            start = mid + 1;
                        }
                        else
                        {
                            end = mid - 1;
                        }
                    }
                }
            }
            return -1;
        }

        /// <summary>
        /// Follow up for "Search in Rotated Sorted Array":
        /// What if duplicates are allowed?
        /// Would this affect the run-time complexity? How and why?
        /// Write a function to determine if a given target is in the array.
        /// 1. I think the last method should do just fine with dups.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int SearchRotatedSortedArrayWithDup(int[] input, int value)
        {
            return SearchinRotatedSortedArray(input, value);
        }
    }
}
