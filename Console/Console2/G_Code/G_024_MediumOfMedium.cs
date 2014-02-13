using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    class G_024_MediumOfMedium
    {
        /*
         * .Given P machines, each containing an array of N elements, find the medium 
            of the array resulted by concatenating all the arrays on the machines. You 
            cannot move data across machines.
         * http://www.mitbbs.com/article_t/JobHunting/32068175.html
         */
        /// <summary>
        /// if P is too big, we can separate medians into smaller group and call Medians of Meidans again.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int MedianOfMedian(List<int[]> input)
        {
            foreach (int[] array in input)
            {
                Array.Sort(array);
            }
            int[] medians = new int[input.Count];
            for (int i = 0; i < medians.Length; i++)
            {
                medians[i] = input[i][input[i].Length / 2];
            }
            return medians[medians.Length / 2];
        }
    }
}
