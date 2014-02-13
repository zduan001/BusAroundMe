using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _029_FindSqureRoot
    {
        /// <summary>
        /// Find Sqrt.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public double FindSqrt(double input)
        {
            if (input < 0) return -1;
            if(input == 1 || input == 0) return input;

            double  left = 0; 
            double right = input;
            double mid = -1;
            double precision = 0.00001;

            if (input < 1.0) right = 1.0;

            while(left< right)
            {
                mid = (left + right)/2;

                if( Math.Abs(mid * mid - input) < precision)
                    break;

                if (mid * mid > input)
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
    }
}
