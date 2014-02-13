using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _010_PascalTriangle
    {
        /*
         * http://leetcode.com/onlinejudge#question_119
         * Given an index k, return the kth row of the Pascal's triangle.
         *   For example, given k = 3,
             Return [1,3,3,1].

            Note:
             Could you optimize your algorithm to use only O(k) extra space?

         */
        public List<int> GetPsacalTriangle(int k)
        {
            List<int> previous = new List<int>();
            List<int> current = new List<int>();

            if (k == 0) return new List<int>() { 1};
            if (k == 1) return new List<int>() { 1, 1 };

            current = new List<int>() { 1, 1 };

            for (int i = 2; i <= k; i++)
            {
                previous = current;
                current = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0) current.Add(1);
                    else if (j == i) current.Add(1);
                    else
                    {
                        current.Add(previous[j - 1] + previous[j]);
                    }
                }

            }
            return current;
        }
    }
}
