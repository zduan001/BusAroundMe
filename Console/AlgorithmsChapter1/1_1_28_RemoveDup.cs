using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_1_28_RemoveDup
    {
        /*
         * Remove duplicates. Modify the test client in BinarySearch to remove any duplicate keys in the whitelist after the sort
         */
        public int RemoveDup(int[] input)
        {
            if (input == null) return -1;
            if (input.Length < 2) return-1;
            int i = 0;
            int j = 1;
            while (j < input.Length)
            {
                if (input[i] != input[j])
                {
                    if (i + 1 != j)
                    {
                        input[i + 1] = input[j];
                    }
                    j++;
                    i++;
                }
                else
                {
                    j++;
                }
            }
            return i;
        }
    }
}
