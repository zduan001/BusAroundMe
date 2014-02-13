using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyQuestions
{
    public class Week1
    {

        private int[] tracker;
        private int[] height;
        private int[] max;
        /*Social network connectivity. Given a social network containing N members and a log file containing M timestamps at which 
         * times pairs of members formed friendships, design an algorithm to determine the earliest time at which all members are 
         * connected (i.e., every member is a friend of a friend of a friend ... of a friend). Assume that the log file is sorted 
         * by timestamp and that friendship is an equivalence relation. The running time of your algorithm should be MlgN or better 
         * and use extra space proportional to N.
         */
        public int  Question1(List<LogEntry> input, int n)
        {
            tracker = new int[n];
            height = new int[n];

            int connections = 0;
            foreach (LogEntry item in input)
            {
                int left = Find(item.Member1, tracker);
                int right = Find(item.Member2, tracker);

                if (left != right)
                {
                    if (height[left] < height[right])
                    {
                        tracker[left] = right;
                    }
                    else if (height[right] < height[left])
                    {
                        tracker[right] = left;
                    }
                    else
                    {
                        tracker[left] = right;
                        height[right]++;
                    }
                    connections++;
                }

                if (connections == n - 1)
                {
                    return item.TimeStamp;
                }
            }
            return -1;
        }

        private int Find(int i, int[] tracker)
        {
            while (tracker[i] != 0)
            {
                i = tracker[i];
            }
            return i;
        }

        /*
         * Union-find with specific canonical element. Add a method find() to the union-find data type so that find(i) returns the largest element 
         * in the connected component containing i. The operations, union(), connected(), and find() should all take logarithmic time or better. 
         * For example, if one of the connected components is {1,2,6, 9}, then the find() method should return 9 for each 
         * of the four elements in the connected components.
         */
        public void Question2(List<LogEntry> input, int n)
        {
            tracker = new int[n];
            height = new int[n];
            max = new int[n];

            for (int i = 0; i < n; i++)
            {
                max[i] = i;
            }

            int connections = 0;
            foreach (LogEntry item in input)
            {
                int left = Find(item.Member1, tracker);
                int right = Find(item.Member2, tracker);

                if (left != right)
                {
                    if (height[left] < height[right])
                    {
                        tracker[left] = right;
                    }
                    else if (height[right] < height[left])
                    {
                        tracker[right] = left;
                    }
                    else
                    {
                        tracker[left] = right;
                        height[right]++;
                    }
                    connections++;

                    max[left] = Math.Max(max[left], max[right]);
                    max[right] = Math.Max(max[left], max[right]);
                }
            }
        }

        public int FinxMax(int i)
        {
            int maxVal = i;
            while (this.tracker[i] != 0)
            {
                i = tracker[i];
            }
            return this.max[i];
        }
    }

    public struct LogEntry
    {
        public int Member1 { get; set; }
        public int Member2 { get; set; }
        public int TimeStamp { get; set; }
    }
}
