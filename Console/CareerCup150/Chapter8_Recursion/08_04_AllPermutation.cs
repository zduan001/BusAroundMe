using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapter8_Recursion
{
    public class _08_04_AllPermutation
    {
        /*
         * Write a method to compute all permutations of a string.
         */
        public List<string> AllPermutation(string s)
        {
            List<string> res = new List<string>();
            bool[] tracker = new bool[s.Length];
            WorkerMethod(s.Length, 0, tracker, string.Empty, s, res);
            return res;
        }

        public void WorkerMethod(int n, int k, bool[] tracker, string inprogress, string input, List<string> res)
        {
            if (n == k)
            {
                res.Add(inprogress);
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (!tracker[i])
                    {
                        tracker[i] = true;
                        WorkerMethod(n, k + 1, tracker, inprogress + input[i],input, res);
                        tracker[i] = false;
                    }
                }
            }
        }
    }
}
