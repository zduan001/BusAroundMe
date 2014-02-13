using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class _004_RegularExpression
    {

        /*http://leetcode.com/2011/09/regular-expression-matching.html
         * Implement regular expression matching with support for ‘.’ and ‘*’.
         * ‘.’ Matches any single character.
            ‘*’ Matches zero or more of the preceding element.

            The matching should cover the entire input string (not partial).

            The function prototype should be:
             bool isMatch(const char *s, const char *p)

            Some examples:
             isMatch(“aa”,”a”) → false
             isMatch(“aa”,”aa”) → true
             isMatch(“aaa”,”aa”) → false
             isMatch(“aa”, “a*”) → true
             isMatch(“aa”, “.*”) → true
             isMatch(“ab”, “.*”) → true
             isMatch(“aab”, “c*a*b”) → true
         */
        public bool Match(string s, string p)
        {
            if (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(p))
            {
                return true;
            }
            else if ((string.IsNullOrEmpty(s) && !string.IsNullOrEmpty(p)) || !string.IsNullOrEmpty(s) && string.IsNullOrEmpty(p))
            {
                return false;
            }
            else
            {
                if (p.Length >= 2 && p[1] == '*')
                {
                    int i = 0;
                    char tmp = p[0] == '.' ? s[0] : p[0];
                    while (i< s.Length && s[i] == tmp)
                    {
                        if (Match(s.Substring(i), p.Substring(2)))
                        {
                            return true;
                        }
                        i++;
                    }
                    // need to do one more test after the sequence of all 
                    if (Match(s.Substring(i), p.Substring(2)))
                    {
                        return true;
                    }
                    return false;
                }
                else if (p.StartsWith("."))
                {
                    return Match(s.Substring(1), p.Substring(1));
                }
                else
                {
                    if (s[0] == p[0])
                    {
                        return Match(s.Substring(1), p.Substring(1));
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
