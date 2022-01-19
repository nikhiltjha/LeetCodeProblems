public class Solution {
    public int SingleNumber(int[] nums) 
    {
        var len = nums.Length;
        if (len == 1) return nums[0];
        var res = nums[0];
        for(int i =1;i<len;i++)
        {
            res = res ^ nums[i];
        }
        return res;
        
        
    }
}