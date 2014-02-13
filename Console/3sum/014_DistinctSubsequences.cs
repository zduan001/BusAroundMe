using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _014_DistinctSubsequences
    {
        /// <summary>
        /// Given a string S and a string T, count the number of distinct subsequences of T in S.
        /// A subsequence of a string is a new string which is formed from the original string by deleting some 
        /// (can be none) of the characters without disturbing the relative positions of the remaining characters. 
        /// (ie, "ACE" is a subsequence of "ABCDE" while "AEC" is not).
        /// Here is an example:
        ///  S = "rabbbit", T = "rabbit" 
        ///  Return 3. 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public int NumberDistinct(string s, string t)
        {
            if (s.Length == 0) return 0;
            if (t.Length == 0) return 1;

            if (s.Length == 1 && t.Length == 1)
            {
                if (s[0] == t[0])
                    return 1;
                else
                    return 0;
            }

            if (s[0] != t[0])
            {
                return NumberDistinct(s.Substring(1), t);
            }
            else
            {
                return NumberDistinct(s.Substring(1), t) + NumberDistinct(s.Substring(1), t.Substring(1));
            }
        }

        /// <summary>
        /// Same just use DP
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public int NumberDistinctDP(string s, string t)
        {
            if (s.Length == 0) return 0;
            int n = s.Length;
            int m = t.Length;
            int[] dp = new int[m];
            for (int i = 0; i < n; ++i)
            {
                for (int j = m - 1; j >= 0; --j)
                {
                    if (s[i] == t[j])
                    {
                        if (j == 0)
                        { 
                            dp[0]++; 
                        }
                        else
                        {
                            dp[j] += dp[j - 1];
                        }
                    }
                }
            }
            return dp[m - 1];
        }
    }
}
