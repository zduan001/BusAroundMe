using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherQuestions.cs
{
    public class _006_SearchInMatrix
    {
        /*
         * 一个矩阵行列都是递增序， 查找一个数
         */
        public int FindInMatrix(int[,] input, int value)
        {
            if (input == null)
            {
                // throw exception
                return -1;
            }
            int top = 0;
            int bottom = input.GetLength(0)-1;
            int right = input.GetLength(1)-1;
            int mid = -1;
            while (top <= bottom)
            {
                mid = (top + bottom) / 2;
                if (value >= input[mid, 0] && value <= input[mid, right])
                {
                    break;
                }
                if (value < input[mid, 0])
                {
                    bottom = mid - 1;
                }
                else
                {
                    top = mid + 1;
                }
            }

            int left = 0;
            while (left <= right)
            {
                int tmp = (left + right) / 2;
                if (input[mid, tmp] == value)
                {
                    return value;
                }
                else
                {
                    if (value < input[mid, tmp])
                    {
                        right = tmp - 1;
                    }
                    else
                    {
                        left = tmp + 1;
                    }
                }
            }
            return int.MinValue;
        }
    }
}
