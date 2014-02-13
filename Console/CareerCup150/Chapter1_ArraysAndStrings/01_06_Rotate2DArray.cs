using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapt1_ArraysAndStrings
{
    public class _01_06_Rotate2DArray
    {
        /*
         * Given an image represented by an NxN matrix, where each pixel in the image is 4 bytes, write a method to rotate the image by 90 degrees. Can you do this in place?
         */
        public int[,] Rotate(int[,] input)
        {
            int n = input.GetLength(0);
            int m = input.GetLength(1);

            for (int layer = 0; layer < n / 2; layer++)
            {
                int first = layer;
                int last = n - 1 - layer;
                for (int i = layer; i < last; i++)
                {
                    int offset = i - first;
                    int top = input[first, i]; // save top;
                    //left -> top
                    input[first, i] = input[last - offset, first];

                    //bottom -> left
                    input[last - offset, first] = input[last, last - offset];

                    //right -> bottom
                    input[last, last - offset] = input[i, last];

                    //top -> right
                    input[i, last] = top; // right <- saved top
                }
            }

            return input;

        }
    }
}
