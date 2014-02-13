using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_026_To_050
{
    /*
    Find the contiguous subarray within an array (containing at least one number) which has the largest sum.
 
    For example, given the array [−2,1,−3,4,−1,2,1,−5,4],
    the contiguous subarray [4,−1,2,1] has the largest sum = 6. 
    */
    public class _050_MaxSubArray
    {
        public int MaxSubArray(int[] input, ref int startIndex, ref int endIndex)
        {
            int max = int.MinValue;
            int maxStartIndex = -1;
            int maxEndIndex = -1;
            int start = -1;
            int end = -1;
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (sum == 0) start = i;
                sum += input[i];
                if (sum > max && sum >0)
                {
                    max = sum;
                    end = i;
                }
                if (sum <0)
                {
                    sum = 0;
                    maxStartIndex = start;
                    maxEndIndex = end;
                    start = -1;
                    end = -1;
                }
            }
            if (end != -1)
            {
                startIndex = start;
                endIndex = end;
            }
            else
            {
                startIndex = maxStartIndex;
                endIndex = maxEndIndex;
            }

            return max;
        }
    }
}
