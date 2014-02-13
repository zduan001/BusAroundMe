using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.G_Code
{
    public class G_021_Print2BST
    {
        /*
         * 2个BST，按大小顺序打印两棵树的所有节点。
         * http://www.mitbbs.com/article_t/JobHunting/32266793.html
         * this question may not be a google question. 
         */
        public List<int> Print2BST(TreeNode root1, TreeNode root2)
        {
            List<int> res = new List<int>();
            Stack<TreeNode> s1 = new Stack<TreeNode>();
            Stack<TreeNode> s2 = new Stack<TreeNode>();
            s1.Push(root1);
            s2.Push(root2);
            bool isBackTrack1 = false;
            bool isBackTrack2 = false;

            while (s1.Count != 0 || s2.Count != 0)
            {
                TreeNode tmp1 = null;
                TreeNode tmp2 = null;
                if (s1.Count != 0)
                {
                    tmp1 = s1.Peek();
                    if (!isBackTrack1 && tmp1.LeftChild != null)
                    {
                        s1.Push(tmp1.LeftChild);
                        isBackTrack1 = false;
                        continue;
                    }
                }

                if (s2.Count != 0)
                {
                    tmp2 = s2.Peek();
                    if (!isBackTrack2 && tmp2.LeftChild != null)
                    {
                        s2.Push(tmp2.LeftChild);
                        isBackTrack2 = false;
                        continue;
                    }
                }

                if (tmp1 != null && tmp2 != null)
                {
                    if (tmp1.Value <= tmp2.Value)
                    {
                        tmp1 = s1.Pop();
                        res.Add(tmp1.Value);
                        isBackTrack1 = true;
                        tmp2 = null;
                    }
                    else if (tmp1.Value > tmp2.Value)
                    {
                        tmp2 = s2.Pop();
                        res.Add(tmp2.Value);
                        isBackTrack2 = true;
                        tmp1 = null;
                    }
                }
                else if (tmp1 != null && tmp2 == null)
                {
                    tmp1 = s1.Pop();
                    res.Add(tmp1.Value);
                    isBackTrack1 = true;
                    tmp2 = null;
                }
                else if (tmp2 != null && tmp1 == null)
                {
                    tmp2 = s2.Pop();
                    res.Add(tmp2.Value);
                    isBackTrack2 = true;
                    tmp1 = null;
                }

                if (tmp1 != null)
                {
                    if (tmp1.RightChild != null)
                    {
                        s1.Push(tmp1.RightChild);
                        isBackTrack1 = false;
                    }
                }
                else
                {
                    if (tmp2.RightChild != null)
                    {
                        s2.Push(tmp2.RightChild);
                        isBackTrack2 = false;
                    }
                }
            }
            return res;
        }

    }
}
