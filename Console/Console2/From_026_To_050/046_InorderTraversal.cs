using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.From_026_To_050
{
    /*
     * Inorder iterative tree travel. 
     */
    public class _046_InorderTraversal
    {
        public StringBuilder sb = new StringBuilder();
        public void InOrderTraversal(TreeNode root)
        {
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
                VisitNode(node);
                backTrack = true;

                if (node.RightChild != null)
                {
                    s.Push(node.RightChild);
                    backTrack = false;
                }
            }
        }

        private void VisitNode(TreeNode node)
        {
            sb.Append(node.Value.ToString() + ",");
        }

        public void InOrderTraversalII(TreeNode root)
        {
            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);
            while (s.Count != 0)
            {
            }
        }
    }

    /*
     * Nothing new, try post order iterative again.
     */
    public class _046_PostOrderTraversal
    {
        public StringBuilder sb = new StringBuilder();
        public void PostOrderTraversal(TreeNode root)
        {
            Stack<TreeNode> s = new Stack<TreeNode>();
            TreeNode prevNode = null;
            bool isBackTrack = false;
            s.Push(root);
            while (s.Count != 0)
            {
                TreeNode node = s.Peek();
                if (!isBackTrack && node.LeftChild != null)
                {
                    s.Push(node.LeftChild);
                    isBackTrack = false;
                }
                else if (isBackTrack && node.RightChild != null && prevNode != node.RightChild)
                {
                    s.Push(node.RightChild);
                    isBackTrack = false;
                    continue;
                }
                else
                {
                    node = s.Pop();
                    VisitNode(node);
                    prevNode = node;
                    isBackTrack = true;
                }
            }
        }

        private void VisitNode(TreeNode node)
        {
            sb.Append(node.Value.ToString() + ",");
        }

        public void PostOrderTraversalII(TreeNode root)
        {
            Stack<TreeNode> s = new Stack<TreeNode>();
            TreeNode prevNode = null;
            s.Push(root);
            while (s.Count != 0)
            {
                TreeNode tmp = s.Peek();

                if (tmp.RightChild != null && tmp.RightChild != prevNode)
                {
                    s.Push(tmp.RightChild);
                    prevNode = null;
                }
                if (tmp.LeftChild != null && tmp.LeftChild != prevNode && (tmp.RightChild == null ||tmp.RightChild != prevNode))
                {
                    s.Push(tmp.LeftChild);
                    prevNode = null;
                }
                if ((tmp.LeftChild == null && tmp.RightChild == null) ||
                    (tmp.LeftChild == prevNode && tmp.RightChild == null) ||
                    (tmp.RightChild != null && tmp.RightChild == prevNode))
                {
                    VisitNode(tmp);
                    prevNode = tmp;
                    s.Pop();
                }
            }
        }
    }

    /*
     * if tree node have a point to parent find next.
     */
    public class _046_FindNextWithParent
    {
        public TreeNode FindNode(TreeNode node)
        {
            if (node.RightChild != null)
            {
                node = node.RightChild;
                while (node.LeftChild != null)
                {
                    node = node.LeftChild;
                }
                return node;
            }
            else
            {
                while (node.Parent != null && node.Parent.RightChild == node)
                {
                    node = node.Parent;
                }
                return node.Parent;
            }
        }
    }
}
