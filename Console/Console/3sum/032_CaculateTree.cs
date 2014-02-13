using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _032_CaculateTree
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public double CalcuateTree(StrTreeNode root)
        {
            if (root == null)
                throw new NullReferenceException("node can not be null.");

            double value;
            if (root.leftChild == null && root.rightChild == null)
            {
                // if a leaf node is not a number then let the exception throw.
                // leaf node must be a number.
                value = double.Parse(root.Value);
                return value;
            }
            else
            {
                double left = CalcuateTree(root.leftChild);
                double right = CalcuateTree(root.rightChild);

                switch(root.Value)
                {
                    case "+":
                        return left + right;
                        
                    case "-":
                        return left - right;
                        
                    case "*":
                        return left * right;
                        
                    case "/":
                        if (right == 0) throw new ArithmeticException("divid by zero");
                        return left / right;
                        
                    default:
                        throw new FormatException("should be operator");
                        
                }
            }

        }
    }


    public class StrTreeNode
    {
        public StrTreeNode(string s)
        {
            Value = s;
        }


        public string Value { get; set; }
        public StrTreeNode leftChild;
        public StrTreeNode rightChild;
    }
}
