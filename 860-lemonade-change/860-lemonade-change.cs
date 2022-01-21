public class Solution {
    public bool LemonadeChange(int[] bills) 
    {
        int numberOf5 = 0;
        int numberOf10 = 0;
        
        foreach(int bill in bills)
        {
            if(bill == 5) numberOf5++;
            else
            {
                if(bill == 10)
                    {
                        numberOf10++;
                        numberOf5--;
                    }
                else
                {
                    //bill is 20
                    //check for 10s first
                    if(numberOf10>0)
                    { 
                        numberOf10--;
                        numberOf5--;
                    }
                    else
                       numberOf5 -=3; 
                }
            }
            if(numberOf5<0)
                return false;
        }
        return true;  
    }
}