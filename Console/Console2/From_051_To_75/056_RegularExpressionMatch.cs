using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_051_To_75
{
    /*
        Implement regular expression matching with support for '.' and '*'.
        '.' Matches any single character.
        '*' Matches zero or more of the preceding element.

        The matching should cover the entire input string (not partial).

        The function prototype should be:
        bool isMatch(const char *s, const char *p)

        Some examples:
        isMatch("aa","a") → false
        isMatch("aa","aa") → true
        isMatch("aaa","aa") → false
        isMatch("aa", "a*") → true
        isMatch("aa", ".*") → true
        isMatch("ab", ".*") → true
        isMatch("aab", "c*a*b") → true
     */
    /// <summary>
    /// I am not quite sure If I understand the question correctly
    /// but I did 3 thing.
    /// 1. if s[0] == p[0], check string s from s[1] with string p from p[1];
    /// 2. if p[0] is '.' , check string s from s[1] with string p from p[1];
    /// 3. if p[1] is '*', find how many p[0] in the begining for s, then check stirng s from that index with p from p[2].
    /// </summary>
    public class _056_RegularExpressionMatch
    {
        public bool MatchRegualrExpression(string s, string p)
        {
            if (s.Length == 0) return true;
            if (p.Length == 0) return false;
            if (p[0] == '.')
            {
                return MatchRegualrExpression(s.Substring(1), p.Substring(1));
            }
            if (p[0] == '*')
            {
                return MatchRegualrExpression(s, p.Substring(1));
            }
            
            if (p.Length >1 && p[1] == '*')
            {
                int startIndex = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == p[0])
                    {
                        startIndex = i + 1;
                    }
                    else
                    {
                        break;
                    }
                }
                if (startIndex > s.Length - 1)
                { 
                    return true; 
                }
                else
                {
                    return MatchRegualrExpression(s.Substring(startIndex), p.Substring(2));
                }
            }else if(s[0] == p[0])
            {
                return MatchRegualrExpression(s.Substring(1), p.Substring(1));
            }
            return false;
        }
    }
}
