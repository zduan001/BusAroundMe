using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.From_076_To_100
{
    public class _089_RecoverBST
    {
        /*
         * Two elements of BST are swapped by mistake. You have to restore the tree without changing its structure.
         */
        public void RecoverBST(TreeNode root)
        {
            TreeNode first = null;
            TreeNode second = null;
            TreeNode previous = null;
            TreeNode previousOfPrevious = null;
            bool backTrack = false;
            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);

            while (s.Count > 0)
            {
                TreeNode tmp = s.Peek();
                if (!backTrack && tmp.LeftChild != null)
                {
                    s.Push(tmp.LeftChild);
                    continue;
                }

                if (previous != null && previous.Value > tmp.Value)
                {
                    if (first == null)
                    {
                        first = tmp;
                        if (previousOfPrevious != null && first.Value > previousOfPrevious.Value)
                        {
                            second = previous;
                            break;
                        }
                    }
                    else if (second == null)
                    {
                        second = tmp;
                        break;
                    }
                }
                s.Pop();
                backTrack = true;
                previousOfPrevious = previous;
                previous = tmp;

                if (tmp.RightChild != null)
                {
                    s.Push(tmp.RightChild);
                    backTrack = false;
                }
            }

            //Swap(frist, second);
        }
    }
}
