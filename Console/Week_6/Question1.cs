using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6
{
    public class Question1
    {
        /*
         * 4-SUM. Given an array a of n integers, 
         * the 4-SUM problem is to determine if there exist distinct indices i, j, k, and l such that a[i] + a[j] = a[k] + a[l]. 
         * Design an algorithm for the 4-SUM problem that takes time proportional to n^2 (under suitable technical assumptions).
         */
        public bool If4Sum(int[] input)
        {
            HashSet<int> sum = new HashSet<int>();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i+1; j < input.Length; j++)
                {
                    int res = input[i] + input[j];
                    if (sum.Contains(res))
                    {
                        return true;
                    }
                    else
                    {
                        sum.Add(res);
                    }
                }
            }
            return false;
        }
    }
}
