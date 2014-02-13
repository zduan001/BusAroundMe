using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Console2.G_Code
{
    public class G_017_ReserviorSampling
    {
        /// <summary>
        /// reservior sampling.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public object[] Sampling(IEnumerator input, int k)
        {
            object[] res = new object[k];
            int count = 0;
            Random random = new Random();

            while (input.Current != null)
            {
                if (count < k)
                {
                    res[count] = input.Current;
                }
                else
                {
                    int tmp = random.Next();
                    res[tmp % k] = input.Current;
                }
                input.MoveNext();
            }
            return res;
        }

        /*http://en.wikipedia.org/wiki/Reservoir_sampling
         * array R[k];    // result
            integer i, j;

            // fill the reservoir array
            for each i in 1 to k do
                R[i] := S[i]
            done;

            // replace elements with gradually decreasing probability
            for each i in k+1 to length(S) do
                j := random(1, i);   // important: inclusive range
                if j <= k then
                    R[j] := S[i]
                fi
            done

         */
    }
}
