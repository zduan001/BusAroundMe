using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _040_RegularExpression
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
        /// isMatch("aab", "c*a*b") → true
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool Match(string s, string p)
        {
            if (p.Length == 0)
            {
                return s.Length == 0;
            }

            // next p is not '*'
            if (p[1] != '*')
            {
                return ((p[0] == s[0] || (p[0] == '.' && s.Length > 0)) && Match(s.Substring(1), p.Substring(1)));
            }

            // next p is '*'
            while(p[0] == s[0] || (p[0] == '.' && s.Length>0))
            {
                if(Match(s, p.Substring(2)))
                    return true;
                s = s.Substring(1);
            }

            return Match(s, p.Substring(2));
        }
    }
}
