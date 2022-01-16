public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var len = nums.Length;
        if(nums.Length ==0) 
            return 0;
        int i = 0;
        for(int j =0;j<len;j++)
        {
            if(nums[j]!=val)
            { 
              nums[i]= nums[j];
                i++;
            }
        }
        return i;  
    }
}