public class Solution {
    public int[] PlusOne(int[] digits) 
    {
        var len =digits.Length;
        if(digits[len -1] < 9)
        {
            digits[len -1] = digits[len-1]+1;
            return digits;
        }
        else
        {
            var carry = 1;
            for(int i =len -1;i>=0; i--)
            {
                if(carry ==1)
                {
                    var tempDigitSum =digits[i]+ carry ;
                    if(tempDigitSum>9)
                    {
                        carry =1;
                        digits[i] = 0;
                    }
                     else
                     {
                        carry =0;
                        digits[i] = digits[i]+1;
                     }
                }
                else
                {
                    carry =0;
                    digits[i] = digits[i];
                }
            }
            
            if(carry==0)
                return digits;
            else
            {
                var newDigitsArray = new int[len+1];
                newDigitsArray[0] = 1;
                for(int i = 1; i<len+1;i++)
                {
                    newDigitsArray[i] =digits[i-1];
                }
                return newDigitsArray;
            }  
        }
        
        
    }
}