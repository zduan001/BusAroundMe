using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _025_InterLeavingString
    {
        /*
         * http://leetcode.com/onlinejudge#question_97
         */
        public bool IsInterLeavingString(string s1, string s2, string p1)
        {
            if (s1.Length + s2.Length != p1.Length) return false;
            if (s1.Length == 0 && s2.Length == 0 && p1.Length == 0) return true;

            if (s1.Length > 0 && s2.Length > 0 && p1[0] == s1[0] && p1[0] == s2[0])
            {
                return IsInterLeavingString(s1.Substring(1), s2, p1.Substring(1)) ||
                    IsInterLeavingString(s1, s2.Substring(1), p1.Substring(1));
            }
            else if (s1.Length > 0 && p1[0] == s1[0])
            {
                return IsInterLeavingString(s1.Substring(1), s2, p1.Substring(1));
            }
            else if (s2.Length > 0 && p1[0] == s2[0])
            {
                return IsInterLeavingString(s1, s2.Substring(1), p1.Substring(1));
            }
            else
            {
                return false;
            }
        }

        // DP
        public bool IsInterLeavingStringII(string s1, string s2, string p1)
        {
            if (s1.Length + s2.Length != p1.Length) return false;
            if (s1.Length == 0 || s2.Length == 0) return (s1 == p1 || s2 == p1);

            bool[,] tracker = new bool[s1.Length + 1, s2.Length + 1];

            // ToDo: DP method go here.


            return tracker[s1.Length, s2.Length];

        }
    }
}
