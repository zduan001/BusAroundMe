using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Console2.From_001_To_025
{
    /*
     * There is a n x n matrix of letters. and a dictionary, find all the possible words in the matrix. 
     * you can travel all 8 directions by one letter can be used only once in a word.
     * only select word is at least 3 letters long.
     */
    /// <summary>
    /// I used about 3 hours finally get the code working with recursive................
    /// I need to remember the recursive. it is one of my weakness.
    /// </summary>
    public class _020_WordSearch
    {
        public List<string> FindAllWords(char[,] input, int n, HashSet<string> dictionary)
        {
            List<string> res = new List<string>();
            Stack<Point> s = new Stack<Point>();
            BitArray b = new BitArray(n * n);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    String str = new String(input[i,j], 1);
                    TurnOnBit(i, j, n, b);
                    Worker(i-1,j,n,str,dictionary,res,input,b);
                    Worker(i-1,j+1,n,str,dictionary,res,input,b);
                    Worker(i,j+1,n,str,dictionary,res,input,b);
                    Worker(i+1,j+1,n,str,dictionary,res,input,b);
                    Worker(i+1,j,n,str,dictionary,res,input,b);
                    Worker(i+1,j-1,n,str,dictionary,res,input,b);
                    Worker(i,j-1,n,str,dictionary,res,input,b);
                    Worker(i-1,j-1,n,str,dictionary,res,input,b);
                    TurnOffBit(i, j, n, b);
                    #region while
                    //s.Clear();
                    //s.Push(new Point(i, j, Direction.Top));
                    //TurnOnBit(i, j, n, b);

                    //while (s.Count != 0 && s.Count <= n * n)
                    //{
                    //    if (s.Count >= 3)
                    //    { 
                    //        CheckWords(s, input, dictionary, res);
                    //    }
                    //    Point p = s.Peek();
                    //    int x, y;
                    //    switch (p.Dir)
                    //    {
                    //        case Direction.Top:
                    //            x = p.X;
                    //            y= p.Y -1;
                    //            if (!PushIfRight(x, y, n, s, b))
                    //            {
                    //                p.Dir++;
                    //            }
                    //            break;
                    //        case Direction.TopRight:
                    //            x = p.X + 1;
                    //            y = p.Y -1;
                    //            if (!PushIfRight(x, y, n, s, b))
                    //            {
                    //                p.Dir++;
                    //            }
                    //            break;
                    //        case Direction.Right:
                    //            x = p.X+1;
                    //            y = p.Y;
                    //            if (!PushIfRight(x, y, n, s, b))
                    //            {
                    //                p.Dir++;
                    //            }
                    //            break;
                    //        case Direction.LowerRight:
                    //            x = p.X + 1;
                    //            y = p.Y + 1;
                    //            if (!PushIfRight(x, y, n, s, b))
                    //            {
                    //                p.Dir++;
                    //            }
                    //            break;
                    //        case Direction.Low:
                    //            x = p.X;
                    //            y = p.Y + 1;
                    //            if (!PushIfRight(x, y, n, s, b))
                    //            {
                    //                p.Dir++;
                    //            }
                    //            break;
                    //        case Direction.LowerLeft:
                    //            x = p.X - 1;
                    //            y = p.Y + 1;
                    //            if (!PushIfRight(x, y, n, s, b))
                    //            {
                    //                p.Dir++;
                    //            }
                    //            break;
                    //        case Direction.Left:
                    //            x = p.X - 1;
                    //            y = p.Y;
                    //            if (!PushIfRight(x, y, n, s, b))
                    //            {
                    //                p.Dir++;
                    //            }
                    //            break;
                    //        case Direction.UpperLeft:
                    //            x = p.X - 1;
                    //            y = p.Y - 1;
                    //            if (!PushIfRight(x, y, n, s, b))
                    //            {
                    //                p.Dir++;
                    //            }
                    //            break;
                    //        case Direction.None:
                    //            Point remove = s.Pop();
                    //            TurnOffBit(remove.X, remove.Y, n, b);
                    //            remove = s.Peek();
                    //            remove.Dir++;
                    //            break;
                    //    }
                    //}
                    #endregion
                }
            }
            return res;
        }

        private void CheckWords(Stack<Point> s, char[,] input, HashSet<string> dictionary, List<string> res)
        {
            Point[] points= new Point[100];
            s.CopyTo(points, 0);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Count; i++)
            {
                int x = points[i].X;
                int y = points[i].Y;
                sb.Append(input[x, y]);
            }

            if (dictionary.Contains(sb.ToString()))
            {
                res.Add(sb.ToString());
            }
        }

        private void Worker(int i, int j, int n, string s, HashSet<string> dictionary, List<string> res, char[,] input, BitArray b)
        {
            if(i<0 || i>=n ||j<0 ||j>=n) return;
            if (b[i * n + j]) return;
            s = s+ input[i,j];
            TurnOnBit(i, j, n, b);
            if(s.Length>3 && dictionary.Contains(s))
            {
                res.Add(s);
            }

            Worker(i-1,j,n,s,dictionary,res,input,b);
            Worker(i-1,j+1,n,s,dictionary,res,input,b);
            Worker(i,j+1,n,s,dictionary,res,input,b);
            Worker(i+1,j+1,n,s,dictionary,res,input,b);
            Worker(i+1,j,n,s,dictionary,res,input,b);
            Worker(i+1,j-1,n,s,dictionary,res,input,b);
            Worker(i,j-1,n,s,dictionary,res,input,b);
            Worker(i-1,j-1,n,s,dictionary,res,input,b);
            TurnOffBit(i, j, n, b);

        }

        private bool PushIfRight(int i, int j, int n, Stack<Point> s, BitArray b)
        {
            if (i >= 0 && i < n && j >= 0 && j < n && !b[i * n + j])
            {
                s.Push(new Point(i, j, Direction.Top));
                TurnOnBit(i, j, n, b);
                return true;
            }
            return false;
        }

        private void TurnOnBit(int i, int j, int n, BitArray bitArray)
        {
            bitArray[i * n + j] = true;
        }

        private void TurnOffBit(int i, int j, int n, BitArray bitArray)
        {
            bitArray[i * n + j] = false;
        }
    }

    public class Point
    {
        public Point(int x, int y, Direction d)
        {
            X = x;
            Y = y;
            Dir = d;
        }

        public int X { get; set; }
        public int Y {get;set;}
        public Direction Dir { get; set; }
        
    }

    public enum Direction
    {
        Top,
        TopRight,
        Right,
        LowerRight,
        Low,
        LowerLeft,
        Left,
        UpperLeft, 
        None
    }
}
