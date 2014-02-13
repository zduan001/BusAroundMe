using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Console2.From_001_To_025
{
    public class _006_LongestSubStringWithoutRepeating
    {
        /// <summary>
        /// Given a string, find the length of the longest substring without repeating characters. 
        /// For example, the longest substring without repeating letters for "abcabcbb" is "abc", 
        /// which the length is 3. For "bbbbb" the longest substring is "b", with the length of 1.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int FindLongestSubStringWithoutRepeating(string s)
        {
            BitArray map = new BitArray(256, false);
            int i = 0;
            int j = 0;
            int max = 0;
            int n = s.Length;

            while (j < n)
            {
                if (map[s[j]])
                {
                    max = (max > (j - i)) ? max : j - i;
                    while (s[i] != s[j])
                    {
                        map[s[i]] = false;
                        i++;
                    }
                    i++;
                    j++;
                }
                else
                {
                    map[s[j]] = true;
                    j++;
                }
            }
            // try one more time, if the longest string span to the the end
            // of the string this line will catch it.
            max = (max > (j - i)) ? max : j - i;
            return max;
        }

        /// <summary>
        /// Same method, only this time using DP>
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int FindLongestSubStringWithoutRepeatingDP(string s)
        {

            return 0;
        }
    }
}
