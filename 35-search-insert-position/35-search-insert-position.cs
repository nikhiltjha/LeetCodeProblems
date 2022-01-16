public class Solution {
    public int SearchInsert(int[] nums, int target) 
    {
        var n = nums.Length;
        if(n ==0)
            return 0;
        int i=0;
        for(i=0; i<n;i++)
        {
           if(nums[i]>=target)
           {
               return i;
           } 
        }
        return i;
        
    }
}