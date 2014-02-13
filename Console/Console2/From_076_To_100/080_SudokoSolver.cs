using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_076_To_100
{
    public class _080_SudokoSolver
    {
        /*
        Write a program to solve a Sudoku puzzle by filling the empty cells.
        Empty cells are indicated by the character '.'.
        You may assume that there will be only one unique solution. 
         */
        /// <summary>
        /// I think I understand the problem and how to solve it.
        /// do I plan not to do unit test for this method. hope I
        /// am right.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool SolveSudoku(char[,] input)
        {
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for(int j = 0;j< input.GetLength(1);j++)
                {
                    if (input[i, j] != '.')
                    {
                        for (int k = 1; k <= 9; k++)
                        {
                            char c = Convert.ToChar('0' + k);
                            input[i, j] = c;
                            if (VerifySudoku(input, j, i))
                            {
                                SolveSudoku(input);
                            }
                            input[i, j] = '.';
                        }
                        // if for one node I tried all possible  number 1--9 
                        // then I know there is no solution for this board.
                        return false;
                    }
                }
            }
            return true;
        }

        public bool VerifySudoku(char[,] input, int column, int row)
        {
            return true;
        }
    }
}
