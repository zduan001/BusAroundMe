using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_2_7_MysteryMethod
    {
        /*
         * What does the following recursive fucntion return?
         * I guess it is reverse of the string.
         */
        public string mystery(string s) 
        { 
            int N = s.Length; 
            if (N <= 1) return s;
            string a = s.Substring(0,N/2);
            string b = s.Substring(N / 2 , N - N / 2);
            return mystery(b) + mystery(a); 
        }

    }
}
