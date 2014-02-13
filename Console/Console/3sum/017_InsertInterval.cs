using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _017_InsertInterval
    {
        /// <summary>
        /// Given a set of non-overlapping intervals, insert a new interval into the intervals (merge if necessary).
        /// You may assume that the intervals were initially sorted according to their start times.
        /// Example 1:
        /// Given intervals [1,3],[6,9], insert and merge [2,5] in as [1,5],[6,9]. 
        /// Example 2:
        /// Given [1,2],[3,5],[6,7],[8,10],[12,16], insert and merge [4,9] in as [1,2],[3,10],[12,16].
        /// This is because the new interval [4,9] overlaps with [3,5],[6,7],[8,10]. 
        /// </summary>
        /// <param name="intervals"></param>
        /// <param name="newInterval"></param>
        /// <returns></returns>
        public Interval[] InsertInterval(Interval[] intervals, Interval newInterval)
        {
            if (intervals.Length == 0)
            {
                return new Interval[] { newInterval };
            }

            List<Interval> res = new List<Interval>();
            int startIndex =-1;
            int endIndex = -1;
            int newStart =0;
            int newEnd =0;
            int overlappedIndex=-1;
            for(int i = 0; i< intervals.Length; i ++)
            {
                if(newInterval.Start >= intervals[i].Start && newInterval.Start<= intervals[i].End)
                    startIndex = i;
                if(newInterval.Start <= intervals[i].Start && newInterval.End >= intervals[i].End)
                {
                    intervals[i] = null;
                    overlappedIndex = i;
                    continue;
                }
                if(newInterval.End>= intervals[i].Start && newInterval.End <= intervals[i].End)
                    endIndex = i;
            }

            // if startindex and end index are same, then newInterval fall within one interval.
            
            if (startIndex == endIndex && overlappedIndex == -1)
            {
                int insertIndex = -1;
                if (startIndex != -1)
                {
                    return intervals;
                }
                else
                {
                    if (newInterval.End < intervals[0].Start)
                    {
                        insertIndex = -1;
                    }
                    else if (newInterval.Start > intervals[intervals.Length - 1].End)
                    {
                        insertIndex = intervals.Length;
                    }
                    else
                    {
                        for (int i = 0; i < intervals.Length - 1; i++)
                        {
                            if (newInterval.Start > intervals[i].End && newInterval.End < intervals[i + 1].Start)
                                insertIndex = i;
                        }
                    }
                }
                if (insertIndex == -1)
                {
                    res.Add(newInterval);
                    res.AddRange(intervals);
                }
                else if (insertIndex == intervals.Length)
                {
                    res.AddRange(intervals);
                    res.Add(newInterval);
                }
                else
                {
                    for (int i = 0; i <= intervals.Length; i++)
                    {
                        res.Add(intervals[i]);
                        if (i == insertIndex)
                        {
                            res.Add(newInterval);
                        }
                    }
                }
            }
            else
            {
                if (startIndex != -1)
                {
                    newStart = intervals[startIndex].Start;
                    intervals[startIndex] = null;
                }
                else
                {
                    newStart = newInterval.Start;
                }
                if (endIndex != -1)
                {
                    newEnd = intervals[endIndex].End;
                    intervals[endIndex] = null;
                }
                else
                {
                    newEnd = newInterval.End;
                }

                Interval tmp = new Interval(newStart, newEnd);
                bool newIntervalInserted = false;
                if (startIndex != -1)
                {
                    intervals[startIndex] = tmp;
                    newIntervalInserted = true;
                }
                else if (endIndex != -1)
                {
                    intervals[endIndex] = tmp;
                    newIntervalInserted = true;
                }
                else
                {
                    intervals[overlappedIndex] = tmp;
                    newIntervalInserted = true;
                }

                for (int i = 0; i < intervals.Length; i++)
                {
                    if (intervals[i] != null)
                    {
                        res.Add(intervals[i]);
                    }
                }
            }
            
            return res.ToArray();
        }

        /// <summary>
        /// Same as last method.
        /// </summary>
        /// <param name="intervals"></param>
        /// <param name="newInterval"></param>
        /// <returns></returns>
        public List<Interval> InsertInterval(List<Interval> intervals, Interval newInterval)
        {
            int newS = -1;
            int newE = -1;
            List<Interval> ret = new List<Interval>();

            // case 1: empty lsit.
            if (intervals.Count == 0)
            {
                ret.Add(newInterval);
                return ret;
            }

            // case 2: new interval before any other interval.
            if (newInterval.End < intervals[0].Start)
            {
                ret.Add(newInterval);
                foreach (var item in intervals)
                {
                    ret.Add(item);
                }
                return ret;
            }

            // case 3: new interval after any other interval.
            if (newInterval.Start > intervals[intervals.Count - 1].End)
            {
                foreach (var item in intervals)
                {
                    ret.Add(item);
                }
                ret.Add(newInterval);
                return ret;
            }

            // case 4: new interval covered all other intervals.
            if (newInterval.Start <= intervals[0].Start && newInterval.End >= intervals[intervals.Count - 1].End)
            {
                ret.Add(newInterval);
                return ret;
            }

            // case 5: new interval stick out to the left side.
            if (newInterval.Start <= intervals[0].Start)
            {
                newS = newInterval.Start;
                foreach (var item in intervals)
                {
                    if (newInterval.End > item.End)
                    {
                        continue;
                    }
                    if (newE == -1 && newInterval.End >= item.Start && newInterval.End <= item.End)
                    {
                        newE = item.End;
                        ret.Add(new Interval(newS, newE));
                        continue;
                    }
                    if (newE == -1 && newInterval.End < item.Start)
                    {
                        newE = newInterval.End;
                        ret.Add(new Interval(newS, newE));
                        ret.Add(item);
                        continue;
                    }
                    ret.Add(item);
                }
                return ret;
            }

            // case 6: new interval stick out to the right of the all intervals.
            if (newInterval.End >= intervals[intervals.Count - 1].End)
            {
                newE = newInterval.End;
                foreach (var item in intervals)
                {
                    if (newInterval.Start > item.End)
                    {
                        ret.Add(item);
                        continue;
                    }
                    if (newS == -1 && newInterval.Start >= item.Start && newInterval.Start <= item.End)
                    {
                        newS = item.Start;
                        ret.Add(new Interval(newS, newE));
                        return ret;
                    }
                    if (newS == -1 && newInterval.Start < item.Start)
                    {
                        newS = newInterval.Start;
                        ret.Add(new Interval(newS, newE));
                        return ret;
                    }
                }
                return ret;
            }

            // case 8: new interval overlaps old intervals.
            foreach (var item in intervals)
            {
                // ??? should it be new Interval.Start > itme.Start?
                if (newS == -1 && newInterval.Start < item.Start)
                {
                    newS = newInterval.Start;
                    continue;
                }

                // new interval totally merged into 1 old interval.
                if (newS == -1 && newInterval.Start >= item.Start && newInterval.Start <= item.End)
                {
                    newS = item.Start;
                    continue;
                }

                // new interval after one old interval.
                if (newS == -1 && newInterval.Start > item.End)
                {
                    ret.Add(item);
                }

                // new inverval  stick out right to one old interval.
                if (newInterval.End > item.End)
                {
                    continue;
                }

                // End > start and End < End, new interval end landed inside one interval.
                if (newE == -1 && newInterval.End >= item.Start && newInterval.End <= item.End)
                {
                    newE = item.End;
                    ret.Add(new Interval(newS, newE));
                    continue;
                }

                // new interval before one interval.
                if (newE == -1 && newInterval.End < item.Start)
                {
                    newE = newInterval.End;
                    ret.Add(new Interval(newS, newE));
                    ret.Add(item);
                    continue;
                }

                ret.Add(item);
            }

            return ret;
        }


    }

    public class Interval
    {
        public int Start;
        public int End;
        public Interval()
        {
            Start = 0;
            End = 0;
        }
        public Interval(int start, int end)
        {
            Start = start;
            End = end;
        }
    }
}
