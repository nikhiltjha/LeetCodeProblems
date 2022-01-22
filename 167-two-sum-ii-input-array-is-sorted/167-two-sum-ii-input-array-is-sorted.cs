public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int index1=0;
        int index2 = numbers.Length-1;
        
        for(index1=0;index1<index2;)
        {
            var sum =numbers[index1]+numbers[index2];
            if(target<sum)
                index2--;
            if(target >sum)
                index1++;
            if(target == sum)
                break;
            
        }
        return new int[]{index1+1,index2+1};
        
        
    }
}