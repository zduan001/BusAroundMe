using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _028_FindKthElement
    {

        /// <summary>
        /// Find the Kth element of an un sorted integer array.
        /// </summary>
        /// <param name="input">the array</param>
        /// <returns>the kth element</returns>
        public int FindKthElement(int[] input, int k)
        {
            if (input == null ||input.Length < k) return -1;
            return FindKthElement(input, 0, input.Length-1,k);
        }

        /// <summary>
        /// Worker method of find keht element.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public int FindKthElement(int[] input, int start, int end, int k)
        {
            int tmp = start;
            int left = start;
            int right = end;

            while (start < end)
            {
                while (start < end && input[start] <= input[tmp]) start++;
                while (start < end && input[end] >= input[tmp]) end--;
                Swap(input, start, end);
                start++;
                end--;
            }

            if (end+1 == k) return input[tmp];
            else
            {
                Swap(input, tmp, end);
                if (end > k)
                {
                    return FindKthElement(input, left, end-1, k);
                }
                else
                {
                    return FindKthElement(input, end + 1, right, k);
                }
            }
        }

        /// <summary>
        /// swap 2 elements in a int array.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        public void Swap(int[] input, int index1, int index2)
        {
            int tmp = input[index1];
            input[index1] = input[index2];
            input[index2] = tmp;
        }
    }
}
