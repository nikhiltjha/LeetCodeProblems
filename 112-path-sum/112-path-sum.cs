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
    //public static bool MatchedTargetSumFlag = false;
    public bool HasPathSum(TreeNode root, int target) 
    {
        return recursive(root, target);
    }
    
    public bool recursive(TreeNode root,int target)
    {    
        if(root == null) return false;
        if(root.left == null && root.right == null) {
            return root.val == target;
        } 
        else {
            int helpReq = target - root.val;
            return recursive(root.left, helpReq) || recursive(root.right, helpReq);
        }
    }
}