public class Solution {
    public int LengthOfLastWord(string s) 
    {
        int len =s.Length;
        if(s[len-1]==' ')
        {
            int i = len-1;
            while(s[i] == ' ')
            {
                i--;
                len--;
            }   
        }
        int count = 0;
        for(int i = len-1;i>=0;i--)
        {
           if(s[i]== ' ')
           {
               return count;
           }
            count ++;
        }
        return count;
        
    }
}