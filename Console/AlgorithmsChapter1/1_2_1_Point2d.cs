using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_2_1_Point2d
    {
        /*
         * Write a Point2D client that takes an integer value N from the command line, generates N 
         * random points in the unit square, and computes the distance separating the closest pair of points.
         */
        public double FindMinDistinc(int n)
        {
            Point2D[] array = new Point2D[n];
            Random ran = new Random((int)DateTime.Now.ToOADate());
            for (int i = 0; i < n; i++)
            {
                Point2D p = new Point2D()
                {
                    x = ran.NextDouble(),
                    y = ran.NextDouble()
                };
                array[i] = p;
            }

            double minDis = double.MaxValue;
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    double dist = Math.Sqrt(Math.Pow((array[i].x - array[j].x), 2) + Math.Pow((array[i].y - array[j].y), 2));
                    minDis = dist < minDis ? dist : minDis;
                }
            }
            return minDis;
        }
    }

    public class Point2D
    {
        public double x;
        public double y;
    }
}
