public class Solution
{
    public int Trap(int[] height)
    {
        int i=0;
        int j=height.Count()-1;
        int water = 0;
        if(j<2)
        {
            return 0;    
        }
        int lMax=0;
        int rMax=0;
        while(i<j)
        {
            if(height[i]<height[j])
            {
              
                if(height[i] >= lMax)
                {
                    lMax = height[i];
                }               
                water += lMax-height[i];
                i++;
            }
            else
            {
                
                if(height[j]>= rMax)
                {
                    rMax= height[j];   
                }
                water += rMax-height[j];   
                j--;
            }
            
        }
        return water;
            
        
    }
}