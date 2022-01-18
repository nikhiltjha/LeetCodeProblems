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
    public int MaxDepth(TreeNode root) {
        return Recursive(root);
    }
    public int Recursive(TreeNode node)
    {
        if(node == null) return 0;
        if(node.left == null && node.right ==null) return 1;
        else
        {
            return 1 + Math.Max(Recursive(node.left),Recursive(node.right));
        }
        
    }
}