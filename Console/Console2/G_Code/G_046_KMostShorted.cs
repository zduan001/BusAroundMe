using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_046_KMostShorted
    {
        /*
         * An array with n elements which is K most sorted. 就是每个element的初始位置和
         * 它最终的排序后的位置的距离不超过常数K,设计一个排序算法。should be faster than O(nlgn)
         */
        /// <summary>
        /// use a k size min heap. build the minHeap klgk, each time fix lgk, (n-k)lgk. read out the min is 1
        /// so it is nlgk +n;
        /// </summary>
        /// <param name="input"></param>
        /// <param name="k"></param>
        public void SortKMostSorted(int[] input, int k)
        {
            SortedList<int, int> minHeap = new SortedList<int, int>();
            for (int i = 0; i < k; i++)
            {
                minHeap.Add(input[i], input[i]);
            }
            for (int i = k; i < input.Length; i++)
            {
                input[i - k] = minHeap.Min().Value;
                minHeap.Add(input[i], input[i]);
            }
            for (int i = input.Length - k; i < input.Length; i++)
            {
                input[i] = minHeap.Min().Value;
            }
        }
    }
}
