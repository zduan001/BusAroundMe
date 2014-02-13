using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.From_001_To_025
{
    public class _009_TreeTravelRelated
    {
        /// <summary>
        /// interative travel tree inorder.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public string InorderTravel(TreeNode root)
        {
            StringBuilder sb = new StringBuilder();
            Stack<TreeNode> s = new Stack<TreeNode>();
            bool backTrack = false;
            s.Push(root);

            while (s.Count != 0)
            {
                TreeNode node = s.Peek();
                if (!backTrack && node.LeftChild != null)
                {
                    s.Push(node.LeftChild);
                    continue;
                }

                node = s.Pop();
                sb.Append(node.Value + ",");
                backTrack = true;

                if (node.RightChild != null)
                {
                    s.Push(node.RightChild);
                    backTrack = false;
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Postorder interative tree travel..
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public string PostOrderTravel(TreeNode root)
        {
            StringBuilder sb = new StringBuilder();
            Stack<TreeNode> s = new Stack<TreeNode>();
            bool backTrack = false;
            TreeNode prev = null;
            s.Push(root);

            while (s.Count != 0)
            {
                TreeNode node = s.Peek();
                if (!backTrack && node.LeftChild != null)
                {
                    s.Push(node.LeftChild);
                    continue;
                }
                if (backTrack && node.RightChild != null && prev != node.RightChild)
                {
                    s.Push(node.RightChild);
                    continue;
                }

                node = s.Pop();
                prev = node;
                sb.Append(node.Value + ",");
                backTrack = true;
            }

            return sb.ToString();
        }
    }
}
