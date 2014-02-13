using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _009DecodeWay
    {
        /// <summary>
        /// A message containing letters from A-Z is being encoded to numbers using the following mapping:
        /// 'A' -> 1
        /// 'B' -> 2
        /// ...
        /// 'Z' -> 26
        /// Given an encoded message containing digits, determine the total number of ways to decode it.
        /// For example,
        /// Given encoded message "12", it could be decoded as "AB" (1 2) or "L" (12).
        /// </summary>
        /// <param name="input">input string..</param>
        /// <returns>number of ways</returns>
        public int DecodeWays(string input)
        {
            // mal format string return 0;
            if (string.IsNullOrEmpty(input)) return 0;
            if (input.Substring(0, 2) == "30" || input.Substring(0, 2) == "00") return 0;

            int[] res = new int[input.Length];
            res[0] = 1;
            if (int.Parse(input.Substring(0, 2)) <= 26)
            {
                res[1] = 2;
            }
            else
            {
                res[1] = 1;
            }
            int tmp;

            for (int i = 2; i < input.Length; i++)
            {
                // mal format input. return 0.
                if (input.Substring(i - 1, 2) == "30" || input.Substring(i - 1, 2) == "00")
                {
                    return 0;
                }
                tmp = int.Parse(input.Substring(i - 1, 2));
                if(tmp <= 26)
                {
                    res[i] = res[i - 1] + res[i - 2];
                }
                else
                {
                    res[i] = res[i-1];
                }
            }
            return res[input.Length-1];
        }
    }
}
