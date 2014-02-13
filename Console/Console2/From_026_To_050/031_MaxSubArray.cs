﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_026_To_050
{
    public class _031_MaxSubArray
    {
        /*
        Find the contiguous subarray within an array (containing at least one number) which has the largest sum.
        For example, given the array [−2,1,−3,4,−1,2,1,−5,4],
        the contiguous subarray [4,−1,2,1] has the largest sum = 6.
        More practice:
        If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.
        */
        public int FindMaxSubArray(int[] input)
        {
            int max = int.MinValue;
            int tmp = 0;
            for (int i = 0; i < input.Length; i++)
            {
                tmp += input[i];
                tmp = tmp < 0 ? 0 : tmp;
                max = max > tmp ? max : tmp;
            }
            return max;
        }
    }
}
