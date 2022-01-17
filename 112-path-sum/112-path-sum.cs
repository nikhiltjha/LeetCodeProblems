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
    public static bool MatchedTargetSumFlag = false;
    public bool HasPathSum(TreeNode root, int targetSum) 
    {
        if (root== null) return false;
        MatchedTargetSumFlag = false;
        int currSum =0;
        findPathSumMatch(root,targetSum,currSum);
        return MatchedTargetSumFlag;
        
    }
    public void findPathSumMatch(TreeNode node,int targetSum,int currSum)
    {    currSum = currSum + node.val;
     
        if(node.left == null && node.right ==null)
        { 
            if(targetSum == currSum)
                MatchedTargetSumFlag = true;
            return;
                
        }
        if(node.left != null)
        {
            findPathSumMatch(node.left,targetSum,currSum);
        }
    
        if(node.right != null)
        {
            findPathSumMatch(node.right,targetSum,currSum);
        }
    }
}