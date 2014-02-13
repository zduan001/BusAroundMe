using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _012_GrayCode
    {
        /// <summary>
        /// The gray code is a binary numeral system where two successive values differ in only one bit.
        /// Given a non-negative integer n representing the total number of bits in the code, 
        /// print the sequence of gray code. A gray code sequence must begin with 0.
        /// For example, given n = 2, return [0,1,3,2]. Its gray code sequence is:
        /// 00 - 0
        /// 01 - 1
        /// 11 - 3
        /// 10 - 2
        /// </summary>
        /// <param name="input">number of bits</param>
        /// <returns>List of numbers</returns>
        public List<int> GenerateGrayCode(int input)
        {
            List<int> res = new List<int>();
            GetCode(0, input, 0, res);
            return res;
        }

        /// <summary>
        /// Working method for GrayCode.
        /// </summary>
        /// <param name="k"></param>
        /// <param name="target"></param>
        /// <param name="value"></param>
        /// <param name="res"></param>
        public void GetCode(int k, int target, int value, List<int> res)
        {
            if (k == target-1)
            {
                res.Add(value | (1 << k));
                res.Add(value | (0 << k));
            }

            if (k < target)
            {
                GetCode(k + 1, target, value | (1 << k), res);
                GetCode(k + 1, target, value | (0 << k), res);
            }
        }

        /// <summary>
        /// Same GrayCode, only use iterative this time.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<int> GenerateGrayCodeIterative(int input)
        {
            List<int> res = new List<int>();

            for (int i = 0; i < input; i++)
            {
            }

            return res;
        }
    }
}
