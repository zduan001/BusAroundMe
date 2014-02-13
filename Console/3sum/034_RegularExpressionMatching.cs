using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _033_RegularExpressionMatching
    {
        /// <summary>
        /// Implement regular expression matching with support for '.' and '*'.
        /// '.' Matches any single character.
        /// '*' Matches zero or more of the preceding element.
        /// The matching should cover the entire input string (not partial).
        /// The function prototype should be:
        /// bool isMatch(const char *s, const char *p)
        /// Some examples:
        /// isMatch("aa","a") → false
        /// isMatch("aa","aa") → true
        /// isMatch("aaa","aa") → false
        /// isMatch("aa", "a*") → true
        /// isMatch("aa", ".*") → true
        /// isMatch("ab", ".*") → true
        /// isMatch("aab", "c*a*b") → true ?????
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool RegularExpressionMatching(string s, string p)
        {
            //if s.Length == 0 check if p has * after each character
            if (s.Length == 0)
                return RegularExpressionMatching_CheckEmpty(p);
            //if s.Length >= 0 and p.Length == 0, return false
            if (p.Length == 0)
                return false;

            char s1 = s[0];
            char p1 = p[0];
            char p2 = p.Length > 1 ? p[1] : '0'; //any character but '*' will work

            if (p2 == '*')
            {
                if (p1 == '.' || s1 == p1)
                {
                    return RegularExpressionMatching(s.Substring(1), p) || RegularExpressionMatching(s, p.Substring(2));
                }
                else
                {
                    return RegularExpressionMatching(s, p.Substring(2));
                }
            }
            else
            {
                if (p1 == '.' || s1 == p1)
                {
                    return RegularExpressionMatching(s.Substring(1), p.Substring(1));
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool RegularExpressionMatching_CheckEmpty(string p)
        {
            if (p.Length % 2 != 0)
                return false;

            for (int i = 1; i < p.Length; i += 2)
            {
                if (p[i] != '*')
                    return false;
            }

            return true;
        }
    }
}
