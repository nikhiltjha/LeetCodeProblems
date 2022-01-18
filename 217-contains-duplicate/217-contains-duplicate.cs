public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var memorySet = new HashSet<int>();
        foreach(int num in nums)
        {
            if(memorySet.Contains(num))
                return true;
            memorySet.Add(num);       
        }
        return false;
    }
}