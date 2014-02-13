using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_1_20_ln
    {
        /*
         * Write a recursive static method that computes the value of ln (N!)
         * hmm. havn't figure out how to do it yet.
         */
        public double FindLnN(int input, double error)
        {
            int x = 1;
            for (int i = 1; i <= input; i++)
            {
                x *= i;
            }

            return worker(0, x, x, error);

        }

        public double worker(double left, double right, int x, double error)
        {
            double mid = (left +right )/2.0;

            if (Math.Abs(right - left) <= error)
            {
                return mid;
            }

            if (Math.Pow(Math.E, mid) >= x)
            {
                right = mid;
            }
            else
            {
                left = mid;
            }

            return worker(left, right, x, error);

        }
    }
}
