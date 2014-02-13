using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _049_SetMatrixZero
    {
        /// <summary>
        /// Given a m x n matrix, if an element is 0, set its entire row and column to 0. Do it in place.
        /// </summary>
        /// <param name="input"></param>
        public void SetZerosInMatrix(List<List<int>> input)
        {
            List<int> rows = new List<int>();
            List<int> columns = new List<int>();

            for (int i = 0; i < input[0].Count; i++)
            {
                for (int j = 0; j < input.Count; j++)
                {
                    if(input[j][i] == 0)
                    {
                        if(!rows.Contains(j))
                            rows.Add(j);
                        if(!columns.Contains(i)) 
                            columns.Add(i);
                    }
                }
            }

            for (int i = 0; i < input[0].Count; i++)
            {
                for (int j = 0; j < input.Count; j++)
                {
                    if(rows.Contains(j) || columns.Contains(i))
                    {
                        input[j][i] = 0;
                    }
                }
            }
        }
    }
}
