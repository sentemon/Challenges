// 2331. Evaluate Boolean Binary Tree
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool EvaluateTree(TreeNode root) {
        if (root == null)
            return false;

        if (root.left == null && root.right == null)
            return root.val == 1;
        
        bool leftValue = EvaluateTree(root.left);
        bool rightValue = EvaluateTree(root.right);

        if (root.val == 2)
            return leftValue || rightValue;
        if (root.val == 3)
            return leftValue && rightValue;
        
        return false;
    }
}