using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_2_2_Interval1D
    {
        /*
         * Write an Interval1D client that takes an int value N as command-line argument, 
         * creads N intervals (each defined by a pair of double values) from standard input, 
         * and prints all pairs that intersect.
         */
        public List<KeyValuePair<Interval1D, Interval1D>> FindIntervalOverlaps(int n)
        {
            Interval1D[] array = new Interval1D[n];
            Random ran = new Random((int)DateTime.Now.ToOADate());
            for (int i = 0; i < n; i++)
            {
                double tmp1 = ran.NextDouble() * n;
                double tmp2 = ran.NextDouble() * n;
                Interval1D interval = new Interval1D()
                {
                    Left = Math.Min(tmp1, tmp2),
                    Right = Math.Max(tmp1, tmp2)
                };
                array[i] = interval;
            }

           List<KeyValuePair<Interval1D, Interval1D>> overlapList = new List<KeyValuePair<Interval1D, Interval1D>>();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (!(array[i].Right < array[j].Left && array[i].Left > array[j].Right))
                    {
                        overlapList.Add(new KeyValuePair<Interval1D, Interval1D>(array[i], array[j]));
                    }
                }
            }

            return overlapList;
        }
    }

    public class Interval1D
    {
        public double Left {get;set;}
        public double Right { get; set; }
        public double Length {
            get
            {
                return Right- Left;
            }
        }
        public bool Overlap{get;set;}
    }
}
