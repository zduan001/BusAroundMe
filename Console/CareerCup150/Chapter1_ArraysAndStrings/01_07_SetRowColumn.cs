using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapt1_ArraysAndStrings
{
    public class _01_07_SetRowColumn
    {
        /*
         * Write an algorithm such that if an element in an MxN matrix is 0, its entire row and column is set to 0.
         */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int[,] SetZero(int[,] input)
        {
            HashSet<int> rows = new HashSet<int>();
            HashSet<int> columns = new HashSet<int>();

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    if (input[i, j] == 0)
                    {
                        if (!rows.Contains(i))
                            rows.Add(i);
                        if (!columns.Contains(j))
                            columns.Add(j);
                    }
                }
            }

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    if (rows.Contains(i) || columns.Contains(j))
                    {
                        input[i, j] = 0;
                    }
                }
            }

            return input;
        }
    }
}
