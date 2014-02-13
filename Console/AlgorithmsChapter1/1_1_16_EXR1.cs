using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_1_16_EXR1
    {
        /*
         * Give the value of the  exR1(6)
         */
        public string exR1(int n)
        { 
            if (n <= 0) 
                return ""; 
            return exR1(n - 3) + n + exR1(n - 2) + n; 
        }
    }
}
