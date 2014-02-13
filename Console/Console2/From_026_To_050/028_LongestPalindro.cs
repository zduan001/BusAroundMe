using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_026_To_050
{
    public class _028_LongestPalindro
    {
        /*
         * Given a string S, find the longest palindromic substring in S. You may assume that the maximum length of 
         * S is 1000, and there exists one unique longest palindromic substring.
         */
        /// <summary>
        /// Scan through the string compare left-- right++. need to consider odd and even. O(n^2)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int FindLongestPalindromic(string s)
        {
            int length = int.MinValue;
            int left = 0;
            int right = 0;

            for (int i = 0; i < s.Length; i++)
            {
                left = i - 1;
                right = i + 1;
                while (left >= 0 && right < s.Length)
                {
                    if (s[left] == s[right])
                    {
                        length = length > right - left + 1 ? length : right - left + 1;
                        left--;
                        right++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (i + 1 < s.Length && s[i] == s[i + 1])
                {
                    left = i - 1;
                    right = i + 2;
                    while (left >= 0 && right < s.Length)
                    {
                        if (s[left] == s[right])
                        {
                            length = length > right - left + 1 ? length : right - left + 1;
                            left--;
                            right++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

            }
            return length;
        }
    }
}
