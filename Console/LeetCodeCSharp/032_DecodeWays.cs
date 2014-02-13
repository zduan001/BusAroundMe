using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _032_DecodeWays
    {
        /*
         * http://leetcode.com/onlinejudge#question_91
         */
        public int DecodeWays(string input)
        {
            if (input.Length == 0) return 0;
            if (input.Length == 1) return 1;
            int res = 0;

            if (int.Parse(input.Substring(0, 2)) <= 26)
            {
                res += DecodeWays(input.Substring(2));
            }

            res += DecodeWays(input.Substring(1));
            return res;
        }
    }
}
