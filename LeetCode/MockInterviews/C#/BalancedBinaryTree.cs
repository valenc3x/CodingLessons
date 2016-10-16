using System;

namespace MockInterviews
{
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    class BalancedBinaryTree
    {
        public bool IsBalanced(TreeNode root){
            if (root == null) {
                return true;
            }
            int rightDepth = 0;
            if (root.right != null) {
                rightDepth = BranchDepth(root.right);
            }
            int leftDepth = 0;
            if (root.left != null) {
                leftDepth = BranchDepth(root.left);
            }
            int diff = Math.Abs(leftDepth - rightDepth);
            return diff <= 1;
        }

        public static int BranchDepth(TreeNode root){
            int rightDepth = 0;
            int leftDepth = 0;
            if (root.left != null) {
             leftDepth += BranchDepth(root.left);
            }else{
             return 1;
            }
            if (root.right != null) {
             rightDepth += BranchDepth(root.right);
            }else{
             return 1;
            }
            return Math.Abs(leftDepth - rightDepth);
        }

    }
}
