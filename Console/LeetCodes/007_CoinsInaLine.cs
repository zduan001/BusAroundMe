using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class _007_CoinsInaLine
    {
        /* http://leetcode.com/2011/02/coins-in-line.html
            There are n coins in a line. (Assume n is even). Two players take turns to take a coin from one of the ends of the line until there are no more coins left. The player with the larger amount of money wins.
            Would you rather go first or second? Does it matter?
            Assume that you go first, describe an algorithm to compute the maximum amount of money you can win.
         */
        public int CoinsInaLine(int[] input)
        {
            int n = input.Length;
            int[,] tracker = new int[n, n];

            //for (int i = 0; i < input.Length; i++)
            //{
            //    tracker[i, i] = input[i];
            //}

            int a, b, c;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0, m = i; m < n; j++,  m++)
                {
                    a = (j + 2) < m ? tracker[j + 2, m] : 0;
                    b = (j + 1) < m - 1 && (m - 1) > 0 ? tracker[j + 1, m - 1] : 0;
                    c = m - 2 >= 0 ? tracker[j, m - 2] : 0;
                    tracker[j, m] = Math.Max(input[j] + Math.Min(a, b), Math.Min(b, c) + input[m]);
                }
            }
            PrintSequence(tracker, input);
            return tracker[0, n - 1];
        }

        /// <summary>
        /// in i,j , I either take i or j. the oppoent take either p(i+1,j) or and p(i,j-1))
        /// I need to leav smaller one in p(i+1,j) or p(i,j-1) to him.
        /// </summary>
        /// <param name="tracker"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public string PrintSequence(int[,] tracker, int[] input)
        {
            int i = 0;
            int j = input.Length - 1;
            bool myTurn = true;
            StringBuilder sb = new StringBuilder();
            while (i <= j)
            {
                int p1 = tracker[i + 1, j];
                int p2 = tracker[i, j - 1];
                sb.Append(myTurn ? "I" : "You");
                sb.Append(" Take coints ");

                if (p1 <= p2)
                {
                    sb.Append(i.ToString() + " value " + input[i].ToString());
                    i++;
                }
                else
                {
                    sb.Append(j.ToString() + " value " + input[j].ToString());
                    j--;
                }
                sb.Append("\n");
                myTurn = !myTurn;
            }

            return sb.ToString();
        }
    }
}
