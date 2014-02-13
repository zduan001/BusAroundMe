using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _003_LongestConsectiveSequence
    {
        /*
         * http://leetcode.com/onlinejudge#question_128
         */

        public int FindLongestConsectiveSequence(int[] input)
        {
            int maxLength = 0;
            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!hash.Contains(input[i]))
                {
                    hash.Add(input[i]);
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                if(hash.Contains(input[i]))
                {
                    int left = FindLeft(hash, input[i] -1);
                    int right = FindRight(hash, input[i] +1);
                    int length = right - left-1;
                    maxLength = maxLength > length ? maxLength : length;
                }
            }

            return maxLength;
        }

        private int FindLeft(HashSet<int> hash, int k)
        {
            
            while (hash.Contains(k))
            {
                hash.Remove(k);
                k--;
            }
            return k;
        }

        private int FindRight(HashSet<int> hash, int k)
        {

            while (hash.Contains(k))
            {
                hash.Remove(k);
                k++;
            }
            return k;
        }
    }
}
