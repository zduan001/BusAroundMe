using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConque
{
    public class MedianOf2Array
    {
        /*http://www.geeksforgeeks.org/median-of-two-sorted-arrays/
         * Question: There are 2 sorted arrays A and B of size n each. 
         * Write an algorithm to find the median of the array obtained 
         * after merging the above 2 arrays(i.e. array of length 2n). 
         * The complexity should be O(log(n))
         * 
         *  1) Calculate the medians m1 and m2 of the input arrays ar1[] 
               and ar2[] respectively.
            2) If m1 and m2 both are equal then we are done.
                 return m1 (or m2)
            3) If m1 is greater than m2, then median is present in one 
               of the below two subarrays.
                a)  From first element of ar1 to m1 (ar1[0...|_n/2_|])
                b)  From m2 to last element of ar2  (ar2[|_n/2_|...n-1])
            4) If m2 is greater than m1, then median is present in one    
               of the below two subarrays.
               a)  From m1 to last element of ar1  (ar1[|_n/2_|...n-1])
               b)  From first element of ar2 to m2 (ar2[0...|_n/2_|])
            5) Repeat the above process until size of both the subarrays 
               becomes 2.
            6) If size of the two arrays is 2 then use below formula to get 
              the median.
                Median = (max(ar1[0], ar2[0]) + min(ar1[1], ar2[1]))/2
         * the previous method is good for both array are same size.

         */
        public int FindMedian(int[] a, int[] b)
        {
            return FindKth(a, b, (a.Length + b.Length) / 2);
        }

        private int FindKth(int[] a, int[] b, int k)
        {
            int n = a.Length;
            int m = b.Length;

            int i = a.Length * k / (a.Length + b.Length);
            int j = k - i - 1;
            int ai = a[i];
            int ai_1 = (i - 1) >= 0 ? a[i - 1] : 0;
            int bj = b[j];
            int bj_1 = (j - 1) >= 0 ? b[j - 1] : 0;

            if (ai >= bj_1 && ai <= bj)
                return ai;
            else if (bj >= ai_1 && bj <= ai)
                return bj;

            if (ai < bj)
            {
                return FindKth(trimArray(a, i), b, k - i - 1);
            }
            else
            {
                return FindKth(a, trimArray(b, j), k - j - 1);
            }
        }

        private int[] trimArray(int[] input, int i)
        {
            int[] res = new int[input.Length - i];
            for (int k = i + 1; k < input.Length; k++)
            {
                res[k - i - 1] = input[k];
            }
            return res;

        }
    }
}
