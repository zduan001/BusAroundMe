using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _041_RemoveDuplicateItemInArray
    {
        /// <summary>
        /// Given a sorted array, remove the duplicates in place such that each element appear only once and return the new length.
        /// Do not allocate extra space for another array, you must do this in place with constant memory.
        /// For example,
        /// Given input array A = [1,1,2],
        /// Your function should return length = 2, and A is now [1,2].
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int[] RemoveDup(int[] input)
        {
            int tail = 0;
            int head = 1;
            while (head < input.Length)
            {
                if (input[tail] != input[head])
                {
                    tail++;
                    input[tail] = input[head];
                    head++;
                }
                else
                {
                    head++;
                }
            }

            for (int i = tail + 1; i < input.Length; i++)
            {
                input[i] = int.MinValue;
            }
            return input;
        }

        /// <summary>
        /// Follow up for "Remove Duplicates":
        /// What if duplicates are allowed at most twice?
        /// For example,
        /// Given sorted array A = [1,1,1,2,2,3],
        /// Your function should return length = 5, and A is now [1,1,2,2,3].
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int[] RemoveDupAllowDup2(int[] input)
        {
            int tail = 0;
            int head = 1;
            bool found = false;
            while (head < input.Length)
            {
                if (input[tail] != input[head])
                {
                    tail++;
                    input[tail] = input[head];
                    head++;
                    found = false;
                }
                else
                {
                    if (found)
                    {
                        head++;
                    }
                    else
                    {
                        tail++;
                        input[tail] = input[head];
                        head++;
                        found = true;
                    }
                }
            }
            for (int i = tail + 1; i < input.Length; i++)
            {
                input[i] = int.MinValue;
            }
            return input;
        }
    }
}
