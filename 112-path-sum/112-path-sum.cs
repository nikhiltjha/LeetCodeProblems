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
        //bool [] res = new bool[1];
        bool res = false;
        if (root== null) return false;
        int currSum =0;
        findPathSumMatch(root,targetSum,currSum, ref res);
        return res;
        
    }
    public void findPathSumMatch(TreeNode node,int targetSum,int currSum, ref bool res)
    {    
        currSum = currSum + node.val;
        if(node.left == null && node.right ==null)
        { 
            if(targetSum == currSum)
               res = true;
            return;
                
        }
        if(node.left != null)
        {
            findPathSumMatch(node.left,targetSum,currSum, ref res);
        }
    
        if(node.right != null)
        {
            findPathSumMatch(node.right,targetSum,currSum, ref res);
        }
    }
}