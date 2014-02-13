using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_001_To_025
{
    public class _017_GrayCode
    {
        /*
         * The gray code is a binary numeral system where two successive values differ in only one bit.
        Given a non-negative integer n representing the total number of bits in the code, print the sequence of gray code. A gray code sequence must begin with 0.
        For example, given n = 2, return [0,1,3,2]. Its gray code sequence is:
 
        00 - 0
        01 - 1
        11 - 3
        10 - 2

         */
        public List<int> GenerateGrayCode(int n)
        {
            List<int> res = new List<int>();
            WorkerMethod(n, 0, 0, res);
            return res;
        }

        public void WorkerMethod(int n, int tmp, int k, List<int> res)
        {
            if (k == n - 1)
            {
                res.Add(tmp | (1 << k));
                res.Add(tmp | (0 << k));
            }
            else
            {
                WorkerMethod(n, tmp | (1 << k), k + 1, res);
                WorkerMethod(n, tmp | (0 << k), k + 1, res);
            }
        }
    }
}
