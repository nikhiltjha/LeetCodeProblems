public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        var memoryDict = new Dictionary<int,int>();
        var len = nums.Length;
        
        for(int i =0; i<len; i++)
        {
            if(!memoryDict.ContainsKey(target -nums[i]))
               {
                       memoryDict[nums[i]]=i;
               }
             else
               {
                   return new int[]{memoryDict[target-nums[i]],i};
               }
             
        }
        return null;
        
    }
}