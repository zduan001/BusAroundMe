using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_1_30_ArrayExcercise
    {
        /*
         * Array exercise. Write a code fragment that creates an N-by-N boolean array a[][] 
         * such that a[i][j] is true if i and j are relatively prime (have no common factors), and false otherwise.
         */
        public bool[,] ArrayExcercise(int m, int n)
        {
            bool[,] res = new bool[m, n];
            for(int i =1;i< m;i++)
            {
                for(int j = 1;j<n;j++)
                {
                    if(Elucid(i,j) > 1)
                    {
                        res[i,j] = true;
                    }
                }
            }
            return res;

        }

        private int Elucid(int i, int j)
        {
            if (j == 0)
                return j;
            int r = i % j;
            return Elucid(j, r);
        }
    }
}
