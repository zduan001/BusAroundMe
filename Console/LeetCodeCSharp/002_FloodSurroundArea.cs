using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _002_FloodSurroundArea
    {
        /*http://leetcode.com/onlinejudge#question_130
            input:
        ["OOOOOO","OXXXXO","OXOOXO","OXOOXO","OXXXXO","OOOOOO"] 
          expect output:
        ["OOOOOO","OXXXXO","OXOOXO","OXOOXO","OXXXXO","OOOOOO"] 
        */
        public List<List<FloodNode>> FloodBitMap(List<List<FloodNode>> input)
        {
            Queue<FloodNode> q = new Queue<FloodNode>();
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input[0].Count; j++)
                {
                    if (input[i][j].value == 'o' && !input[i][j].visited)
                    {
                        if(i ==0 || j ==0)
                        {
                            input[i][j].NotBeAbleToBeReset = true;
                        }
                        q.Enqueue(input[i][j]);
                        FindArea(i, j, q, input, input[0].Count, input.Count);
                        bool connectOuter = false;
                        foreach (FloodNode node in q)
                        {
                            if (node.NotBeAbleToBeReset)
                            {
                                connectOuter = true;
                                break;
                            }
                        }

                        if (connectOuter)
                        {
                            foreach (FloodNode node in q)
                            {
                                node.NotBeAbleToBeReset = true;
                            }
                        }
                        else
                        {
                            foreach (FloodNode node in q)
                            {
                                node.value = 'x';
                            }
                        }
                    }
                    q.Clear();
                }
            }

            return input;
        }

        public void FindArea(int i, int j, Queue<FloodNode> nodelist,List<List<FloodNode>> input, int length, int height)
        {
            for (int m = i - 1; m <= i + 1; m++)
            {
                for (int k = j - 1; k <= j + 1; k++)
                {
                    if ((((m == i-1 || m == i+1 )&& k == j ) || ((k == j-1 ||k == j+1) && m == i)) && 
                        m >= 0 && m < height &&
                        k >= 0 && k < length &&
                        input[m][k].value == 'o' &&
                        !input[m][k].visited)
                    {
                        input[m][k].visited = true;
                        nodelist.Enqueue(input[m][k]);
                        FindArea(m, k, nodelist, input, length, height);
                    }

                }
            }
        }
    }

    public class FloodNode
    {
        public Char value;
        public bool visited;
        public bool NotBeAbleToBeReset;
        
    }
}
