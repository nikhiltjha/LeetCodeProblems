public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var dict = new Dictionary<int,List<int>>();
        int i=0;
        foreach(int n in nums)
        {
            if(dict.ContainsKey(n))
            {
                var arr = dict[n];
                foreach(var a in arr)
                {
                    if(Math.Abs(i-a)<=k)
                        return true;
                }
                arr.Add(i);
                dict[n] = arr;
                
            }
            else
            {   var arr = new List<int>();
                arr.Add(i);
                dict[n]=arr;
            }
            i++;
        }
        return false;
        
    }
}