using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _040_PowerOfN
    {
        /// <summary>
        /// 代码分析：
        /*
　　      这么精妙的解法当然是网上抄来的。
 
　　      思路是，把xn 的 n 写成2进制， 然后一位一位右移，x平方级增加，如果当前一位是 ‘1’， ret *= x。语文学不好，直接看例子

 
　　      比如 25: 5 的二进制 ...000101
 
　　      1) ret = 1.0, n 的第一位是 ‘1’， 所以 ret *= x = 2.0， x *= x = 4.0, n >>= 1 =....000010
 
　　      2) ret = 2.0, n 的第一位是 '0'， 所以 ret = 2.0， x *= x = 16.0, n >>= 1 = ... 000001
 
　　      3) ret = 2.0, n 的第一位是 '1'， 所以 ret *= x = 32.0, x *= x = 256.0, n >>= 1 = ...000000
 
　　      n = 0，返回。
 
　　      注意：
 
　　      1）如果n < 0， 需要一个flag记住n < 0, 返回的时候 返回 1 / ret。
 
　　      2）int.MinValue 的绝对值比 int,MaxValue 大一，所以会溢出，或者抛出异常。 返回这个 1 / Pow(x, int.MaxValue) * x;
        */
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static double Pow(double x, int n)
        {
            bool is_neg = n < 0;

            //Because Math.Abs(int.MinValue) not exist.
            if (n == int.MinValue)
            {
                return 1 / Pow(x, int.MaxValue) * x;
            }

            n = Math.Abs(n);

            double ret = 1.0;
            while (n > 0)
            {
                if ((n & 1) == 1) ret *= x;
                x *= x;
                n >>= 1;
            }
            return is_neg ? 1 / ret : ret;
        }
    }
}
