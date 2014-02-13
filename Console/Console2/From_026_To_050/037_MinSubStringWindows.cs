using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_026_To_050
{
    public class _037_MinSubStringWindows
    {
        /*
        Given a string S and a string T, find the minimum window in S which will contain all the characters in T in complexity O(n).
        For example,
        S = "ADOBECODEBANC"
        T = "ABC"
        Minimum window is "BANC".
        Note:
        If there is no such window in S that covers all characters in T, return the empty string "".
        If there are multiple such windows, you are guaranteed that there will always be only one unique minimum window in S.
        */
        /// <summary>
        /// Assumption: T does not have dup character, if T has dup character then Dictionary<char, Queue<int>> need to be used.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public string FindMinSubStrWindows(string s, string p)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char c in p)
            {
                map.Add(c, -1);
            }
            string res = s;
            for (int i = 0; i < s.Length; i++)
            {
                if(map.Keys.Contains(s[i]))
                {
                    map[s[i]] = i;
                    // I should be able to keep a max index and min index of the map, so I do not have to
                    // scan through the map to find all th e
                    string tmp = FindWindow(s, map);
                    if (tmp != string.Empty)
                    {
                        res = res.Length < tmp.Length ? res : tmp;
                    }
                }
            }
            if (res.Length == s.Length) return string.Empty;
            return res;
        }

        private string FindWindow(string s, Dictionary<char, int> map)
        {
            int start = int.MaxValue;
            int end = int.MinValue;
            foreach (char c in map.Keys)
            {
                if (map[c] == -1) return string.Empty;
                else
                {
                    start = start < map[c] ? start : map[c];
                    end = end > map[c] ? end : map[c];
                }
            }
            return s.Substring(start, end - start + 1);
        }
    }
}
