using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _073_WordSearch
    {
        /*
         Given a 2D board and a word, find if the word exists in the grid.
        The word can be constructed from letters of sequentially adjacent cell, where "adjacent" cells are those horizontally or vertically neighboring. The same letter cell may not be used more than once.
        For example,
        Given board =
        [
         ["ABCE"],
         ["SFCS"],
         ["ADEE"]
        ]
        word = "ABCCED", -> returns true,
        word = "SEE", -> returns true,
        word = "ABCB", -> returns false.
         */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="board"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool WordSearch(List<List<char>> board, string word)
        {
            HashSet<Point> visitedPoints = new HashSet<Point>();
            Stack<Point> s = new Stack<Point>();

            for (int i = 0; i < board.Count; i++)
            {
                for (int j = 0; j < board[0].Count; j++)
                {
                    if (board[i][j] == word[0])
                    {
                        visitedPoints.Clear();
                        visitedPoints.Add(new Point(i, j));
                        s.Clear();
                        s.Push(new Point(i, j));

                        while (!(s.Count == 0))
                        {
                            if (s.Count == word.Length) return true;

                            Point top = s.Peek();
                            if (top.X - 1 >= 0 && board[top.X - 1][top.Y] == word[s.Count] && !visitedPoints.Contains(new Point(top.X - 1, top.Y)))
                            {
                                s.Push(new Point(top.X - 1, top.Y));
                                visitedPoints.Add(new Point(top.X - 1, top.Y));
                                continue;
                            }
                            else if(top.X +1 < board.Count && board[top.X +1][top.Y] == word[s.Count] && !visitedPoints.Contains(new Point(top.X + 1, top.Y)))
                            {
                                s.Push(new Point(top.X + 1, top.Y));
                                visitedPoints.Add(new Point(top.X + 1, top.Y));
                                continue;
                            }
                            else if (top.Y - 1 >= 0 && board[top.X][top.Y-1] == word[s.Count] && !visitedPoints.Contains(new Point(top.X, top.Y-1)))
                            {
                                s.Push(new Point(top.X, top.Y-1));
                                visitedPoints.Add(new Point(top.X, top.Y-1));
                                continue;
                            }
                            else if (top.Y + 1 < board[0].Count && board[top.X][top.Y + 1] == word[s.Count] && !visitedPoints.Contains(new Point(top.X, top.Y + 1)))
                            {
                                s.Push(new Point(top.X, top.Y + 1));
                                visitedPoints.Add(new Point(top.X, top.Y + 1));
                                continue;
                            }
                            else
                            {
                                s.Pop();
                            }
                        }
                    }
                }
            }
            return false;
        }

        public class Point
        {
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; set; }
            public int Y { get; set; }


            /// <summary>
            ///  This method doesn't work in hashset contains? weired.
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                if (!(obj is Point))
                {
                    return false;
                }
                else
                {
                    Point p = obj as Point;
                    if (p == null)
                    {
                        return false;
                    }
                    else
                    {
                        if (p.X != X || p.Y != Y)
                        {
                            return false;
                        }
                    }

                }
                return true;
            }
        }
    }
}
