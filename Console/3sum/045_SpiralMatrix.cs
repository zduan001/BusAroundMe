using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _045_SpiralMatrix
    {

        /// <summary>
        /// Given a matrix of m x n elements (m rows, n columns), return all elements of the matrix in spiral order.
        /// For example,
        /// Given the following matrix:
        /// [
        /// [ 1, 2, 3 ],
        /// [ 4, 5, 6 ],
        /// [ 7, 8, 9 ]
        /// ]
        ///  You should return [1,2,3,6,9,8,7,4,5].
        /// </summary>
        /// <param name="intput"></param>
        /// <returns></returns>
        public string PrintOutMatrixSpiral(int[,] input, int m , int n)
        {
            if (m == 0 || n == 0) return string.Empty;
            if (m == 1 && n == 1) return input[0, 0].ToString();


            StringBuilder res = new StringBuilder();

            int startX = 0;
            int startY = 0;
            int endX = m-1;
            int endY = n-1;

            while(startX<=endX && startY <= endY)
            {
                for (int i = startX; i <= endX; i++)
                {
                    res.Append(input[startY, i]);
                    res.Append(",");
                }
                startY++;
                // need to check if startX, startY or endX, endY have crossed.
                if (startY > endY || startX > endX) break;


                for (int j = startY; j <= endY; j++)
                {
                    res.Append(input[j, endX]);
                    res.Append(",");
                }
                endX--;
                if (startY > endY || startX > endX) break;


                for (int i = endX; i >= startX; i--)
                {
                    res.Append(input[endY, i]);
                    res.Append(",");
                }
                endY--;
                if (startY > endY || startX > endX) break;

                for (int j = endY; j >= startY; j--)
                {
                    res.Append(input[j, startX]);
                    res.Append(",");
                }
                startX++;
                if (startY > endY || startX > endX) break;
            }
            return res.ToString();
        }


    }
}
