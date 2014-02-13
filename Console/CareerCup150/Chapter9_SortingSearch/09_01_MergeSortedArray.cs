using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapter9_SortingSearch
{
    public class _09_01_MergeSortedArray
    {
        /*
         * You are given two sorted arrays, A and B, and A has a large enough buffer 
         * at the end to hold B. Write a method to merge B into A in sorted order.
         */
        /// <summary>
        /// a1 is longer array. 
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public void Merge2Array(int[] a1, int[] a2, int a1length)
        {
            int i = a1length-1;
            int j = a2.Length - 1;

            int end = a1.Length-1;
            int tmp = 0;
            while (i != -1 && j != -1)
            {

                if (a1[i] >= a2[j])
                {
                    tmp = a1[i];
                    i--;
                }
                else
                {
                    tmp = a2[j];
                    j--;
                }
                a1[end] = tmp;
                end--;
            }

            if (i == -1)
            {
                while(j != -1)
                {
                    a1[end--] = a2[j--];
                }
            }
            else if (j == -1)
            {
                while (i != -1)
                {
                    a1[end--] = a1[i--];
                }
            }
            for (int k = 0; k <= end; k++)
            {
                a1[k] = -1;
            }
            return;
        }
    }
}
