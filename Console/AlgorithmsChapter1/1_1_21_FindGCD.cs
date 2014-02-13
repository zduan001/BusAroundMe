using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_1_21_FindGCD
    {
        /*
         * GCD -- Euclid's method
         */
        public int FindGCDEuclid(int p, int q, ref string tracker)
        {
            if (tracker != null)
            {
                tracker += string.Format("p = {0}, q = {1}", p.ToString(), q.ToString());
            }
            if (q == 0) return p;
            int r = p % q;
            return FindGCDEuclid(q, r, ref tracker);
        }
    }
}
