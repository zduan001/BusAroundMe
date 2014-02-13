using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _006_ValidPalindrome
    {
        /*
         * http://leetcode.com/onlinejudge#question_125
         * Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.

            For example,
            "A man, a plan, a canal: Panama" is a palindrome.
            "race a car" is not a palindrome.

            Note:
             Have you consider that the string might be empty? This is a good question to ask during an interview.

            For the purpose of this problem, we define empty string as valid palindrome.
         */
        public bool IsValidPalindrome(string input)
        {
            int left = 0;
            int right = input.Length - 1;
            while (left <= right)
            {
                if (!IsAAlphaNumeri(input[left]))
                {
                    left++;
                }
                else if (!IsAAlphaNumeri(input[right]))
                {
                    right--;
                }
                else if (input[left] == input[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsAAlphaNumeri(char c)
        {
            if (((int)c < 'a' || (int)c > 'z') && ((int)c < '0' || (int)c > '9'))
            {
                return false;
            }
            return true;
        }
    }
}
