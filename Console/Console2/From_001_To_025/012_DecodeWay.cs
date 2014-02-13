using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_001_To_025
{
    public class _012_DecodeWay
    {
        /*
         A message containing letters from A-Z is being encoded to numbers using the following mapping:
 
        'A' -> 1
        'B' -> 2
        ...
        'Z' -> 26
        Given an encoded message containing digits, determine the total number of ways to decode it.
 
        For example,
        Given encoded message "12", it could be decoded as "AB" (1 2) or "L" (12).
 
        The number of ways decoding "12" is 2.
        */
        /// <summary>
        /// I tried recuesive first but change back to DP.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int DecodeTheWay(int n)
        {
            Stack<int> s = new Stack<int>();
            while (n > 0)
            {
                s.Push(n % 10);
                n /= 10;
            }
            int[] array = new int[s.Count];
            int i = 0;
            while (s.Count != 0)
            {
                array[i] = s.Pop();
                i++;
                // or I can do this
                // array[++i] = s.Pop();
            }

            int[] ways = new int[array.Length];
            ways[0] = 1;
            for (int j = 1; j < array.Length; j++)
            {
                if (array[j] == 0 && array[j - 1] >= 3) return 0;
                if (array[j - 1] * 10 + array[j] <= 26)
                    ways[j] = ways[j - 1] + 1;
                else
                    ways[j] = ways[j - 1];

            }
            return ways[array.Length - 1];
            //return WorkerOfDecodeTheWay(array, 0, array.Length - 1);
        }

        /// <summary>
        /// This method has bugs in it. does not work.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public int WorkerOfDecodeTheWay(int[] input, int left, int right)
        {
            if (left< input.Length && input[left] == 0) return 0;
            if (left == right)
            {
                return 1;
            }
            if (left > right) return 0;

            // I could left it recursive one more step here.
            int tmp = 0;


            if (left + 1 < input.Length && input[left + 1] * 10 + input[left] >= 26)
                tmp = 3 * WorkerOfDecodeTheWay(input, left + 2, right);
            else
                tmp = 2 * WorkerOfDecodeTheWay(input, left + 2, right) + 1 * WorkerOfDecodeTheWay(input, left + 1, right);

            return tmp;

        }
    }
}
