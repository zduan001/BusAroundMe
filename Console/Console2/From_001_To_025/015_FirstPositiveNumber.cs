using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Console2.From_001_To_025
{
    public class _015_FirstPositiveNumber
    {
        /*
         Given an unsorted integer array, find the first missing positive integer.
 
        For example,
        Given [1,2,0] return 3,
        and [3,4,-1,1] return 2.
 
        Your algorithm should run in O(n) time and uses constant space.
        */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int FindFirstPositiveNumber(int[] input)
        {
            BitArray tracker = new BitArray(int.MaxValue);

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 0)
                {
                    tracker[input[i]] = true;
                }
            }

            for (int i = 0; i < tracker.Length; i++)
            {
                if (tracker[i] == false)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
