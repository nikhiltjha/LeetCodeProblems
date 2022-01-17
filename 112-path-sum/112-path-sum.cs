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

    public bool HasPathSum(TreeNode root, int targetSum) 
    {
        bool [] res = new bool[1];
        res[0] = false;
        if (root== null) return false;
        int currSum =0;
        findPathSumMatch(root,targetSum,currSum, res);
        return res[0];
        
    }
    public void findPathSumMatch(TreeNode node,int targetSum,int currSum, bool [] res)
    {    
        currSum = currSum + node.val;
        if(node.left == null && node.right ==null)
        { 
            if(targetSum == currSum)
               res[0] = true;
            return;
                
        }
        if(node.left != null)
        {
            findPathSumMatch(node.left,targetSum,currSum, res);
        }
    
        if(node.right != null)
        {
            findPathSumMatch(node.right,targetSum,currSum, res);
        }
    }
}