using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_026_To_050
{
    public class _033_MergeIntervals
    {
        /*
        Given a collection of intervals, merge all overlapping intervals.
 
        For example,
        Given [1,3],[2,6],[8,10],[15,18],
        return [1,6],[8,10],[15,18].

         */
        /// <summary>
        /// Assumer input is sorted by Start, if not sort it.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<Interval> MergeIntervals(Interval[] input)
        {
            List<Interval> res = new List<Interval>();
            int i = 1;
            Interval tmp = new Interval();
            tmp.Start = input[0].Start;
            tmp.End = input[0].End;
            while (i < input.Length)
            {
                if (input[i].Start <= tmp.End )
                {
                    if (input[i].End > tmp.End)
                    {
                        tmp.End = input[i].End;
                    }
                    i++;
                }
                else
                {
                    res.Add(tmp);
                    tmp = new Interval();
                    tmp.Start = input[i].Start;
                    tmp.End = input[i].End;
                    i++;
                }
            }
            res.Add(tmp);

            return res;
        }
    }

    public class Interval
    {
        public Interval(): this(0,0)
        {
        }
        public Interval(int start, int end)
        {
            Start = start;
            End = end;
        }
        public int Start { get; set; }
        public int End { get; set; }
    }
}
