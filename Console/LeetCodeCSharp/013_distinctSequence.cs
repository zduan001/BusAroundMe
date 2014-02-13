using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _013_distinctSequence
    {
        /*
         * http://leetcode.com/onlinejudge#question_115
         */
        public int FindMaxDistinctSequence(string s, string p)
        {
            int[,] tracker = new int[p.Length, s.Length];

            for (int j = 0; j < s.Length; j++)
            {
                if (s[j] == p[0])
                {
                    tracker[0, j] = j > 0 ? tracker[0, j - 1] + 1 : 1;
                }
                else
                {
                    tracker[0, j] = j > 0 ? tracker[0, j - 1] : 0;
                }
            }

            for (int i = 1; i < p.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    if (p[i] == s[j])
                    {
                        tracker[i, j] = tracker[i - 1, j - 1] + tracker[i, j-1];
                    }
                    else
                    {
                        tracker[i, j] = tracker[i, j - 1];
                    }
                }
            }

            return tracker[p.Length - 1, s.Length - 1];
        }
    }
}
