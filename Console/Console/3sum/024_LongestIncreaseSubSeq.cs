using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _024_LongestIncreaseSubSeq
    {
        /// <summary>
        /// find the longest increase sub sequence in a int array.
        /// e.g. {2,6,4,5,1,3}, the LIS = {2,4,5};
        /// </summary>
        /// <param name="input">the array</param>
        /// <returns>longest sequence length</returns>
        public int LongestIncreasePath(int[] input)
        {
            if (input.Length == 0) return 0;

            int[] res = new int[input.Length];
            List<int>[] trace = new List<int>[input.Length];

            res[0] = 1;
            trace[0] = new List<int>() {input[0]};
            int tmp;
            for (int i = 1; i < input.Length; i++)
            {
                tmp = 0;
                for (int j = 0; j < i; j++)
                {
                    if (input[i] > input[j] && res[j] >= res[tmp])
                    {
                        tmp = j;
                    }
                }

                if (input[i] > input[tmp])
                {
                    res[i] = res[tmp] + 1;
                    List<int> newList = new List<int>();
                    foreach (int value in trace[tmp])
                    {
                        newList.Add(value);
                    }
                    newList.Add(input[i]);
                    trace[i] = newList;
                }
                else
                {
                    res[i] = 1;
                    trace[i] = new List<int>() { input[i] };
                }
            }

            int longestSubSeq = 0;
            List<int> seq = null;
            for (int i = 0; i < res.Length; i++)
            {
                if (res[i] > longestSubSeq)
                {
                    longestSubSeq = res[i];
                    seq = trace[i]; 
                }
            }

            return longestSubSeq;
        }
    }
}
