using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.G_Code
{
    /*
        Find deepest nodes in a binary tree.
        Q: binary search tree? A: no
        Q: all of the deepest nodes, or just one? A: find the right-most deepest node
     */
    /// <summary>
    /// the following method is basically a indorder traversal which keep track the maxDepth while
    /// pop up node. I used (s.Count+1 >= maxDepth) so I can keep the last deepest node.
    /// 
    /// or I can use BFS and keep the last node in the queue.
    /// </summary>
    class G_054_DeppestNode
    {
        public TreeNode FindDeepestNode(TreeNode root)
        {
            int maxDepth = int.MinValue;
            TreeNode res = null;
            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);
            bool IsbackTrack = false;

            while (s.Count != 0)
            {
                TreeNode tmp = s.Peek();
                if (!IsbackTrack && tmp.LeftChild != null)
                {
                    s.Push(tmp.LeftChild);
                    continue;
                }

                tmp = s.Pop();
                IsbackTrack = true;
                if (s.Count + 1 >= maxDepth)
                {
                    maxDepth = s.Count + 1;
                    res = tmp;
                }

                if (tmp.RightChild != null)
                {
                    s.Push(tmp.RightChild);
                    IsbackTrack = false;
                }
            }
            return res;
        }
    }
}
