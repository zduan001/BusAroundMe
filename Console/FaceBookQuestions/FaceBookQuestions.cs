using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookQuestions
{
    public class FaceBookQuestions
    {
        /*
         * http://www.geeksforgeeks.org/forums/topic/facebook-interview-question-for-software-engineerdeveloper-about-algorithms-3/

            Given a set S, find all the maximal subsets whose sum <= k. For example, if S = {1, 2, 3, 4, 5} and k = 7

            Output is: {1, 2, 3} {1, 2, 4} {1, 5} {2, 5} {3, 4}

            Hint:

            - Output doesn’t contain any set which is a subset of other.

            - If X = {1, 2, 3} is one of the solution then all the subsets of X {1} {2} {3} {1, 2} {1, 3} {2, 3} are omitted.

            - Lexicographic ordering may be used to solve it

         */
        public List<List<int>> _009_FindMaxSubSet(int[] input, int k)
        {
            // sort input.
            List<List<int>> res = new List<List<int>>();
            List<int> cur = new List<int>();
            TrackingTreeNode trackingTree = new TrackingTreeNode();
            Tracker(input, cur, res, 0, k);
            return res;
        }

        public bool Tracker(int[] input, List<int> current, List<List<int>> res, int index, int k)
        {
            if (current.Sum() > k)
            {
                List<int> tmp = new List<int>();
                for (int i = 0; i < current.Count - 1; i++)
                {
                    tmp.Add(current[i]);
                }
                res.Add(tmp);
                return true;
            }

            if (current.Sum() == k)
            {
                List<int> tmp = new List<int>();
                for (int i = 0; i < current.Count; i++)
                {
                    tmp.Add(current[i]);
                }
                //Insert(trackingTree,tmp);
                res.Add(tmp);
                return true;
            }

            for (int i = index; i < input.Length; i++)
            {
                current.Add(input[i]);
                bool Found = Tracker(input, current, res,i + 1, k);
                current.Remove(input[i]);

                if (Found) break;
            }

            return false;
        }

        private void Insert(TrackingTreeNode root, List<int> list)
        {
            if (list.Count == 0) return;
            if (!root.dict.Keys.Contains(list[0]))
            {
                root.dict.Add(list[0], new TrackingTreeNode());
            }

            int key = list[0];
            list.RemoveAt(0);
            Insert(root.dict[key], list);

            return;

        }


        public class TrackingTreeNode
        {
            public Dictionary<int, TrackingTreeNode> dict = new Dictionary<int, TrackingTreeNode>();

        }

    }
}
