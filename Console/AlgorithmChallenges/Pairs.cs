﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenges
{
    public class Pairs
    {
        /*https://www.hackerrank.com/challenges/pairs
         * Given N numbers [N<=10^5], count the total pairs of numbers that have a difference of K. [K>0 and K<1e9]

            Input Format:

            1st line contains N & K (integers).
            2nd line contains N numbers of the set. All the N numbers are assured to be distinct.

            Output Format:

            One integer saying the no of pairs of numbers that have a diff K.

            Sample Input #00:

            5 2
            1 5 3 4 2

            Sample Output #00:

            3

            Sample Input #01:

            10 1
            363374326 364147530 61825163 1073065718 1281246024 1399469912 428047635 491595254 879792181 1069262793 

            Sample Output #01:

            0
         */
        public int CountPair(int k, int[] input)
        {
            int res = 0;
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < input.Length; i++)
            {
                hs.Add(input[i]);
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (hs.Contains(input[i] + k))
                {
                    res++;
                }
                if (hs.Contains(input[i] - k))
                {
                    res++;
                }
                hs.Remove(input[i]);
            }
            return res;
        }
    }
}
