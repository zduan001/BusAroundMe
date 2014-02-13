using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_068_MaxInSlideWindows
    {
        /*
         * Given an array with length of N, there's a sliding window with length of K (
        K <= N). The window will slide from the beginning to the end, find all the 
        max numbers in the window.
         */
        /// <summary>
        /// The following algorithm could be proven to have run time complexity of O(n). This is because each element in the list is being inserted and then removed at most once. Therefore, the total number of insert + delete operations is 2n.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[] MaxInSlideWindows(int[] input, int k)
        {
            int n = input.Length;
            int[] res = new int[n-k];

            Deque<int> q = new Deque<int>();
            for(int i = 0;i<k;i++)
            {
                while(!q.IsEmpty() && input[i] > input[q.PeekBack()])
                {
                    q.PopBack();
                }
                q.PushBack(i);
            }

            for(int i = k;i< input.Length;i++)
            {
                res[i-k] = q.PeekBack();
                while(!q.IsEmpty() && input[i] > input[q.PeekBack()])
                {
                    q.PopBack();
                }
                q.PushBack(i);
                while(!q.IsEmpty() && i-k >= q.PeekFront())
                {
                    q.PopFront();
                }
            }
            res[n-k] = q.PeekFront();

            return res;
        }
    }
}
