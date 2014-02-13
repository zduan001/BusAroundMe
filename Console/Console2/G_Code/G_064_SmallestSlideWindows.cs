using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_064_SmallestSlideWindows
    {
        /*
         * Given an input array A of integers of size n, and a query array B of integers of size
            m, find the smallest window of input array that contains all the elements of query array and
            also in the same order.
            例如：
            A = [1; 9; 3; 4; 12; 13; 9; 12; 21]
            B = [9; 12; 21]
            那么应该返回A[6::8] = [9; 12; 21]
         */
        /// <summary>
        /// Scan through the array keep updating the left right with the smallest distance...
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public KeyValuePair<int, int> FindSmallestWindows(int[] input, int[] pattern)
        {
            int smallestWindow = int.MaxValue;
            int start = 0;
            int end = 0;

            SortedList<int, int> tracker = new SortedList<int, int>();
            HashSet<int> map = new HashSet<int>(); // assum array pattern does not have dup.
            for (int i = 0; i < pattern.Length; i++)
            {
                map.Add(pattern[i]);
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (map.Contains(input[i]))
                {
                    if (tracker.Keys.Contains(input[i]))
                    {
                        tracker[input[i]] = i;
                    }
                    else
                    {
                        tracker.Add(input[i], i);
                    }

                    int left = tracker.Min().Value;
                    int right = tracker.Max().Value;
                    if (tracker.Count == pattern.Length && right - left > smallestWindow)
                    {
                        smallestWindow = right - left;
                        start = left;
                        end = right;
                    }
                }
            }

            KeyValuePair<int, int> res = new KeyValuePair<int, int>(start, end);
            return res;
        }
    }
}
