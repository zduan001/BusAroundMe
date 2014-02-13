using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookQuestions
{
    public class _004_2DArrayIn1DArray
    {
        /*
         * 用一个数组来表示二维数组，但是每一行的元素个数可以不同，实现get，set函数
         * http://www.mitbbs.com/article_t/JobHunting/32268547.html
         * my thought:
         * 1. first I assume the function signature are get(i,j) and set(i,j).
         * 2. there should be another array or list to store the length of each row.
         *    or the array should store the start index of each row.
         */
        private int[] array;
        private int[] rowsOffset;

        public _004_2DArrayIn1DArray(int[] input, int[] rowsLength)
        {
            this.array = input;
            this.rowsOffset = new int[rowsLength.Length+1];
            for (int i = 0; i < rowsLength.Length; i++)
            {
                rowsOffset[i + 1] = rowsOffset[i] + rowsLength[i];
            }
        }

        public int Get(int rowsIndex, int column)
        {
            int index = rowsOffset[rowsIndex] + column;
            return array[index];
        }

        public bool Set(int rowIndex, int column, int value)
        {
            int index = rowsOffset[rowIndex] + column;
            if (index < array.Length)
            {
                array[index] = value;
                return true;
            }
            return false;
        }
    }
}
