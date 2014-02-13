using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_1_13_TranspositionArray
    {
        /*
         * Write a code fragment to print the transposition (rows and columns changed) of a two- dimensional array with M rows and N columns.
         * too simple, skip the test of this method.
         */
        public int[,] GetTransposition(int[,] input)
        {
            int m = input.GetLength(0);
            int n = input.GetLength(1);

            int[,] res = new int[n, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    res[j, i] = input[i, j];
                }
            }
            return res;
        }
    }
}
