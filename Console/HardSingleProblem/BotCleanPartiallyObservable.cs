using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardSingleProblem
{
    public class BotCleanPartiallyObservable
    {
        public void next_move(int posx, int posy, String[] board)
        {
            int x = -1;
            int y = -1;
            bool[,] visited = new bool[,]{
                                        {false,false,false,false,false},
                                        {false,false,false,false,false},
                                        {false,false,false,false,false},
                                        {false,false,false,false,false},
                                        {false,false,false,false,false}};

            FileStream fs = new FileStream("visited.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string visitedstr = sr.ReadToEnd();
            if (!string.IsNullOrEmpty(visitedstr))
            {
                string[] visitedStrArr = visitedstr.Split(' ');

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (visitedStrArr[i][j] == 'y')
                        {
                            visited[i, j] = true;
                        }
                    }
                }
            }
            sr.Close();
            fs.Close();
            visited[posx, posy] = true;

            visitedstr = string.Empty;
            for (int i = 0; i < 5; i++)
            {
                string tmp = string.Empty;
                for (int j = 0; j < 5; j++)
                {
                    tmp += visited[i, j] ? "y" : "n";
                }
                visitedstr = visitedstr + tmp + " ";
            }

            fs = new FileStream("visited.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(visitedstr);
            sw.Close();
            fs.Close();

            bool foundDirty = false;
            for (int i = posx - 1; i <= posx + 1; i++)
            {
                for (int j = posy - 1; j <= posy + 1; j++)
                {
                    if (i >= 0 && i < 5 && j >= 0 && j < 5)
                    {
                        if (board[i][j] == 'd')
                        {
                            x = i;
                            y = j;
                            foundDirty = true;
                            break;
                        }
                    }
                }
                if (foundDirty)
                    break;
            }
            if (posx == x && posy == y)
            {
                Console.WriteLine("CLEAN");
                return;
            }

            if (x == -1 && y == -1)
            {
                bool foundEmpty = false;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (!visited[i, j])
                        {
                            x = i;
                            y = j;
                            foundEmpty = true;
                            break;
                        }
                    }
                    if (foundEmpty)
                        break;
                }
                if (!foundEmpty)
                {
                    return;
                }
            }

            if (posx < x)
            {
                Console.WriteLine("DOWN");
                return;
            }
            else if (posx > x)
            {
                Console.WriteLine("UP");
                return;
            }
            else if (posy < y)
            {
                Console.WriteLine("RIGHT");
                return;
            }
            else if (posy > y)
            {
                Console.WriteLine("LEFT");
                return;
            }
        }

        //public static bool[,] visited = new bool[,]{
        //{false,false,false,false,false},
        //{false,false,false,false,false},
        //{false,false,false,false,false},
        //{false,false,false,false,false},
        //{false,false,false,false,false}};
    }
}
