using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapter8_Recursion
{
    public class _08_06_PaintAll
    {
        /*
         * Implement the “paint fill” function that one might see on many image editing programs. 
         * That is, given a screen (represented by a 2 dimensional array of Colors), a point, and 
         * a new color, fill in the surrounding area until you hit a border of that color.’
         */
        public void PaintAll(int[,] input, int i, int j, int color)
        {
            int width = input.GetLength(0);
            int height = input.GetLength(1);
            bool[,] tracker = new bool[width, height];
            WorkerMethod(input, tracker, input[i, j], i, j);

            for(int l = 0;l<width; l++)
            {
                for (int m = 0; m < height; m++)
                {
                    if (tracker[l,m])
                    {
                        input[l, m] = color;
                    }
                }
            }
        }

        public void WorkerMethod(int[,] input, bool[,] tracker, int color, int i, int j)
        {
            if (!IsValidate(input, i,j) || input[i, j] != color || tracker[i,j])
            {
                return;
            }
            else
            {
                tracker[i, j] = true;
                WorkerMethod(input, tracker, color, i - 1, j);
                WorkerMethod(input, tracker, color, i + 1, j);
                WorkerMethod(input, tracker, color, i, j-1);
                WorkerMethod(input, tracker, color, i, j+1);
            }
        }

        public bool IsValidate(int[,] input, int i, int j)
        {
            int width = input.GetLength(0);
            int height = input.GetLength(1);
            if (i < 0 || i >= width || j < 0 || j >= height)
            {
                return false;
            }
            return true;
        }
    }
}
