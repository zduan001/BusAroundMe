using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_034_CokeMachines
    {
        /*
         * Three coke machines. Each one has two values min and max, which means if you
         * get coke from this machine it will load you a random volume in the range [min; max]. Given a
         * cup size n and minimum soda volume m, show if it’s possible to make it from these machines.
         */
        public bool CanGetTheCoke(CokeMachine[] machines, int m, int n)
        {
            return Worker(machines, m, n, 0, 0);
        }

        public bool Worker(CokeMachine[] machines, int m, int n, int curMin, int curMax)
        {
            if (curMin > m && curMax < n)
            {
                return true;
            }
            else if (curMax > n)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < machines.Length; i++)
                {
                    if(Worker(machines, m,n,curMin + machines[i].Min, curMax+curMax))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }

    public class CokeMachine
    {
        public int Min { get; set; }
        public int Max { get; set; }
    }
}
