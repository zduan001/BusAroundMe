using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _065_TrappingRainWater
    {
        /// <summary>
        /// Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.
        /// For example, 
        /// Given [0,1,0,2,1,0,1,3,2,1,2,1], return 6.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int TrappingRainWater(int[] input)
        {
            if (input.Length <= 2) return 0;
            int h = 0;
            int total = 0;

            // find the highest bar.
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > input[h])
                {
                    h = i;
                }
            }

            int left = 0;
            for (int i = 1; i < h; i++)
            {
                if (input[i] > input[left])
                    left = i;
                else
                    total += input[left] - input[i];
            }

            int right = input.Length - 1;
            for (int j = right - 1; j > h; j--)
            {
                if (input[j] > input[right])
                    right = j;
                else
                    total += input[right] - input[j];
            }

            return total;
        }
    }
}
