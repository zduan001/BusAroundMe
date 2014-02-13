using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_1_14_Lg
    {
        /*
         * Write a static method lg() that takes an int value N as argument and returns the largest int not larger than the base-2 logarithm of N . Do not use Math .
         */
        // I used divide because I do not want to use times method which may cause overflow at the last step.
        public int FindLg(int input)
        {
            int i = input;
            int res = 0;
            while (i > 0)
            {
                i /= 2;
                res++;
            }

            return res-1; // if input is 0, there is no valid res. reutnr -1 is fine.
        }

    }
}
