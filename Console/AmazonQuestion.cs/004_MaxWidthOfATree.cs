using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonQuestion.cs
{
    public class _004_MaxWidthOfATree
    {
        /*
         * 求树的最大宽度。
         * http://www.mitbbs.com/article_t/JobHunting/32067899.html
         * Let us consider the below example tree.
                     1
                    /  \
                   2    3
                 /  \     \
                4    5     8 
                          /  \
                         6    7
             For the above tree,
             width of level 1 is 1,
             width of level 2 is 2,
             width of level 3 is 3
             width of level 4 is 2. 
         */
        public int MaxWidth(TreeNode root)
        {
            if (root == null) return 0;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            q.Enqueue(null);
            int maxWidth = int.MinValue;
            int currentWidth = 0;
            while (q.Count != 0)
            {
                TreeNode tmp = q.Dequeue();
                if (tmp == null)
                {
                    maxWidth = maxWidth > currentWidth ? maxWidth : currentWidth;
                    currentWidth = 0;
                    if (q.Count == 0)
                    {
                        break;
                    }
                    else
                    {
                        q.Enqueue(null);
                    }
                }
                else
                {
                    currentWidth++;
                    if (tmp.LeftChild != null)
                    {
                        q.Enqueue(tmp.LeftChild);
                    }
                    if (tmp.RightChild != null)
                    {
                        q.Enqueue(tmp.RightChild);
                    }
                }
            }
            return maxWidth;
        }
    }
}
