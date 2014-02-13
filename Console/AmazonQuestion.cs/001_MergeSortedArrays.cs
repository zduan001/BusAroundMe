using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonQuestion.cs
{
    public class _001_MergeSortedArrays
    {
        // Difficulty: *
        /*
         * 给两个ascend排序的integer array，找出他们的union，并且descend排序。
         * http://www.mitbbs.com/article_t/JobHunting/32259233.html
         * Assume in both array there is no dup.
         */
        public List<int> MergeArrays(int[] a, int[] b)
        {
            int indexa = a.Length - 1;
            int indexb = b.Length - 1;
            List<int> res = new List<int>();
            while (indexa >= 0 && indexb >= 0)
            {
                if (a[indexa] == a[indexb])
                {
                    res.Add(a[indexa]);
                    indexa--;
                    indexb--;
                }
                else
                {
                    if (a[indexa] > b[indexb])
                    {
                        indexa--;
                    }
                    else
                    {
                        indexb--;
                    }
                }
            }
            return res;
        }
    }
}
