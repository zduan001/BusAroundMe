using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_051_To_75
{
    public class _057_RemoveDupFromSortedArray
    {
        /*
         * Given a sorted array, remove the duplicates in place such that each element appear only once and return the new length.

            Do not allocate extra space for another array, you must do this in place with constant memory.
 
        For example,
            Given input array A = [1,1,2], 

        Your function should return length = 2, and A is now [1,2]. 

         */
        /// <summary>
        /// No "Ji shu han liang" just make sure bug free.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int RemoveDup(int[] input)
        {
            int tail = 0;
            int runner = 1;
            while (runner < input.Length)
            {
                if (input[tail] == input[runner])
                {
                    runner++;
                }
                else
                {
                    input[tail + 1] = input[runner];
                    tail++;
                    runner++;
                }
            }
            return tail;
        }

        /*
         * Follow up for "Remove Duplicates":
         What if duplicates are allowed at most twice?

         For example,
         Given sorted array A = [1,1,1,2,2,3], 

        Your function should return length = 5, and A is now [1,1,2,2,3]. 

         */
        /// <summary>
        /// Bug free !!!!
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int RemoveDupII(int[] input)
        {
            // check for corner cases.
            int tail = 0;
            int runner = 0;
            bool dupExist = false;
            while (runner < input.Length)
            {

                if (input[tail] != input[runner] || !dupExist)
                {
                    input[tail + 1] = input[runner];
                    tail++;
                    runner++;
                    if (tail - 1 >= 0 && input[tail] == input[tail - 1])
                    {
                        dupExist = true;
                    }
                    else
                    {
                        dupExist = false;
                    }
                }
                else 
                {
                    runner++;
                }
            }
            return tail;
        }
    }
}
