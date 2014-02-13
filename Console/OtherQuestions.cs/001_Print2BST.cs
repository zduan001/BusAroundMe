using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherQuestions.cs
{
    public class _001_Print2BST
    {
        /* Difficulty : ***
         * 2个BST，按大小顺序打印两棵树的所有节点。
         * http://www.mitbbs.com/article_t/JobHunting/32266793.html
         * some thought:
         * 1. is BST tree can be breaked. I can merge 1 BST tree into another and 
         *    inorder travel. o(nlgn)
         * 2. if not. I can inorder travel 2 BST side by side and out put the smaller 
         *    node of the two.
         * I go with the method 2. the only tricky part of this approach is that I have to
         * be careful if one tree is iterated all and I have to make sure check if one stack
         * is empty. 
         */
        public List<int> PrintOut2BSTTrees(TreeNode root1, TreeNode root2)
        {
            List<int> res = new List<int>();

            Stack<TreeNode> s1 = new Stack<TreeNode>();
            Stack<TreeNode> s2 = new Stack<TreeNode>();
            s1.Push(root1);
            s2.Push(root2);
            bool isBackTrack1 = false;
            bool isBackTrack2 = false;
            while (s1.Count != 0 && s2.Count != 0)
            {
                TreeNode tmp1 = null;
                TreeNode tmp2 = null;
                if (s1.Count != 0)
                {
                    tmp1 = s1.Peek();
                }
                if (s2.Count != 0)
                {
                    tmp2 = s2.Peek();
                }

                if (tmp1 != null && !isBackTrack1 && tmp1.LeftChild != null)
                {
                    s1.Push(tmp1.LeftChild);
                    continue;
                }
                if (tmp2 != null && !isBackTrack2 && tmp2.LeftChild != null)
                {
                    s2.Push(tmp2.LeftChild);
                    continue;
                }

                if (tmp1 != null && tmp2 != null)
                {
                    if (tmp1.Value <= tmp2.Value)
                    {
                        s1.Pop();
                        isBackTrack1 = true;
                        res.Add(tmp1.Value);
                    }
                    else
                    {
                        s2.Pop();
                        isBackTrack2 = true;
                        res.Add(tmp2.Value);
                    }
                }
                else
                {
                    if (tmp1 != null)
                    {
                        s1.Pop();
                        isBackTrack1 = true;
                        res.Add(tmp1.Value);
                    }
                    else
                    {
                        s2.Pop();
                        isBackTrack2 = true;
                        res.Add(tmp2.Value);
                    }
                }

                if (tmp1 != null && isBackTrack1 && tmp1.RightChild != null)
                {
                    s1.Push(tmp1.RightChild);
                    isBackTrack1 = false;
                }
                if (tmp2 != null && isBackTrack2 && tmp2.RightChild != null)
                {
                    s2.Push(tmp2.RightChild);
                    isBackTrack2 = false;
                }
            }
            return res;
        }
    }
}
