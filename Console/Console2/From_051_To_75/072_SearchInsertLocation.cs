using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_051_To_75
{
    public class _072_SearchInsertLocation
    {
        /*
         Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

        You may assume no duplicates in the array.

         Here are few examples.
         [1,3,5,6], 5 → 2
         [1,3,5,6], 2 → 1
         [1,3,5,6], 7 → 4
         [1,3,5,6], 0 → 0 
        */
        public int SearchInsertIndex(int[] input, int value)
        {
            int left = 0;
            int right = input.Length - 1;
            int mid = -1;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (input[mid] == value) return mid;
                // since I need to check the mid+1 element 
                // that means left and right already moved to the last element
                // and the target element is still on the right side of the mid
                // so I can just break out the while look and take the last 
                // index as the insertiion point.
                if (mid + 1 >= input.Length) break;
                if( input[mid+1] == value ) return mid+1;
                if (input[mid] < value && value < input[mid + 1])
                {
                    return mid + 1;
                }
                else if (value < input[mid])
                {
                    right = mid - 1;
                }
                else if (value > input[mid + 1])
                {
                    left = mid + 2;
                }
            }
            if (right == input.Length - 1) return input.Length;
            if (left == 0) return 0;
            return -1;
        }
    }
}
