using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_001_To_025
{
    public class _016_Generateparenthesis
    {
        /*
         * Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
 
            For example, given n = 3, a solution set is:
 
            "((()))", "(()())", "(())()", "()(())", "()()()"
         */
        public List<string> GenerateParenthesis(int n)
        {
            List<string> res = new List<string>();
            WorkerParenthesis(res, string.Empty, n, 0, 0);
            return res;
        }

        public void WorkerParenthesis(List<string> res, string s, int n, int left, int right)
        {
            if (left == n && right == n)
            {
                res.Add(s);
            }

            if (left < n)
            {
                WorkerParenthesis(res, s + "(", n, left + 1, right);
            }
            if (right < left)
            {
                WorkerParenthesis(res, s + ")", n, left, right+1);
            }
        }
            
    }
}
