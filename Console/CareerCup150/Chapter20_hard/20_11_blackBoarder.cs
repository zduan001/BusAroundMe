using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150
{
    public class _20_11_blackBoarder
    {
        /*
         * The following method find a sub matrix are solid black.
         */
        public int FindBlackSubMatrix(char[,] input, int n)
        {
            int[,] tracker = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                tracker[i, 0] = input[i, 0] == 'b' ? 1 : 0;
                for (int j = 1; j < n; j++)
                {
                    tracker[i, j] = input[i, j] == 'b' ? tracker[i, j - 1] + 1 : 0;
                }
            }

            int max = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int length = tracker[i, j];
                    int row = 1;
                    while (i - row >= 0 && tracker[i - row, j] > 0)
                    {
                        if (tracker[i - row, j] < length)
                        {
                            length = tracker[i - row, j];
                        }
                        row++;
                    }
                    int tmp = length * row;
                    max = tmp > max ? tmp : max;
                }
            }

            return max;
        }
    }
}
