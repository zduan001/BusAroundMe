using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_1_27_BinomialDistribution
    {
        /*
         * Binomial distribution. Estimate the number of recursive calls that would be used by the code
         * to compute binomial(100, 50, 0.25) 
         * add a ref count to see, expoential
         */
        public double Binomial(int N, int k, double p, ref long count) 
        {
            count++;
            if ((N == 0) && (k == 0)) 
                return 1.0; 
            if ((N < 0) || (k < 0)) 
                return 0.0; 
            return (1 - p) * Binomial(N - 1, k, p, ref count) + p * Binomial(N - 1, k - 1, p, ref count); 
        }

        // DP method. 
        public double BinomialDP(int N, int k, double p)
        {
            double[,] tracker = new double[N, k];
            tracker[0, 0] = 1.0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (i == 0 && j == 0) break;
                    double N_1k =  ((i - 1) < 0 )? 0.0 : tracker[i - 1, j];
                    double N_1k_1 = ((i - 1) < 0 || (j - 1 )< 0) ? 0.0 : tracker[i - 1, j - 1];
                    tracker[i, j] = (1 - p) * N_1k + p * N_1k_1;
                }
            }
            return tracker[N - 1, k - 1];
        }
    }
}
