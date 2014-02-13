using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherQuestions.cs
{
    public class _012_MultiplicatrionWithoutTimes
    {
        /*
         * multiplication 2 integers without times
         */
        public long mult(int x, int y)
        {
            if (x == 0 || y == 0) return 0;
            bool isNegative = false;
            if ((x < 0 && y > 0) || (x > 0 && y < 0))
            {
                isNegative = true;
            }
            x = Math.Abs(x);
            y = Math.Abs(y);

            if (x < y)
            {
                int tmp = x;
                x = y;
                y = tmp;
            }

            long res = 0;
            if ((y & 1) == 1)
            {
                res += x;
            }

            int i = 1;
            while(y>0)
            {
                y = y >> 1;
                
                if ((y&1)==1)
                {
                    res += x << i;
                }
                i++;
            }
            res = isNegative ? -res : res;
            return res;
        }
    }
}
