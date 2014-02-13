using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.G_Code
{
    public class G_048_TreeIterator
    {
        /*
         * If there is an tree structure data, design an algorithm for function next() which
         * returns one data each time and this function will access all the data only once.
         */

        private TreeNode Root{get;set;}

        private Stack<TreeNode> S;
        private bool IsBackTrack;

        public G_048_TreeIterator(TreeNode input)
        {
            Root = input;
            S = new Stack<TreeNode>();
            S.Push(input);
            IsBackTrack = false;

        }

        public TreeNode Next()
        {
            TreeNode res = null;
            if (S.Count != 0)
            {
                TreeNode tmp = S.Peek();
                if (!IsBackTrack)
                {
                    while (tmp.LeftChild != null)
                    {
                        tmp = tmp.LeftChild;
                        S.Push(tmp);
                    }
                }

                tmp = S.Pop();
                res = tmp;
                IsBackTrack = true;

                if (tmp.RightChild != null)
                {
                    S.Push(tmp.RightChild);
                    IsBackTrack = false;
                }
                return res;
            }
            return null; // if Already iterate all tree node. 
        }


    }
}
