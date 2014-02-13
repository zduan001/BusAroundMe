using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _004_SumRoottoLeafNumbers
    {
        /*
         * Sum Root to Leaf Numbers
         * http://leetcode.com/onlinejudge#question_129
         */
        public int CalCulateSum(TreeNode root)
        {
            int res = 0;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode tmp = root;
            stack.Push(tmp);
            TreeNode prev= null;
            while (stack.Count != 0 )
            {
                TreeNode top = stack.Peek();
                if (top.LeftChild == null && top.RightChild == null)
                {
                    res += this.GetValueFromStack(stack);
                    stack.Pop();
                }
                else if(prev == top.LeftChild)
                {
                    if (top.RightChild != null)
                    {
                        stack.Push(top.RightChild);
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
                else if (prev == top.RightChild)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(top.LeftChild);
                }

                prev = top;
            }
            return res;
        }

        private int GetValueFromStack(Stack<TreeNode> input)
        {
            int res = 0;
            Stack<TreeNode> tmp = new Stack<TreeNode>();
            int pow = 0;
            while (input.Count != 0)
            {
                res = res + (int)(input.Peek().Value * Math.Pow(10, pow++));
                tmp.Push(input.Pop());
            }
            while (tmp.Count != 0)
            {
                input.Push(tmp.Pop());
            }
            return res;
        }
    }
}
