using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _042_RemoveElement
    {
        /// <summary>
        /// Given an array and a value, remove all instances of that value in place and return the new length.
        /// The order of elements can be changed. It doesn't matter what you leave beyond the new length.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public int RemoveElement(int[] input, int key)
        {
            int tail = 0;
            if (input == null) return 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != key)
                {
                    input[tail] = input[i];
                    tail++;
                }
            }

            return tail;
        }

        /* Bug Free, Bug Free man*/
    }
}
