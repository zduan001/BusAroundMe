using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_051_To_75
{
    public class _070_SearchARange
    {
        /*
        Given a sorted array of integers, find the starting and ending position of a given target value.
        Your algorithm's runtime complexity must be in the order of O(log n).
        If the target is not found in the array, return [-1, -1].
         For example,
         Given [5, 7, 7, 8, 8, 10] and target value 8,
         return [3, 4]. 
         */
        /// <summary>
        /// nothing fancy, just be carefull, first binary search find the element, then 
        /// binary search for the left edge and binary search for the right edge.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="value"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public void FindRange(int[] input, int value, ref int start, ref int end)
        {
            int left = 0;
            int right = input.Length - 1;
            int mid = -1;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (value == input[mid])
                {
                    break;
                }
                else if (value < input[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            int tmpmid = mid;
            int leftMid = -1;
            while (left <= tmpmid)
            {
                leftMid = (left + tmpmid) / 2;
                if (value == input[leftMid])
                {
                    if (leftMid == 0)
                    {
                        start = 0;
                        break;
                    }
                    if (value > input[leftMid - 1])
                    {
                        start = leftMid;
                        break;
                    }
                    else
                    {
                        tmpmid = leftMid - 1;
                    }

                }
                else
                {
                    left = leftMid + 1;
                }
                
            }

            tmpmid = mid;
            int rightMid = -1;
            while (tmpmid <= right)
            {
                rightMid = (tmpmid + right) / 2;
                if (value == input[rightMid])
                {
                    if (rightMid == input.Length - 1)
                    {
                        end = rightMid;
                        break;
                    }
                    if (value < input[rightMid + 1])
                    {
                        end = rightMid;
                        break;
                    }
                    else
                    {
                        tmpmid = rightMid + 1;
                    }
                }
                else
                {
                    tmpmid = rightMid + 1;
                }
            }
        }
    }
}
