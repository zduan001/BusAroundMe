using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConque
{
    public class Pow
    {
        /*
         *http://www.geeksforgeeks.org/write-a-c-program-to-calculate-powxn/
         *find pow(x, n);
         */
        public double pow(int x, int n)
        {
            if (n == 0) return 1.0;
            double res = pow(x, n / 2);

            if (n % 2 == 0)
            {
                return res * res;
            }
            else
            {
                return x * res * res;
            }
        }
    }
}
