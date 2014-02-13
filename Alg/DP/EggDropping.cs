using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class EggDropping
    {
        /*http://www.geeksforgeeks.org/dynamic-programming-set-11-egg-dropping-puzzle/
         * http://archive.ite.journal.informs.org/Vol4No1/Sniedovich/index.php
         * Suppose that we wish to know which stories in a 36-story building are safe to drop eggs from,
         * and which will cause the eggs to break on landing. We make a few assumptions:

            …..An egg that survives a fall can be used again.
            …..A broken egg must be discarded.
            …..The effect of a fall is the same for all eggs.
            …..If an egg breaks when dropped, then it would break if dropped from a higher floor.
            …..If an egg survives a fall then it would survive a shorter fall.
            …..It is not ruled out that the first-floor windows break eggs, 
         *      nor is it ruled out that the 36th-floor do not cause an egg to break.
         * 2 cases:
         * 1) If the egg breaks after dropping from xth floor, then we only need to check for floors lower than x with 
         * remaining eggs; so the problem reduces to x-1 floors and n-1 eggs
          2) If the egg doesn’t break after dropping from the xth floor, then we only need to check for floors 
         * higher than x; so the problem reduces to k-x floors and n eggs.
         */
        public int FindMinumumNumEggDropping(int NumOfEggs, int NumOfFloor)
        {
            int[,] trace = new int[NumOfEggs+1, NumOfFloor+1];

            for (int i = 0; i < NumOfEggs+1; i++)
            {
                trace[i, 0] = 0;
                trace[i, 1] = 1;
            }

            // this method actually left first row as 0
            for (int j = 0; j < NumOfFloor; j++)
            {
                trace[1, j] = j;
            }

            for (int i = 2; i < NumOfEggs+1; i++)
            {
                for (int j = 2; j < NumOfFloor + 1; j++)
                {
                    trace[i, j] = int.MaxValue;
                    for (int k = 1; k < j; k++)
                    {
                        int tmp = Math.Max(trace[i-1, k - 1], trace[i, j - k]);
                        trace[i, j] = trace[i, j] < tmp + 1 ? trace[i, j] : tmp + 1;
                    }
                }
            }

            return trace[NumOfEggs, NumOfFloor];
        }
    }
}
