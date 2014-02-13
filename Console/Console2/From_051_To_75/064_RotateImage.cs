using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_051_To_75
{
    public class _064_RotateImage
    {
        /*
            You are given an n x n 2D matrix representing an image.
            Rotate the image by 90 degrees (clockwise).
            Follow up:
             Could you do this in-place?
         */
        /// <summary>
        /// For this question just be carefully, draw 4 points in a 2 dimension array  and mark 
        /// the distance to edges. and rotate them one by one.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[,] RotateImage(int[,] input, int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i; j < n - i; j++)
                {
                    int tmp = input[i, j];
                    input[i, j] = input[n - j, i];
                    input[n - j, i] = input[n - i, n - j];
                    input[n - i, n - j] = input[j, n - i];
                    input[j, n - i] = tmp;
                }
            }

            return input;
        }
    }
}
