using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class _005_DivideWithOutDivide
    {
        /*
         * Divide without use "/"
         */
        public int Divide(int dividend, int dividor)
        {
            int res = 0;
            int multi = 1;
            while (dividor < dividend)
            {
                multi = 1;
                while (dividor * multi <= dividend)
                {
                    multi = multi << 1;
                }
                res += multi >> 1;
                dividend -= dividor * (multi >> 1);
            }
            return res;
        }
    }
}
