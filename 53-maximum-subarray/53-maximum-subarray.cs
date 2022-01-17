public class Solution {
    public int MaxSubArray(int[] nums) {
        if(nums.Length ==1) return nums[0];
        int max = nums[0];
        for(int i =1; i<nums.Length;i++)
        {
            if(nums[i-1]+nums[i]>=nums[i])
                nums[i] = nums[i-1]+ nums[i];
            if(nums[i] > max)
                max = nums[i];
            
        }
        return max;

        
    }
    
}