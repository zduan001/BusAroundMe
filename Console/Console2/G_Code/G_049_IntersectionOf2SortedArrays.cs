using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_049_IntersectionOf2SortedArrays
    {
        /*
         * Given two sorted array, return the intersection part. follow-up: test cases ?
         */
        /// <summary>
        /// hash table is a O(m+n) way with O(n) or O(m) space. 
        /// but since this sorted array, I can save the space. 
        /// by interate throgh the input1 and input2 in the following way.
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <returns></returns>
        public int[] findIntersection(int[] input1, int[] input2)
        {
            List<int> res = new List<int>();
            int i = 0; int j = 0;
            while (i < input1.Length && j < input2.Length)
            {
                if (input1[i] > input2[j])
                {
                    j++;
                }
                else if (input1[i] < input2[j])
                {
                    i++;
                }
                else
                {
                    res.Add(input1[i]);
                    i++;
                    j++;
                }
            }

            return res.ToArray();

        }
    }
}
