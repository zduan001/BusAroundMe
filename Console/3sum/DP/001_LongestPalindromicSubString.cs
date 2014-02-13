using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class DP_001_LongestPalindromicSubString
    {

        /// <summary>
        /// Given a string S, find the longest palindromic substring in S.
        /// 
        /// http://www.leetcode.com/2011/11/longest-palindromic-substring-part-i.html
        /// First, make sure you understand what a palindrome means.
        /// A palindrome is a string which reads the same in both directions. For example, “aba” is a palindome, “abc” is not.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string FindLongestPalindromicSubString(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;

            int maxLength = 1;
            int startIndex = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    int left = i;
                    int right = i + 1;
                    while (left >= 0 && right < input.Length && input[left] == input[right])
                    {
                        if ((right - left + 1) > maxLength)
                        {
                            maxLength = right - left + 1;
                            startIndex = left;
                        }
                        left--;
                        right++;
                    }
                }
                else
                {
                    int left = i - 1;
                    int right = i + 1;
                    while (left >= 0 && right < input.Length && input[left] == input[right])
                    {
                        if ((right - left + 1) > maxLength)
                        {
                            maxLength = right - left + 1;
                            startIndex = left;
                        }
                        left--;
                        right++;
                    }
                }
            }
            return input.Substring(startIndex, maxLength); ;
        }

        /// <summary>
        /// Same goal just use DP
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string FindLongestPalindromicSubStringDP(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;
            int startIndex = 0;
            int maxLength = 1;
            bool[,] res = new bool[input.Length, input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                res[i, i] = true;
            }

            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    res[i, i + 1] = true;
                    startIndex = i;
                    maxLength = 2;
                }
            }

            for (int length = 3; length <= input.Length; length++)
            {
                for (int i = 0; i < input.Length - length + 1; i++)
                {
                    int j = i + length - 1;
                    if (input[j] == input[i] && res[i + 1, j - 1])
                    {
                        res[i, j] = true;
                        if ((j - i + 1) > maxLength)
                        {
                            maxLength = j - i + 1;
                            startIndex = i;
                        }
                    }
                }
            }
            return input.Substring(startIndex, maxLength);
        }
    }
}
