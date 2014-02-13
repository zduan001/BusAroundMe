using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _022__MinSumPath
    {
        /// <summary>
        /// Given a m x n grid filled with non-negative numbers, find a path from top left to bottom 
        /// right which minimizes the sum of all numbers along its path.
        /// Note: You can only move either down or right at any point in time.
        /// </summary>
        /// <param name="input"></param>
        public int FindMinSumPath(List<List<int>> input)
        {
            List<List<int>> CurrentPath = new List<List<int>>(input.Count);
            for(int i = 0; i< input.Count;i++)
            {
                CurrentPath.Add(new List<int>());

                for (int j = 0; j < input[0].Count; j ++ )
                {
                    CurrentPath[i].Add(int.MaxValue);
                }
            }


            CurrentPath[0][0] = input[0][0];
            for (int i = 1; i < CurrentPath[0].Count; i++)
            {
                CurrentPath[0][i] = CurrentPath[0][i - 1] + input[0][i];
            }
            for (int i = 1; i < CurrentPath.Count; i++)
            {
                CurrentPath[i][0] = CurrentPath[i - 1][0] + input[i][0];
            }

            for (int i = 1; i < CurrentPath.Count; i++)
            {
                for (int j = 1; j < CurrentPath[0].Count; j++)
                {
                    CurrentPath[i][j] = Math.Min(CurrentPath[i - 1][j], CurrentPath[i][j - 1]) + input[i][j];
                }
            }

            //List<Point> result = new List<Point>();

            //Point tmp = new Point(input[0].Count - 1, input.Count - 1);
            //result.Add(tmp);
            //while (tmp.i != 0 || tmp.j != 0)
            //{
            //    if (CurrentPath[tmp.i - 1][tmp.j] <= CurrentPath[tmp.i][tmp.j - 1])
            //    {
            //        tmp = new Point(tmp.i - 1, tmp.j);
            //    }
            //    else
            //    {
            //        tmp = new Point(tmp.i, tmp.j - 1);
            //    }
            //    result.Add(tmp);
            //}

            return CurrentPath[input.Count - 1][input[0].Count - 1];
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Point
    {
        public int i { get; set; }
        public int j { get; set; }

        public Point(int x, int y)
        {
            i = x;
            j = y;
        }
    }
}
