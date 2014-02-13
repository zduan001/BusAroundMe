using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_038_LiveOrDead
    {
        /*
         * 告诉我一个游戏，叫做“生或者死”，在一个棋盘上，规则如下：
            每格有两种状态：生，或者死
            每一轮，如果有少于两个邻居是活着的，这格就死掉
            如果刚好有两个邻居活着，这格保持原有状态
            如果有三个邻居活着，这格可以重生，就是如果原来是死的，现在活过来了
            如果有三个以上邻居，这格就被挤死了
            要在白板上写每轮如何更新整个棋盘的状态
         */
        /// <summary>
        /// the basia idea is I have to keep the new and old status separated.
        /// </summary>
        /// <param name="input"></param>
        public void Update(Status[][,] input)
        {
            round++;
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    int countOfAlive = 0;
                    countOfAlive += Valide(input, i - 1, j, round);
                    countOfAlive += Valide(input, i + 1, j, round);
                    countOfAlive += Valide(input, i - 1, j - 1, round);
                    countOfAlive += Valide(input, i + 1, j - 1, round);
                    countOfAlive += Valide(input, i - 1, j + 1, round);
                    countOfAlive += Valide(input, i + 1, j + 1, round);
                    countOfAlive += Valide(input, i, j - 1, round);
                    countOfAlive += Valide(input, i, j + 1, round);
                    if (countOfAlive < 2 || countOfAlive > 3)
                    {
                        input[(round + 1) % 2][i, j] = Status.Dead;
                    }
                    else
                    {
                        input[(round + 1) % 2][i, j] = Status.Live;
                    }
                }
            }
        }

        private int Valide(Status[][,] input, int i, int j, int round)
        {
            if (i < 0 || i >= input.GetLength(0) || j < 0 || j >= input.GetLength(1))
            {
                return 0;
            }
            else
            {
                if (input[round % 2][i, j] == Status.Live)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

        }

        private int round = 0;
    }

    public enum Status
    {
        Live,
        Dead
    }
}
