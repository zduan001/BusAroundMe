using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _011_GenerateParenthese
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<string> GenerateParenThese(int input)
        {
            List<string> result = new List<string>();
            AddParenthese(0, 0, input, string.Empty, result);
            return result;
        }

        /// <summary>
        /// woking method.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <param name="input"></param>
        /// <param name="s"></param>
        /// <param name="res"></param>
        public void AddParenthese(int m, int n, int input, string s, List<string> res)
        {
            if (m == input && n == input)
            {
                res.Add(s);
                return;
            }

            if(m < input)
            {
                AddParenthese(m+1, n,input, s+"(", res);
            }
            
            if (m > n)
            {
                AddParenthese(m, n+1, input, s + ")", res);
            }
        }
    }
}
