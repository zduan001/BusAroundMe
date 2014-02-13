using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class _001_PalindromePartitioning
    {
        /* http://discuss.leetcode.com/questions/1265/palindrome-partitioning
         * Given a string s, partition s such that every substring of the partition is a palindrome.

            Return all possible palindrome partitioning of s.

            For example, given s = "aab",
             Return
            [
              ["aa","b"],
              ["a","a","b"]
            ]

         */
        public void PartitionString(string input, List<string> tmp,  ref List<List<string>> res)
        {
            if( string.IsNullOrEmpty(input))
            {
                List<string> l = new List<string>();

                for (int i = 0; i < tmp.Count; i++)
                {
                    l.Add(tmp[i]);
                }

                res.Add(l);
                
                return;
            }

            for (int i = 1; i <= input.Length; i++)
            {
                if (IsPalindrome(input.Substring(0, i)))
                {
                    tmp.Add(input.Substring(0, i));
                    PartitionString(input.Substring(i), tmp, ref res);
                    tmp.Remove(input.Substring(0, i));
                }
            }
        }

        private bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length-1;
            while(left <= right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
