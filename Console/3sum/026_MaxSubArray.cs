using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _026_MaxSubArray
    {
        /// <summary>
        /// Find the contiguous subarray within an array (containing at least one number) which has the largest sum.
        /// For example, given the array [−2,1,−3,4,−1,2,1,−5,4],
        /// the contiguous subarray [4,−1,2,1] has the largest sum = 6.
        /// More practice:
        /// If you have figured out the O(n) solution, try coding another solution using the divide and conquer approach, which is more subtle.
        /// </summary>
        /// <param name="input">input integer array</param>
        /// <returns>max sum</returns>
        public int MaxSubArray(int[] input)
        {
            int globalMax = 0;
            int localMax = 0;
            for (int i = 0; i < input.Length; i++)
            {
                localMax += input[i];

                if (localMax < 0) localMax = 0;
                if (localMax > globalMax) globalMax = localMax;
            }
            return globalMax;
        }

        /// <summary>
        /// Same as last method only use recursive.
        /// </summary>
        /// <param name="input">input integer array</param>
        /// <returns>max sum</returns>
        public int MaxSubArrayRecursive(int[] input)
        {
            int res = MaxSubArrayWorker(input, 0, input.Length - 1);
            return res;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        private int MaxSubArrayWorker(int[] input, int left, int right)
        {
            if (left >= right) return input[left];
            int mid = (left + right) / 2;
            int leftSum = MaxSubArrayWorker(input, left, mid);
            int rightSum = MaxSubArrayWorker(input, mid + 1, right);

            int localMax = 0;
            int globalMax = 0;
            int leftIndex = mid;
            int rightIndex = mid+1;
            

            while (leftIndex >= left || rightIndex <= right)
            {
                if(leftIndex >= left) localMax += input[leftIndex];
                if (localMax < 0) localMax = 0;
                if (localMax > globalMax) globalMax = localMax;
                if(rightIndex <= right) localMax += input[rightIndex];
                if (localMax < 0) localMax = 0;
                if (localMax > globalMax) globalMax = localMax;

                leftIndex--;
                rightIndex++;
            }

            return Math.Max(Math.Max(leftSum, rightSum), globalMax);
        }
    }
}
