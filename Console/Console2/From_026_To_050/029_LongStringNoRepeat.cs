using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_026_To_050
{
    public class _029_LongStringNoRepeat
    {
        /*
         * Given a string, find the length of the longest substring without repeating characters. 
         * For example, the longest substring without repeating letters for "abcabcbb" is "abc", 
         * which the length is 3. For "bbbbb" the longest substring is "b", with the length of 1.
         */
        /// <summary>
        /// I might be able to do it in O(n).
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int FindLongestSubStringWithNoRepeat(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            int[] tracker = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                {
                    map.Add(s[i], i);
                    if (i == 0)
                    {
                        tracker[i]++;
                    }
                    else
                    {
                        tracker[i] = tracker[i - 1] + 1;
                    }
                }
                else
                {
                    int lastIndex = map[s[i]];
                    if (lastIndex > i - 1 - tracker[i - 1])
                    {
                        tracker[i] = i - lastIndex;
                    }
                    else
                    {
                        tracker[i] = tracker[i-1] +1;
                    }
                    map[s[i]] = i;
                }
            }

            int maxLength = int.MinValue;
            int index = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (tracker[i] > maxLength)
                {
                    maxLength = tracker[i];
                    index = i;
                }
            }
            return maxLength;

            //string res = s.Substring(index - tracker[index], tracker[index]);
            //return res;
        }
    }
}
