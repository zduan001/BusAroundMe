using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _001_smallestcutPalindrom
    {
        /*
         * http://leetcode.com/onlinejudge#question_132
         */
        public int FindSmallestCutForAllPalindrome(string input)
        {
            int[] tracker = new int[input.Length];

            // first chart always need 0 cut.
            tracker[0] = 0;
            for (int i = 1; i < input.Length; i++)
            {
                if (this.IsPalindrome(input.Substring(0, i+1)))
                {
                    tracker[i] = 0;
                }
                else
                {
                    int min = int.MaxValue;
                    for (int j = 1; j <= i; j++)
                    {
                        if (this.IsPalindrome(input.Substring(j, i - j + 1)))
                        {
                            min = min < tracker[j - 1] + 1 ? min : tracker[j-1] + 1;
                        }
                    }
                    tracker[i] = min;
                }
            }
            return tracker[input.Length - 1];
        }

        private bool IsPalindrome(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                int left = 0;
                int right = s.Length - 1;

                while (left <= right)
                {
                    if (s[left] == s[right])
                    {
                        left++;
                        right--;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public List<List<string>> FindAllPossiblePalindromeCut(string input)
        {
            List<List<string>> res = new List<List<string>>();
            List<string> tmp = new List<string>();
            for (int i = 1; i <= input.Length; i++)
            {
                if (this.IsPalindrome(input.Substring(0, i)))
                {
                    tmp.Add(input.Substring(0, i));
                    Cut(res, tmp, input.Substring(i));
                    tmp.Remove(input.Substring(0, i));
                }
            }

            return res;
        }

        public void Cut(List<List<string>> res, List<string> tmp, string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                List<string> l = new List<string>();
                foreach (string st in tmp)
                {
                    l.Add(st);
                }
                res.Add(l);
                return;
            }

            else
            {
                for (int i = 1; i <= s.Length; i++)
                {
                    if (this.IsPalindrome(s.Substring(0, i)))
                    {
                        tmp.Add(s.Substring(0, i));
                        Cut(res, tmp, s.Substring(i));
                        tmp.Remove(s.Substring(0, i));
                    }
                }
            }
        }
    }
}
