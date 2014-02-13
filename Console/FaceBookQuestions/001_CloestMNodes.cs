using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookQuestions
{
    public class _001_CloestMNodes
    {
        /* Difficulty: ***
         * 给一个N个node的BST，给一个Key，返回与key最接近的m个node(m<N). 
         * http://www.mitbbs.com/article_t/JobHunting/32268547.html
         */
        public List<TreeNode> FindClosestNodes(TreeNode root, int k, int key) //O(n) I have ignore the reverse q. because I can use a double-end-queue
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);
            bool isBackTrack = false;
            while (s.Count > 0)
            {
                TreeNode tmp = s.Peek();
                if (tmp.LeftChild != null && !isBackTrack)
                {
                    s.Push(tmp.LeftChild);
                    continue;
                }

                tmp = s.Pop();
                isBackTrack = true;

                if (q.Count == k)
                {
                    if (Math.Abs(q.Last().Value - key) < Math.Abs(tmp.Value - key))
                    {
                        break;
                    }
                    else
                    {
                        q.Reverse();
                        q.Dequeue();
                        q.Reverse();
                        q.Enqueue(tmp);
                    }
                }
                else
                {
                    q.Enqueue(tmp);
                }

                if (tmp.RightChild != null)
                {
                    s.Push(tmp.RightChild);
                    isBackTrack = false;
                    continue;
                }
            }

            return q.ToList();
        }
    }
}
