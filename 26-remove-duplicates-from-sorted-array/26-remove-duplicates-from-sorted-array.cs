public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var len = nums.Length;
        var memoryDict = new Dictionary<int,int>();
        int j = 0;
        int i = 0;
        while(j<len)
        {
           if(!memoryDict.ContainsKey(nums[j]))
           {
               nums[i]= nums[j];
               memoryDict[nums[j]]=1;
               i++;
           }
           j++; 
            
        }
        return i;
    }
}