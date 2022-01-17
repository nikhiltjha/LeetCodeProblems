public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
        int i = m-1;
        int j = n-1;
        int tail = m+n-1;
        
        while(j >=0)
        {
            if(i >= 0 && j >= 0)
            {
                if(nums1[i]> nums2[j])
                {
                    nums1[tail] = nums1[i];
                    i--; 
                }
                else
                {
                    nums1[tail] = nums2[j];
                    j--;
                }  
            }
            else
            {
               if(j >=0)
                {
                  nums1[tail] = nums2[j];
                   j--;
                }
            }
            tail--;
        }
        
        
    }
}