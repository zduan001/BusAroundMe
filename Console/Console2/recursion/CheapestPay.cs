using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.recursion
{
    public class CheapestPay
    {
        /*
         * Write a function using Recursion to do the following: You are the manager in a small factory. 
         * You have 7 workers and 7 jobs to be done. Each worker is assigned one and only one job. Each 
         * worker demands different pay for each job. (E.g.: Worker Sam demands $10 for welding, $15 for 
         * carpentry, etc. Worker Joe demands $12 for welding, $5 for carpentry, etc.) Find the job-assignment 
         * which works out cheapest for you.
         */
        public int FindCheapestPay(List<int[]> Salaris)
        {
            bool[] tracker = new bool[Salaris.Count];
            int[] workers = new int[Salaris.Count];
            return Worker(workers.Length, 0, workers, tracker, Salaris);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">total number jobs</param>
        /// <param name="k">number of jobs have been assigned</param>
        /// <param name="workers">integer array keep tracking which worker has been assigned.</param>
        /// <param name="Salaries">salaries input</param>
        public int Worker(int n, int k, int[] workers, bool[] tracker, List<int[]> Salaries)
        {
            if (n == k)
            {
                int totalSalary = 0;
                for (int i = 0; i < workers.Length; i++)
                {
                    totalSalary += Salaries[i][workers[i]];
                }
                return totalSalary;
            }
            else
            {
                int minPay = int.MaxValue;
                for (int i = 0; i < workers.Length; i++)
                {
                    if (!tracker[i])
                    {
                        tracker[i] = true;
                        for (int j = 0; j < Salaries[0].Length; j++)
                        {
                            workers[i] = j;
                            int tmp = Worker(n, k + 1, workers, tracker, Salaries);
                            minPay = tmp < minPay ? tmp : minPay;
                        }
                        tracker[i] = false;
                    }
                }
                return minPay;
            }
        }
    }
}
