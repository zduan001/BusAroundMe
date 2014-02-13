using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleQuestions
{
    public class _005_2DWater
    {
        public int FindCapacity(point[,] input, int n)
        {

            List<point> priQueue = new List<point>();
            int maxHeight = -1;
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                priQueue.Add(input[i, 0]);
                input[i, 0].visited = true;
                priQueue.Add(input[i, n - 1]);
                input[i, n - 1].visited = true;
            }
            for (int j = 1; j < n - 1; j++)
            {
                priQueue.Add(input[0,j]);
                input[0, j].visited = true;
                priQueue.Add(input[n-1,j]);
                input[n - 1, j].visited = true;
            }

            while (priQueue.Count != 0)
            {
                priQueue = priQueue.OrderBy(s => s.Height).ToList();
                point tmp = priQueue[0];
                priQueue.RemoveAt(0);

                if(maxHeight<tmp.Height)
                {
                    maxHeight = tmp.Height;
                }

                for (int i = tmp.i - 1; i <= tmp.i + 1; i++)
                {
                    for (int j = tmp.j - 1; j <= tmp.j + 1; j++)
                    {
                        if (i >= 0 && i < n && j >= 0 && j < n && !input[i,j].visited)
                        {
                            if (input[i, j].Height < maxHeight)
                            {
                                res += (maxHeight - input[i, j].Height);
                                input[i, j].visited = true;
                            }
                            else
                            {
                                priQueue.Add(input[i, j]);
                                input[i, j].visited = true;
                            }

                        }
                    }
                }
            }
            return res;
        }
    }

    public struct point
    {
        public int Height { get; set; }
        public bool visited { get; set; }
        public int i { get; set; }
        public int j { get; set; }
    }
}
