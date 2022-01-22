public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var dict = new Dictionary<int,List<int>>();
        int i=0;
        foreach(int n in nums)
        {
            if(dict.ContainsKey(n))
            {
                foreach(int a in dict[n])
                {
                    if(Math.Abs(i-a)<=k)
                        return true;
                }
               
                dict[n].Add(i);
                
            }
            else
            {  
                dict[n]=new List<int>(){i};
            }
            i++;
        }
        return false;
        
    }
}