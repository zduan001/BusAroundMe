using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Console2.G_Code
{
    public class G_001_FindKthElement
    {
        /*
         * Given two sorted arrays A, B of size m and n respectively. Find the k-th smallest 
         * element in the union of A and B. You can assume that there are no duplicate elements.
         */
        public int FindKthElement(int[] a, int aStart, int aEnd, int[] b, int bStart, int bEnd, int k)
        {
            int m = aEnd - aStart;
            int n = bEnd - bStart;
            Debug.Assert(m > 0);
            Debug.Assert(n > 0);

            int i = (int)((double)(m * (k - 1) / (m + n)));
            int j = k - i - 1;

            int ai_1 = i - 1 < 0 ? int.MinValue : a[aStart + i - 1];
            int bj_1 = j - 1 < 0 ? int.MinValue : b[bStart + j - 1];
            int ai = i > aEnd ? int.MaxValue : a[aStart + i];
            int bj = j > bEnd ? int.MaxValue : b[bStart + j];

            if (ai < bj && ai > bj_1)
                return ai;
            else if (bj < ai && bj > ai_1)
                return bj;

            if (ai < bj)
                return FindKthElement(a, aStart + i + 1, aEnd, b, bStart, bEnd, k - i - 1);
            else
                return FindKthElement(a, aStart, aEnd, b, bStart + j + 1, bEnd, k - j - 1);
        }

        /*
         * 给两 个很长的数组， 给定其中一个数，找离这个数距离最短的第K个数
         */
        public int FindKthClosedElement(int[] a, int[] b, int target, int k)
        {
            // BinarySearch target in a and b. 
            // if (target is on the ith element on a)
            //      call FindKthElement(a, i+1, a.length, b, 0, b.length-1, k);
            // if(target is on the ith element on b)
            //      call FindKthElement(a, 0, a.lenght-1, b, i +1, b.length-1, k);
            //
            //  if I need to find left side the target?
            //      then I need to create a method FindKthelementFromHighest.
            //  call FindKthelementFromHighest(a, 0, a.length -1-i, b, 0, b.length-1, k);
            // or FindKthelementFromHighest(a, 0, a.length-1, b, 0, b.length - i -1, k);
            // 
            // there might be a better way to do it. let me think....

            return 0;
        }
    }
}
