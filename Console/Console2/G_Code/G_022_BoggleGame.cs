using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_022_BoggleGame
    {
        /*
         * http://www.mitbbs.com/article_t/JobHunting/32026403.html
         * Boggle game。从一个字符开始找邻居字符然后继续找，形成一个word。条件是，形成了word之后要继续找，因为可能有更长的word。一旦用了一个字符以后，就不可以重复使用了。
         */
        public List<string> BoggleGame(char[,] board, HashSet<string> Dictionary)
        {
            bool[,] tracker = new bool[board.GetLength(0), board.GetLength(1)];
            string s = string.Empty;
            List<string> res = new List<string>();
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (!tracker[i, j])
                    {
                        Toggle(tracker, i, j);
                        BoggleGameRecursive(board, Dictionary, tracker, s + board[i, j], res, i, j);
                        Toggle(tracker, i, j);
                    }
                }
            }
            return res;
        }


        public void BoggleGameRecursive(char[,] board, HashSet<string> Dictionary, bool[,] tracker, string s, List<string> res,int i, int j)
        {
            if (Dictionary.Contains(s)) res.Add(s);
            if (s.Length == board.GetLength(0) * board.GetLength(1)) return;
            if(Valid(board, tracker, i-1,j))
            {
                Toggle(tracker, i-1, j);
                BoggleGameRecursive(board, Dictionary, tracker, s + board[i - 1, j], res, i - 1, j);
                Toggle(tracker, i - 1, j);
            }

            if (Valid(board, tracker, i + 1, j))
            {
                Toggle(tracker, i + 1, j);
                BoggleGameRecursive(board, Dictionary, tracker, s + board[i + 1, j], res, i + 1, j);
                Toggle(tracker, i + 1, j);
            }

            if (Valid(board, tracker, i , j-1))
            {
                Toggle(tracker, i, j-1);
                BoggleGameRecursive(board, Dictionary, tracker, s + board[i, j-1], res, i, j-1);
                Toggle(tracker, i, j-1);
            }

            if (Valid(board, tracker, i, j + 1))
            {
                Toggle(tracker, i, j + 1);
                BoggleGameRecursive(board, Dictionary, tracker, s + board[i, j + 1], res, i, j + 1);
                Toggle(tracker, i, j + 1);
            }

            if (Valid(board, tracker, i-1, j + 1))
            {
                Toggle(tracker, i-1, j + 1);
                BoggleGameRecursive(board, Dictionary, tracker, s + board[i-1, j + 1], res, i-1, j + 1);
                Toggle(tracker, i-1, j + 1);
            }

            if (Valid(board, tracker, i + 1, j + 1))
            {
                Toggle(tracker, i + 1, j + 1);
                BoggleGameRecursive(board, Dictionary, tracker, s + board[i + 1, j + 1], res, i + 1, j + 1);
                Toggle(tracker, i + 1, j + 1);
            }

            if (Valid(board, tracker, i - 1, j - 1))
            {
                Toggle(tracker, i - 1, j - 1);
                BoggleGameRecursive(board, Dictionary, tracker, s + board[i - 1, j + 1], res, i - 1, j - 1);
                Toggle(tracker, i - 1, j - 1);
            }

            if (Valid(board, tracker, i + 1, j - 1))
            {
                Toggle(tracker, i + 1, j - 1);
                BoggleGameRecursive(board, Dictionary, tracker, s + board[i + 1, j + 1], res, i + 1, j - 1);
                Toggle(tracker, i + 1, j - 1);
            }
        }

        private bool Valid(char[,] board, bool[,] tracker, int i, int j)
        {
            if (i < 0 || i >= board.GetLength(0)) return false;
            if (j < 0 || j >= board.GetLength(1)) return false;
            if (tracker[i, j]) return false;
            return true;
        }

        private void Toggle(bool[,] tracker, int i, int j)
        {
            tracker[i, j] = !tracker[i, j];
        }
    }
}
