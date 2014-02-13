using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _021_MinimumWindowsSubstring
    {
        /// <summary>
        /// Given a string S and a string T, find the minimum window in S which will contain all the characters in T in complexity O(n).
        /// For example,
        /// S = "ADOBECODEBANC"
        /// T = "ABC"
        /// Minimum window is "BANC".
        /// 
        /// Note:
        /// If there is no such window in S that covers all characters in T, return the empty string "".
        /// If there are multiple such windows, you are guaranteed that there will always be only one unique minimum window in S.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public string FindMinWindowSubstrring(string s, string t)
        {
            if (t.Length > s.Length) return string.Empty;
            string res = string.Empty;

            Dictionary<char, int> count = new Dictionary<char, int>();
            foreach (char c in t)
            {
                if (count.ContainsKey(c))
                {
                    count[c]++;
                }
                else
                {
                    count.Add(c, 1);
                }
            }

            Dictionary<char, Queue<int>> track = new Dictionary<char, Queue<int>>();

            int start = 0;
            int end = s.Length;
            int minLength = s.Length;

            for (int i = 0; i < s.Length; i++)
            {
                if (count.ContainsKey(s[i]))
                {
                    if (!track.ContainsKey(s[i]))
                    {
                        track.Add(s[i], new Queue<int>());
                        track[s[i]].Enqueue(i);
                    }
                    else
                    {
                        if (track[s[i]].Count < count[s[i]])
                        {
                            track[s[i]].Enqueue(i);
                        }
                        else
                        {
                            track[s[i]].Dequeue();
                            track[s[i]].Enqueue(i);
                        }
                    }
                }

                int min = s.Length, max = 0;
                int countOfElement = 0;
                foreach (char c in track.Keys)
                {
                    foreach (int k in track[c])
                    {
                        if (k < min) min = k;
                        if (k > max) max = k;
                        countOfElement++;
                    }
                }
                if ((max - min) < minLength && countOfElement == t.Length)
                {
                    start = min;
                    end = max;
                    minLength = max - min;
                }
            }

            return s.Substring(start,minLength+1);
        }
    }
}
