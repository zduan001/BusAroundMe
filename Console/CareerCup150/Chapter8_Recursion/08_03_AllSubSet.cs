using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapter8_Recursion
{
    public class _08_03_AllSubSet
    {
        /*
         * Write a method that returns all subsets of a set.
         */
        public List<string> FindAllSubSet(string s)
        {
            List<string> res = new List<string>();
            FindAllSubSetWorker(s.Length, 0, string.Empty, s, res);

            return res;
        }

        public void FindAllSubSetWorker(int n, int k, string inprogress, string input, List<string> res)
        {
            if (n == k)
            {
                res.Add(inprogress);
            }
            else
            {
                FindAllSubSetWorker(n, k + 1, inprogress + input[k], input, res);
                FindAllSubSetWorker(n, k + 1, inprogress, input, res);
            }
        }
    }
}
