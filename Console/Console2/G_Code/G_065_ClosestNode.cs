using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infra;

namespace Console2.G_Code
{
    public class G_065_ClosestNode
    {
        /*
         * 一个BST，节点是double，输入一个k，找到和这个k最接近的节点。
         */
        /// <summary>
        /// Try to do it logn.
        /// this is K-D tree method.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int FindClosest(TreeNode root, int value)
        {
            TreeNode res = null;
            int dist = int.MaxValue;
            Worker(root, value, ref dist, ref res);
            return dist;
        }

        public void Worker(TreeNode root, int value, ref int dist, ref TreeNode node)
        {
            if (root.Value == value)
            {
                dist = 0;
                node = root;
                return;
            }
            else if (value < root.Value && root.LeftChild != null)
            {
                Worker(root.LeftChild, value, ref dist, ref node);
            }
            else if (value > root.Value && root.RightChild != null)
            {
                Worker(root.RightChild, value, ref dist, ref node);
            }
            else
            {
                node = root;
                dist = Math.Abs(root.Value - value);
                return;
            }

            int tmp = Math.Abs(root.Value - value);
            if (tmp < dist)
            {
                dist = tmp;
                node = root;
            }
            return;
        }
    }
}
