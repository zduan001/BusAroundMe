using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherQuestions.cs
{
    public class _015_SodukoSolver
    {
        /*
         * Write a program to solve a Sudoku puzzle by filling the empty cells.
            Empty cells are indicated by the char '.'.
            You may assume that there will be only one unique solution.
         */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="board"> </param>
        public void SudokuSolver(int[,] board, int level, int iStart, int jStart)
        {
            // check board, not null , size = 9....
            Debug.WriteLine("--------- Enter Level " + level.ToString() + " -----------------");
            if (level == 63)
            {
                return;
            }
            for (int i = iStart; i < 9; i++)
            {
                for (int j = jStart; j < 9; j++)
                {
                    if (board[i, j] == -1)
                    {
                        for (int k = 0; k < 9; k++)
                        {
                            if (Test(board, i, j, k))
                            {
                                board[i, j] = k;
                                SudokuSolver(board, level + 1, i, j);
                                board[i, j] = -1;
                            }
                        }
                    }
                    else
                    {
                        level ++;
                    }
                }
            }
            //if (Verify(board))
            //{
            //    PrintOutBoard(board);
            //}
            Debug.WriteLine("--------- Finish Level " + level.ToString() + " -----------------");
        }

        private bool Test(int[,] board, int i, int j, int value)
        {
            for (int l = 0; l < 9; l++)
            {
                if (board[l, j] == value)
                {
                    return false;
                }
                if (board[i, l] == value)
                {
                    return false;
                }
            }

            for (int l = (i / 3) * 3; l < ((i / 3) * 3 + 3); l++)
            {
                for (int m = (j / 3) * 3; m < ((j / 3) * 3 + 3); m++)
                {
                    if (board[l, m] == value)
                        return false;
                }
            }
            return true;
        }

        public bool Verify(int[,] board)
        {
            //verify rows
            int[] row = new int[9];
            for (int i = 0; i < 9; i++)
            {
                for (int k = 0; k < 9; k++)
                {
                    row[k] = 0;
                }
                for (int j = 0; j < 9; j++)
                {
                    row[board[i, j]] = 1;
                }
                for (int k = 0; k < 9; k++)
                {
                    if (row[k] == 0)
                    {
                        return false;
                    }
                }
            }

            // verify columns
            int[] column = new int[9];
            for (int j = 0; j < 9; j++)
            {
                for (int k = 0; k < 9; k++)
                {
                    column[k] = 0;
                }
                for (int i = 0; i < 9; i++)
                {
                    column[board[i, j]] = 1;
                }

                for (int k = 0; k < 9; k++)
                {
                    if (column[k] == 0)
                    {
                        return false;
                    }
                }
            }

            // verify blocks
            int[] block = new int[9];
            for (int i = 0; i < 9; i = i + 3)
            {
                for (int j = 0; j < 9; j = j + 3)
                {
                    for (int k = 0; i < 9; k++)
                    {
                        block[k] = 0;
                    }


                    for (int r = 0; r < 3; r++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            block[board[i + r, j + c]] = 1;
                        }
                    }

                    for (int k = 0; i < 9; k++)
                    {
                        if (block[k] == 0)
                        {
                            return false;
                        }
                    }

                }

            }
            return true;
        }

        public void PrintOutBoard(int[,] board)
        {
            Debug.Write("******************** one solution ****************************");
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Debug.Write((board[i, j] + 1) + "  ");
                }
                Debug.Write("\n");
            }
        }
    }
}
