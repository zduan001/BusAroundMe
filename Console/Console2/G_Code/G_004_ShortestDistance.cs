using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_004_ShortestDistance
    {
        /*
         * 一个二维数组代表了城市中的坐标，给定N个人的坐标，求坐标使所有人走到这个坐标的距离的和最小，只可以横着或者竖着走，不可以斜着走
         */
        /// <summary>
        /// I used brutal force here, there should be a better way. I will keep searching.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="n"></param>
        /// <param name="points"></param>
        /// <returns></returns>
        public Point FindShortestDistanceForAll(int[,] input, int n, List<Point> points)
        {
            int min = int.MaxValue;
            Point minP = new Point();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int tmp = 0;
                    foreach (Point p in points)
                    {
                        tmp += Math.Abs(i - p.x) + Math.Abs(j - p.y);
                    }
                    min = min < tmp ? min : tmp;
                    minP.x = i;
                    minP.y = j;

                }
            }
            return minP;
        }

        /// <summary>
        /// this is the second try of the same method. basically I separate x and y,
        ///  1. create a column chart for all the x in points and a column chart for all the y in the points
        ///  2. loop through all the index (0 to n-1) to find min total distance in x direction and y direction.
        ///  3. return a point which has the min x and y.
        ///  
        /// </summary>
        /// <param name="input"></param>
        /// <param name="n"></param>
        /// <param name="points"></param>
        /// <returns></returns>
        public Point FindShortestDistanceForAllII(int[,] input, int n, List<Point> points)
        {
            int[] XColumn = new int[n];
            int[] yColumn = new int[n];

            foreach (Point p in points)
            {
                XColumn[p.x]++;
                yColumn[p.y]++;
            }

            int xMin = int.MaxValue;
            int yMin = int.MaxValue;
            int xMinp = -1;
            int yMinp = -1;
            for (int i = 0; i < n; i++)
            {
                int tmpX = 0;
                int tmpY = 0;
                for (int j = 0; j < n; j++)
                {
                    tmpX += Math.Abs(i - j) * XColumn[j];
                    tmpX += Math.Abs(i - j) * yColumn[j];
                }
                if (xMin > tmpX)
                {
                    xMin = tmpX;
                    xMinp = i;
                }
                if (yMin > tmpY)
                {
                    yMin = tmpY;
                    yMinp = i;
                }

            }
            return new Point() { x = xMinp, y = yMinp };
        }
    }

    public class Point
    {
        public int x;
        public int y;
    }



}
