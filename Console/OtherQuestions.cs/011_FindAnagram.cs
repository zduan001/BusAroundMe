using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherQuestions.cs
{
    public class _011_FindAnagram
    {
        /*
         * 在一个大串中查找和另外一个字符串是anagram的子串:
         * GetAnagram(‘‘abcdbcsdaqdbahs’’, ‘‘scdcb’’) ==> ‘‘cdbcs’’
         */
        public string FindAnagram(string s1, string p)
        {
            if(s1.Length < p.Length) return string.Empty;
            if(string.IsNullOrEmpty(p)) return string.Empty;
 
            Dictionary<char, int> pattern = new Dictionary<char, int>();
            for (int i = 0; i < p.Length; i++)
            {
                if (pattern.Keys.Contains(p[i]))
                {
                    pattern[p[i]]++;
                }
                else
                {
                    pattern.Add(p[i], 1);
                }
            }
            Dictionary<char,int> tracker = new Dictionary<char,int>();
            for(int i =0;i< s1.Length;i++)
            {
                if (i < p.Length)
                {
                    if (tracker.Keys.Contains(s1[i]))
                    {
                        tracker[s1[i]]++;
                    }
                    else
                    {
                        tracker.Add(s1[i], 1);
                    }
                }
                else
                {

                    bool foundAnagram = true;
                    foreach (char c in tracker.Keys)
                    {
                        if (!pattern.Keys.Contains(c) || pattern[c] != tracker[c])
                        {
                            foundAnagram = false;
                            break;
                        }
                    }
                    if (foundAnagram)
                    {
                        return s1.Substring(i - p.Length, p.Length);
                    }

                    tracker[s1[i - p.Length]]--;
                    if (tracker[s1[i - p.Length]] == 0)
                    {
                        tracker.Remove(s1[i - p.Length]);
                    }

                    if (tracker.Keys.Contains(s1[i]))
                    {
                        tracker[s1[i]]++;
                    }
                    else
                    {
                        tracker.Add(s1[i], 1);
                    }
                }
            }

            return string.Empty;
        }
    }
}
