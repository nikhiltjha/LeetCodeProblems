public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var len = nums.Length;
        if(nums.Length ==0) 
            return 0;
        //Dictionay help implementation
        //var memoryDict = new Dictionary<int,int>();
        //int j = 0;
        //int i = 0;
        //while(j<len)
        //{
        //  if(!memoryDict.ContainsKey(nums[j]))
        //  {
        //       nums[i]= nums[j];
        //       memoryDict[nums[j]]=1;
        //       i++;
        //   }
        //   j++; 
        //    
        //}
        //return i;
        
        //Using the condition that it is sorted
        int i = 0;
        for(int j =1;j< len;j++)
        {
            if(nums[i]!=nums[j])
            {
              i++;
              nums[i]= nums[j];  
            }
        }
        return i+1;
    }
}