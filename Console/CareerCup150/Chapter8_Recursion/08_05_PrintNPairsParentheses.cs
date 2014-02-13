using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapter8_Recursion
{
    public class _08_05_PrintNPairsParentheses
    {
        /*
         * Implement an algorithm to print all valid (e.g., properly opened and closed) combinations of n-pairs of parentheses.
            EXAMPLE:
            input: 3 (e.g., 3 pairs of parentheses)
            output: ()()(), ()(()), (())(), ((()))
         */
        public List<string> PrintAllParentheses(int n)
        {
            List<string> res = new List<string>();
            PrintAllParenthesesWorker(n, 0, 0, string.Empty, res);
            return res;
        }

        private void PrintAllParenthesesWorker(int n, int l, int r, string inprogress, List<string> res)
        {
            if (l == n && r == n)
            {
                res.Add(inprogress);
            }
            else 
            {
                if (l < n)
                {
                    PrintAllParenthesesWorker(n, l + 1, r, inprogress + "(", res);
                }
                if (r < l)
                {
                    PrintAllParenthesesWorker(n, l, r + 1, inprogress + ")", res);
                }
            } 
        }

    }
}
