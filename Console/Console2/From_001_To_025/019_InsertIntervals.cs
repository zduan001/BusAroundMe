using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_001_To_025
{
    public class _019_InsertIntervals
    {
        /*
            Given a set of non-overlapping intervals, insert a new interval into the intervals (merge if necessary).
 
            You may assume that the intervals were initially sorted according to their start times.
 
            Example 1:
            Given intervals [1,3],[6,9], insert and merge [2,5] in as [1,5],[6,9].
 
            Example 2:
            Given [1,2],[3,5],[6,7],[8,10],[12,16], insert and merge [4,9] in as [1,2],[3,10],[12,16].
 
            This is because the new interval [4,9] overlaps with [3,5],[6,7],[8,10].
         * 
         * 代码分析：
 
　　        分6种情况：
　　        1. [0,1] 
                     [2,3] [5,6] [8,9]
　　        2.                    [10,11]
               [2,3] [5,6] [8,9] 
　　        3. [1,                    10]
　　　　            [2,3] [5,6] [8,9]
　　        4. [1,    4]
　　　　        [2,3] [5,6] [8,9]
　　        5. 　　　　　　[7,   10]
　　　　        [2,3] [5,6] [8,9]
　　        6.　　  [4,      7]
　　　　        [2,3] [5,6] [8,9]
         */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="insertee"></param>
        /// <returns></returns>
        public List<Interval> InsertIntervals(List<Interval> list, Interval insertee)
        {
            // 1 empty list
            if (list.Count == 0)
            {
                list.Add(insertee);
                return list;
            }

            // 2 new interval before other intervals;
            if (insertee.End < list[0].Start)
            {
                list.Insert(0, insertee);
                return list;
            }

            // 3. new interval after other intervals
            if (insertee.Start > list[list.Count - 1].End)
            {
                list.Add(insertee);
                return list;
            }

            // 4. new interval cover all intervals.
            if (insertee.Start < list[0].Start && insertee.End > list[0].End)
            {
                return new List<Interval>() { insertee };
            }

            // 5. interval stick out of left of intervals
            if (insertee.Start < list[0].Start)
            {
                int i = 0;
                while (insertee.End > list[i].End)
                {
                    i++;
                }

                list.RemoveRange(0, i);
                if (insertee.End >= list[0].Start)
                {
                    list[0].Start = insertee.Start;
                    return list;
                }
                else
                {
                    list.Insert(0, insertee);
                }
            }

            // 6. interval stick out of right of the intervals
            if (insertee.End > list[list.Count - 1].End)
            {
                int i = 0;
                while (insertee.Start < list[list.Count - 1 - i].Start)
                {
                    i++;
                }
                list.RemoveRange(list.Count - i, i);

                if (insertee.Start <= list[list.Count - 1].End)
                {
                    list[list.Count - 1].End = insertee.End;
                    return list;
                }
                else
                {
                    list.Add(insertee);
                    return list;
                }
            }

            // 7. interval overlapp with others intervals.
            int startIndex = 0;
            int endIndex = 0;
            int startValue = 0;
            int endValue = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (i - 1 > 0)
                {
                    if (insertee.Start < list[i].Start && insertee.Start > list[i - 1].End)
                    {
                        startIndex = i;
                        startValue = insertee.Start;
                    }
                }
                if (insertee.Start > list[i].Start && insertee.Start < list[i].End)
                {
                    startIndex = i;
                    startValue = list[i].Start;
                }
                if (i + 1 < list.Count)
                {
                    if (insertee.End > list[i].End && insertee.End < list[i + 1].Start)
                    {
                        endIndex = i;
                        endValue = insertee.End;
                    }
                }
                if (insertee.End > list[i].Start && insertee.End < list[i].End)
                {
                    endIndex = i;
                    endValue = list[i].End;
                }
            }

            list.RemoveRange(startIndex, endIndex - startIndex + 1);
            list.Insert(startIndex, new Interval(startValue, endValue));
            return list;
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
