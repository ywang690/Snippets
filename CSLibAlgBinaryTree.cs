using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLAlg
{
    internal class CSLibAlgBinaryTree
    {
        //94. Binary Tree Inorder Traversal
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> list = new List<int>();
            return list;
        }
        public class TreeNode
        {
             public int val;
             public TreeNode left;
             public TreeNode right;
             public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
                        {
                            this.val = val;
                            this.left = left;
                            this.right = right;
                                 }
         }
    }
}
