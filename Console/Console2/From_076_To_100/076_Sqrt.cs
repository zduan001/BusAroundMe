using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_076_To_100
{
    public class _076_Sqrt
    {
        /*
         *Implement int sqrt(int x).Compute and return the square root of x.
         */
        public double FindSqrt(int n)
        {
            double left = 0;
            double right = n;
            double mid = -1;
            while (right - left > 0.001)
            {
                mid = (left + right) / 2.0;
                if (mid * mid == n)
                {
                    return mid;
                }
                else if (mid * mid > n)
                {
                    right = mid;
                }
                else
                {
                    left = mid;
                }
            }
            return mid;
        }

        /// <summary>
        /// Same question but use newton method, X(n) = X(n-1) + f(X(n-1))/f'(X(n-1))
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public double NewtonMethodFindSqrt(int n)
        {
            double x = 101.0;
            double previous = 0;
            while (Math.Abs(x - previous) > 0.001)
            {
                previous = x;
                x = previous - (previous * previous - n) / (2.0*previous);
            }
            return x;
        }
    }
}
