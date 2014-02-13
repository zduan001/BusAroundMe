using BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyQuestions
{
    public class AlgII_Week1
    {
        /*
         * Verify if a graph is bi parties
         */
        public bool VerifyBiparties(GraphAdjacence<char> input)
        {
            // use CC_Id as party identifier.

            foreach (GraphNode<char> n in input.Nodes)
            {
                if (n.State == VisitState.NotVisted)
                {
                    if (!(Travel(n, 1)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// DFS search and assign each not visisted node into a group. if visied check if biparties rule hold.
        /// if rule is not hold. return false.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="groupId"></param>
        /// <returns></returns>
        private bool Travel(GraphNode<char> node, int groupId)
        {
            foreach (KeyValuePair<GraphNode<char>, int> n in node.Neiborghs)
            {
                if (n.Key.State == VisitState.NotVisted)
                {
                    n.Key.State = VisitState.Visited;
                    n.Key.CC_Id = -groupId;
                    if (!Travel(n.Key, -groupId))
                    {
                        return false;
                    }
                }
                else
                {
                    if (n.Key.CC_Id == groupId)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
