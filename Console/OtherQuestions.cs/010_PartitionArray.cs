using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherQuestions.cs
{
    public class _010_PartitionArray
    {
        /*
         * http://www.mitbbs.com/article_t/JobHunting/32089027.html
         * Given a set of n integers, each in the range 0 : : :K, partition the integers into two subsets to minimize 
         * |S1 -S2|, where S1 and S2 denote the sums of the elements in each of the two subsets.
         */
        public int PartitionArray(int[] input)
        {
            List<int> l1 = new List<int>();
            List<int> l2 = new List<int>();
            int minDiff = int.MaxValue;
            worker(input, 0, l1, l2, ref minDiff);
            return minDiff;
        }

        public void worker(int[] input, int k, List<int> l1, List<int> l2, ref int minDiff)
        {
            if (k == input.Length)
            {
                int diff = Math.Abs(l1.Sum() - l2.Sum());
                minDiff = diff < minDiff ? diff : minDiff;
                return;
            }
            else
            {
                l1.Add(input[k]);
                worker(input, k + 1, l1, l2, ref minDiff);
                l1.Remove(input[k]);

                l2.Add(input[k]);
                worker(input, k + 1, l1, l2, ref minDiff);
                l2.Remove(input[k]);
            }
        }

    }
}
