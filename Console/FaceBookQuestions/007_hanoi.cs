using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookQuestions
{
    /*http://www.mitbbs.com/article_t/JobHunting/32342207.html
     * There are K pegs. Each peg can hold discs in decreasing order of radius when
        looked from bottom to top of the peg. There are N discs which have radius 1
        to N; Given the initial configuration of the pegs and the final 
        configuration of the pegs, output the moves required to transform from the 
        initial to final configuration. You are required to do the transformations 
        in minimal number of moves.

        A move consists of picking the topmost disc of any one of the pegs and 
        placing it on top of anyother peg.
        At anypoint of time, the decreasing radius property of all the pegs must be 
        maintained.

        Constraints:
        1<= N<=8
        3<= K<=5

        Input Format:
        N K
        2nd line contains N integers.
        Each integer in the second line is in the range 1 to K where the i-th 
        integer denotes the peg to which disc of radius i is present in the initial 
        configuration.
        3rd line denotes the final configuration in a format similar to the initial 
        configuration.

        Output Format:
        The first line contains M - The minimal number of moves required to complete
        the transformation.
        The following M lines describe a move, by a peg number to pick from and a 
        peg number to place on.
        If there are more than one solutions, it's sufficient to output any one of 
        them. You can assume, there is always a solution with less than 7 moves and 
        the initial confirguration will not be same as the final one.

        Sample Input #00:

        2 3
        1 1
        2 2
        Sample Output #00:

        3
        1 3
        1 2
        3 2

        Sample Input #01:

        6 4
        4 2 4 3 1 1
        1 1 1 1 1 1
        Sample Output #01:

        5
        3 1
        4 3
        4 1
        2 1
        3 1
     */
    public class _007_hanoi
    {
        public List<Move> SolveNanojShortestPath(int n, int k, int[] initial, int[] final)
        {
            Stack<int>[] s = new Stack<int>[k];
            Stack<int>[] finalstack = new Stack<int>[k];
            for (int i = 0; i < k; i++)
            {
                s[i] = new Stack<int>();
                finalstack[i] = new Stack<int>();
            }

            for (int i = n - 1; i >= 0; i--)
            {
                s[initial[i]].Push(i);
                finalstack[final[i]].Push(i);
            }

            // set final top ready to be check against at.
            int[] finalTop = new int[k];
            for (int i = 0; i < k; i++)
            {
                if (finalstack[i].Count != 0)
                {
                    finalTop[i] = finalstack[i].Peek();
                }
                else
                {
                    finalTop[i] = -1;
                }
            }

            Queue<Move> moves = new Queue<Move>();

            for (int i = 0; i < k; i++)
            {
                for (int j = i + 1; j < k; j++)
                {

                    if (s[i].Count != 0 && s[j].Count != 0)
                    {
                        if (s[i].Peek() < s[j].Peek())
                        {
                            moves.Enqueue(new Move() { From = i, To = j });
                        }
                        else
                        {
                            moves.Enqueue(new Move() { From = j, To = i });
                        }
                    }
                    else
                    {
                        if (s[i].Count == 0 && s[j].Count != 0)
                        {
                            moves.Enqueue(new Move() { From = j, To = i });
                        }
                        else if (s[i].Count != 0 && s[j].Count == 0)
                        {
                            moves.Enqueue(new Move() { From = i, To = j });
                        }
                    }
                }
            }

            int level = 0;
            while (level <= 7 && moves.Count != 0)
            {
                Move tmp = moves.Dequeue();
                int[] top = null;
                Stack<int>[] updated= ApplyMove(s, tmp, ref top);
                if (check(top, finalTop))
                {
                    List<Move> res = new List<Move>();
                    while (tmp != null)
                    {
                        res.Insert(0, tmp);
                        tmp = tmp.previous;
                    }

                    return res;
                }
                else
                {
                    for (int i = 0; i < k; i++)
                    {
                        for (int j = i + 1; j < k; j++)
                        {
                            if ((i == tmp.To || i == tmp.From || j == tmp.To || j == tmp.From) &&
                                !((i == tmp.To && j == tmp.From) || (i == tmp.From && j == tmp.To)))
                            {
                                if (updated[i].Count != 0 && updated[j].Count != 0)
                                {
                                    if (updated[i].Peek() < updated[j].Peek())
                                    {
                                        moves.Enqueue(new Move() { From = i, To = j, previous = tmp });
                                    }
                                    else
                                    {
                                        moves.Enqueue(new Move() { From = j, To = i, previous = tmp });
                                    }
                                }
                                else
                                {
                                    if (updated[i].Count == 0 && updated[j].Count != 0)
                                    {
                                        moves.Enqueue(new Move() { From = j, To = i, previous = tmp });
                                    }
                                    else if (updated[i].Count != 0 && updated[j].Count == 0)
                                    {
                                        moves.Enqueue(new Move() { From = i, To = j, previous = tmp });
                                    }
                                }

                            }
                        }
                    }
                }
            }
            return null;
        }

        public bool check(int[] expected, int[] actual)
        {
            for (int i = 0; i < expected.Length; i++)
            {
                if(expected[i] != actual[i]) 
                    return false;
            }

            return true;
        }


        public Stack<int>[] ApplyMove(Stack<int>[] s, Move move, ref int[] top)
        {
            Stack<int>[] res = new Stack<int>[s.Length];

            Stack<int> tmp = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
            {
                res[i] = new Stack<int>();
                tmp.Clear();
                while (s[i].Count != 0)
                {
                    tmp.Push(s[i].Pop());
                }
                while (tmp.Count != 0)
                {
                    int m = tmp.Pop();
                    res[i].Push(m);
                    s[i].Push(m);
                }
            }

            Stack<Move> sMove = new Stack<Move>();
            Move tmpMove = move;
            sMove.Push(tmpMove);
            while (tmpMove.previous != null)
            {
                tmpMove = tmpMove.previous;
                sMove.Push(tmpMove);
            }

            while (sMove.Count != 0)
            {
                tmpMove = sMove.Pop();
                res[tmpMove.To].Push(res[tmpMove.From].Pop());
            }

            top = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                if (res[i].Count != 0)
                {
                    top[i] = res[i].Peek();
                }
                else
                {
                    top[i] = -1;
                }
            }
            return res;
        }
    }

    public class Move
    {
        public Move previous { get; set; }
        public int From { get; set; }
        public int To { get; set; }
    }
}
