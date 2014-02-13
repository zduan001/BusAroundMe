using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_1_15_Histogram
    {
        /*
         * Write a static method histogram() that takes an array a[] of int values and an integer M 
         * as arguments and returns an array of length M whose ith entry is the number of times the 
         * integer i appeared in the argument array. If the values in a[] are all between 0 and M–1 , 
         * the sum of the values in the returned array should be equal to a.length 
         */
        public int[] Histogram(int[] input, int m)
        {
            int[] res = new int[m];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < m)
                {
                    res[input[i]]++;
                }
            }
            return res;
        }
    }
}
