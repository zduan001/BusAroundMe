using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _027_InOrderTraversal
    {
        /*
         * In order traversal tree.
         */
        public List<int> Inorder(TreeNode root)
        {
            List<int> res = new List<int>();
            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);
            bool isBackTrack = false;
            while (s.Count != 0)
            {
                TreeNode tmp = s.Peek();
                if (!isBackTrack && tmp.LeftChild != null)
                {
                    s.Push(tmp.LeftChild);
                    isBackTrack = false;
                }
                else
                {
                    res.Add(tmp.Value);
                    s.Pop();
                    isBackTrack = true;

                    if (tmp.RightChild != null)
                    {
                        s.Push(tmp.RightChild);
                        isBackTrack = false;
                    }
                }
            }
            return res;
        }
    }
}
