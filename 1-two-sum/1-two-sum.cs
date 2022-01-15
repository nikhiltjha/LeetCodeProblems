public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        var memoryDict = new Dictionary<int,int>();
        var len = nums.Length;
        
        for(int i =0; i<len; i++)
        {
            var complement =target -nums[i];
            if(!memoryDict.ContainsKey(complement))
               {
                       memoryDict[nums[i]]=i;
               }
             else
               {
                   return new int[]{memoryDict[complement],i};
               }
             
        }
        return null;
        
    }
}