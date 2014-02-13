using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapter9_SortingSearch
{
    public class _09_03_RotateArray
    {
        /*
         * Given a sorted array of n integers that has been rotated an unknown number of times, 
         * give an O(log n) algorithm that finds an element in the array. You may assume that the array was originally sorted in increasing order.
            EXAMPLE:
            Input: find 5 in array (15 16 19 20 25 1 3 4 5 7 10 14)
            Output: 8 (the index of 5 in the array)

         */

        public int FindInRotateArray(int[] input, int value)
        {
            int left = 0;
            int right = input.Length - 1;
            int mid;
            while (left <= right)
            {
                mid = (left + right)/2;
                if (input[mid] == value) return mid;
                if (input[left] <= input[mid])
                {
                    if (value >= input[left] && value <= input[mid])
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
                    if (value > input[left] || value < input[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }

                }
            }

            return -1;
        }
    }
}
