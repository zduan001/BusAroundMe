using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_1_9_PrintBinary
    {
        /*
         * Write a code fragment that puts the binary representation of a positive integer N into a String s . 
         */
        public string PrintOutBinary(int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = n; i > 0; i = i / 2)
            {
                sb.Insert(0,(i % 2).ToString());
            }
            return sb.ToString();
        }
    }
}
